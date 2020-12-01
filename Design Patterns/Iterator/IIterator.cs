using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator
{
    public interface IIterator<T>
    {
        T Current();
        bool HasNext();
        void Next();
    }
}
