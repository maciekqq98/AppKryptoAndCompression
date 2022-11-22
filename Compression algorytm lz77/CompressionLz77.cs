using AppKryptoAndCompression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppKryptoAndCompression.Compression_algorytm;

namespace WindowsFormsAppKryptoAndCompression.Compression_algorytm
{
    public enum Lz77BufferSize
    {
        B32 = 31,
        B64 = 63,
        B128 = 127,
        B256 = 255
    };

    public sealed class CompressionLz77 : ICompressionLz77
    {
        //arrays size 
        private readonly ushort dictionarySize;
        private readonly ushort bufferSize;

        //how many bits is needed to write: Position and Lenght from LZ77 coder output 
        //private readonly ushort _dictionaryBitLen;
        private readonly ushort bufferBitLen;

      
        private Lz77Model ConvertShortToCoderOutput(ushort number)
        {
            return new Lz77Model(
                Position: (ushort)((number >> (bufferBitLen)) & dictionarySize),
                Length: (byte)(number & bufferSize),
                Byte: (byte)0);
        }

       
        private ushort ConvertCoderOutputToShort(Lz77Model model)
        {
            ushort number;
            number = model.Length;
            number += (ushort)(model.Position << bufferBitLen);
            return number;
        }

        
        private Lz77Model GetLongestSubstring(ReadOnlySpan<byte> dictionary, ReadOnlySpan<byte> buffer)
        {
            return KMPSearch.KMPGetLongestMatch(dictionary, buffer);
        }

       
        public CompressionLz77(Lz77BufferSize bufferSize = Lz77BufferSize.B256)
        {
            dictionarySize = 32767;
            this.bufferSize = (ushort)bufferSize;
            //_dictionaryBitLen = 10;
            bufferBitLen = 8;
        }

        
        public void CompressFileLz77(string fileName, string? outputFileName, BackgroundWorker worker)
        {
            Span<byte> dictionary = new byte[2 * dictionarySize];
            Span<byte> buffer = new byte[4 * bufferSize];

            var inputFile = File.OpenRead(fileName);
            var outputFile = File.Create(outputFileName is null ? (fileName + ".lz77") : (outputFileName + ".lz77"));

            var inputStream = new BinaryReader(inputFile);
            var outputStream = new BinaryWriter(outputFile);

            ushort dictionaryFillNumber = 0;
            ushort bufferFillNumber;

            ushort bufferSegmentOffset = 0;
            ushort dictionarySegmentOffset = 0;

            bool endData = false;

            var fst = inputStream.ReadBytes(4 * bufferSize);
            fst.CopyTo(buffer);

            bufferFillNumber = (ushort)fst.Length;

            long rozmiar = inputFile.Length;
            int testowa =0;
            worker.ReportProgress(1);
            while (bufferFillNumber > 0)
            {

                //1. znajdź najdłuższy ciąg w 'buffer' ktory istnieje w 'dictionary'
                //2. wyznacz (P,C,'a') 
                //      P - index gdzie się zaczyna ciąg w 'dictionary'
                //      C - długość ciągu
                //      'a' - następny znak w 'buffer' po tym ciągu
                //3. przesuń 'dictionary' o C + 1 pozycji w prawo
                //4. skopiuj C + 1 elementów z buffer do 'dictionary'
                //5. przesuń C + 1 elementów w lewo w 'buffer'
                //6. dodaj C + 1 nowych elementów ze 'stream' do 'buffer'
                //7. dodaj do pliku wyjsciowego C + (P << bitLen(C)) oraz 'a' jako liczba i znak


                 
                //1 2
                var coderOut = GetLongestSubstring(
                    dictionary.Slice(dictionarySegmentOffset, dictionarySize),
                    buffer.Slice(bufferSegmentOffset, bufferSize));

                testowa += coderOut.Length;

                //worker.ReportProgress((int)(100 * ((double)testowa / rozmiar)));
                if (coderOut.Length < bufferFillNumber)
                {
                    //3
                    if ((dictionaryFillNumber + coderOut.Length + 1) > dictionarySize)
                    {
                        if ((dictionarySegmentOffset + coderOut.Length + 1) >= dictionarySize)
                        {
                            Span<byte> arr = new byte[2 * dictionarySize];
                            dictionary.Slice(dictionarySegmentOffset, dictionarySize).CopyTo(arr);
                            dictionary = arr;
                            dictionarySegmentOffset = 0;
                        }
                        var rest = (ushort)((coderOut.Length + 1) - (dictionarySize - dictionaryFillNumber));
                        dictionarySegmentOffset += rest;
                        dictionaryFillNumber -= rest;
                    }
                    //4
                    buffer
                        .Slice(bufferSegmentOffset, coderOut.Length + 1)
                        .CopyTo(dictionary.Slice(dictionarySegmentOffset + dictionaryFillNumber, coderOut.Length + 1));

                    //5
                    if (bufferSegmentOffset + (coderOut.Length + 1) >= (3 * bufferSize))
                    {
                        Span<byte> arr = new byte[4 * bufferSize];

                        // 6
                        if (!endData)
                        {
                           

                            var tmp = inputStream.ReadBytes(4 * bufferSize - bufferFillNumber);
                            tmp.CopyTo(arr.Slice((bufferFillNumber)));
                            endData = (tmp.Length < (4 * bufferSize - bufferFillNumber));
                            bufferFillNumber += (ushort)(tmp.Length);
                        }

                        buffer.Slice(bufferSegmentOffset).CopyTo(arr);
                        buffer = arr;
                        bufferSegmentOffset = 0;
                    }

                    bufferFillNumber -= (ushort)(coderOut.Length + 1);
                    bufferSegmentOffset += (ushort)(coderOut.Length + 1);
                    dictionaryFillNumber += (ushort)(coderOut.Length + 1);

                    //7
                    outputStream.Write(coderOut);

                    
                }
                else
                {
                    //6
                    bufferFillNumber = 0;
                    //7
                    outputStream.Write(coderOut);
                }
            }
            
            //flush data and close files
            inputStream.Close();
            inputFile.Close();

            outputStream.Flush();
            outputStream.Close();
            outputFile.Close();
        }

       
        public void DecompressFileLz77(string fileName, string? outputFileName, BackgroundWorker worker)
        {
            Span<byte> dictionary = new byte[2 * dictionarySize];

            if (fileName.EndsWith(".lz77"))
            {
                string NameFile = fileName.Remove(fileName.Length - 5);

                string newFileOut = AESRJ.GetUniqueFilename(NameFile); // co tu 
                var inputFile = File.OpenRead(fileName); // co tu 
                var inputStream = new BinaryReader(inputFile);


                 var outputFile = File.Create(newFileOut); // tu wazne (newFileOut ?? (fileName[0..^5]));
                var outputStream = new BinaryWriter(outputFile);

                ushort dictionaryFillNumber = 0;
                ushort dictionarySegmentOffset = 0;

                worker.ReportProgress(1);
                while (inputStream.BaseStream.Position + 4 < inputStream.BaseStream.Length)
                {
                    //1. pobierz (P,C,'a')
                    //2. skopiuj na podstawie P i C z 'dictionary' do 'buffer'
                    //3. doklej do 'buffer' 'a'
                    //4. przesuń C + 1 elementów w prawo w 'dictionary'
                    //5. dodaj C + 1 nowych elementów ze 'buffer' do 'dictionary'
                    //6. dodaj do pliku wyjsciowego 'buffer'

                    //1
                    var model = new Lz77Model(
                        inputStream.ReadUInt16(),
                        inputStream.ReadByte(),
                        inputStream.ReadByte());
                    //2
                    //3
                    ReadOnlySpan<byte> source = dictionary.Slice(dictionarySegmentOffset + model.Position, model.Length);
                    //4
                    if ((dictionaryFillNumber + model.Length + 1) > dictionarySize)
                    {
                        if ((dictionarySegmentOffset + model.Length + 1) >= dictionarySize)
                        {
                            Span<byte> arr = new byte[2 * dictionarySize];
                            dictionary.Slice(dictionarySegmentOffset, dictionarySize).CopyTo(arr);
                            dictionary = arr;
                            dictionarySegmentOffset = 0;
                        }
                        var rest = (ushort)((model.Length + 1) - (dictionarySize - dictionaryFillNumber));
                        dictionarySegmentOffset += rest;
                        dictionaryFillNumber -= rest;
                    }
                    //5
                    Span<byte> dest = dictionary.Slice(dictionarySegmentOffset + dictionaryFillNumber, model.Length + 1);
                    source.CopyTo(dest);
                    dest[model.Length] = model.Byte;
                    dictionaryFillNumber += (ushort)(model.Length + 1);
                    //6
                    outputStream.Write(dest);
                }
                //last iteration  
                var last = new Lz77Model(
                    Position: inputStream.ReadUInt16(),
                    Length: inputStream.ReadByte(),
                    Byte: inputStream.ReadByte());
                outputStream.Write(dictionary.Slice(dictionarySegmentOffset + last.Position, last.Length));

                //flush data and close file
                inputStream.Close();
                inputFile.Close();

                outputStream.Flush();
                outputStream.Close();
                outputFile.Close();
            }
            else
            {
                throw new FileNotFoundException("wrong input file extension (should end with .lz77)");
            }
        }

