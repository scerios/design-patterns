using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
