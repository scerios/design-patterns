using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.editor
{
    public class UndoCommand : ICommand
    {
        public History History { get; set; }

        public UndoCommand(History history)
        {
            History = history;
        }

        public void Execute()
        {
            if (History.GetSize() > 0)
            {
                History.Pop().Unexecute();
            }
        }
    }
}
