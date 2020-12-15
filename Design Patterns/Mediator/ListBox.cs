using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class ListBox : UIControl
    {
        public string Selection {
            get => Selection; 
            set
            {
                Selection = value;
                Owner.Changed(this);
            }
        }

        public ListBox(DialogBox dialogBox) : base(dialogBox)
        {

        }
    }
}
