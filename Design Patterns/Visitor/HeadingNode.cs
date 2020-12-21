using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
