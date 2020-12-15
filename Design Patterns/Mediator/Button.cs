using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class Button : UIControl
    {
        public bool IsEnabled {
            get => IsEnabled;
            set
            {
                IsEnabled = value;
                Owner.Changed(this);
            }
        }

        public Button(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
