using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public interface ICompressor
    {
        void Compress(string fileName);
    }
}
