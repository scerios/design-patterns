using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection;
        public string Selection {
            get => _selection; 
            set
            {
                _selection = value;
                Owner.Changed(this);
            }
        }

        public ListBox(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