        static class KMPSearch
        {
          
            private static int[] BuildSearchTable(ReadOnlySpan<byte> buffer)
            {
                int[] tab = new int[buffer.Length];

                int i = 2, j = 0;
                tab[0] = -1; tab[1] = 0;

                while (i < buffer.Length)
                {
                    if (buffer[i - 1] == buffer[j])
                    {
                        ++j;
                        tab[i] = j;
                        ++i;
                    }
                    else
                    {
                        if (j > 0)
                        {
                            j = tab[j];
                        }
                        else
                        {
                            tab[i] = 0;
                            ++i;
                        }
                    }
                }
                return tab;
            }

           
            public static Lz77Model KMPGetLongestMatch(ReadOnlySpan<byte> dictionary, ReadOnlySpan<byte> buffer)
            {

                if (buffer.Length == 0) throw new IndexOutOfRangeException();

                // var tab = BuildSearchTable(buffer);
                ///int[] tab = new int[buffer.Length];
                ///
                var tab = BuildSearchTable(buffer);
                int m = 0;  // Beginning of the first fit in dictionary
                int i = 0;  // Position of the current char in buffer

                int bestPos = 0;
                int bestLength = 0;

                while (m + i < dictionary.Length)
                {
                    if (buffer[i] == dictionary[m + i])
                    {
                        ++i;

                        if (i == buffer.Length - 1)
                        {
                            return new Lz77Model(Position: (ushort)m, Length: (byte)i, Byte: buffer[i]);
                        }

                        if (i > bestLength)
                        {
                            bestLength = i;
                            bestPos = m;
                        }
                    }
                    else
                    {
                        m = m + i - tab[i];
                        if (i > 0)
                        {
                            i = tab[i];
                        }
                    }
                }

                return new Lz77Model(
                    Position: (ushort)bestPos,
                    Length: (byte)bestLength,
                    Byte: buffer[bestLength]);
            }
        }
    }
}
