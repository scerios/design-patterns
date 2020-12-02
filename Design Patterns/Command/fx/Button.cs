using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.fx
{
    public class Button
    {
        public ICommand Command { get; set; }
        public string Label { get; set; }

        public Button(ICommand command)
        {
            Command = command;
        }

        public void Click()
        {
            Command.Execute();
        }
    }
}
