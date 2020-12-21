using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
