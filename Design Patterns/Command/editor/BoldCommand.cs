using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Command.editor;

namespace Design_Patterns.Command.editor
{
    public class BoldCommand : IUndoableCommand
    {
        public string PreviousContent { get; set; }
        public HtmlDocument Document { get; set; }
        public History History { get; set; }

        public BoldCommand(HtmlDocument document, History history)
        {
            Document = document;
            History = history;
        }

        public void Execute()
        {
            PreviousContent = Document.Content;
            Document.MakeBold();
            History.Push(this);
        }

        public void Unexecute()
        {
            Document.Content = PreviousContent;  
        }
    }
}
