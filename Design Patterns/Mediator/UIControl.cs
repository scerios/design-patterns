using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class UIControl
    {
        public DialogBox Owner { get; set; }

        public UIControl(DialogBox dialogBox)
        {
            Owner = dialogBox;
        }
    }
}
