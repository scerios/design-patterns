using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
