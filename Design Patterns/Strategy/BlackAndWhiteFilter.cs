using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying Black and White filter.");
        }
    }
}
