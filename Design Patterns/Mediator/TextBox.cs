using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class TextBox : UIControl
    {
        public string Content {
            get => Content;
            set
            {
                Content = value;
                Owner.Changed(this);
            }
        }

        public TextBox(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
