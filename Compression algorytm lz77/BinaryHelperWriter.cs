using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppKryptoAndCompression.Compression_algorytm;

namespace WindowsFormsAppKryptoAndCompression.Compression_algorytm
{

    

public static class BinaryHelperWriter
    {
        public static void Write(this BinaryWriter writer, Lz77Model model)
        {
            writer.Write(model.Position);
            writer.Write(model.Length);
            writer.Write(model.Byte);
        }
    }
}

