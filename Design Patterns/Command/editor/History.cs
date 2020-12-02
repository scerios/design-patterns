using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.editor
{
    public class History
    {
        public Queue<IUndoableCommand> Commands { get; set; } = new Queue<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            Commands.Enqueue(command);
        }

        public IUndoableCommand Pop()
        {
            return Commands.Dequeue();
        }

        public int GetSize()
        {
            return Commands.Count;
        }
    }
}
