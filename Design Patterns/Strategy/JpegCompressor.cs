using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing with JPEG.");
        }
    }
}
