using Design_Patterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizing");
        }
    }
}
