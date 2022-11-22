using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKryptoAndCompression.Compression_algorytm
{
    public interface ICompressionLz77
    {
        void CompressFileLz77(string fileName, string? outputFileName, BackgroundWorker worker);
        void DecompressFileLz77(string fileName, string? outputFileName,BackgroundWorker worker);
    }
}
