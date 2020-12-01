using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
