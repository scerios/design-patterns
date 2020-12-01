using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Memento
{
    public class EditorState
    {
        public string Content { get; set; }

        public EditorState(string content)
        {
            Content = content;
        }

    }
}
