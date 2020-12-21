using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public List<IHtmlNode> Nodes
        {
            get => _nodes;
            private set 
            { 
                _nodes = value; 
            }
        }

        public void AddNode(IHtmlNode node)
        {
            _nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
