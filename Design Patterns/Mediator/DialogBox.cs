using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}
