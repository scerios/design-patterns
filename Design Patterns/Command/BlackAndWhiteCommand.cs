using Design_Patterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Applying Black and white filter.");
        }
    }
}
