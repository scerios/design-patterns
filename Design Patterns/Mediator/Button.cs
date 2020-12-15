using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public bool IsEnabled {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                Owner.Changed(this);
            }
        }

        public Button(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
