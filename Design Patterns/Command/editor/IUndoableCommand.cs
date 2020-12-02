using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.editor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
