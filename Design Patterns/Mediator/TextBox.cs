using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class TextBox : UIControl
    {
        private string _content;
        public string Content {
            get => _content;
            set
            {
                _content = value;
                Owner.Changed(this);
            }
        }

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
