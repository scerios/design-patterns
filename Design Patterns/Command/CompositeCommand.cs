using Design_Patterns.Command.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command
{
    class CompositeCommand : ICommand
    {
        public List<ICommand> Commands { get; set; } = new List<ICommand>();

        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
