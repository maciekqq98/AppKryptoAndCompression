using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppKryptoAndCompression.Compression_algorytm
{
    public class Lz77Model
    {

        public Lz77Model(ushort Position, byte Length, byte Byte)
        {
            this.Position = Position;
            this.Length = Length;
            this.Byte = Byte;
        }

        public ushort Position { get; } = default!;
        public byte Length { get; } = default!;
        public byte Byte { get; } = default!;
    }
}
