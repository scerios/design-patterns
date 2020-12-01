using Design_Patterns.Memento;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Memento()
        {
            var editor = new Editor();
            var history = new History();

            // Creating a new content and saving it as a state.
            editor.Content = "A";
            history.Push(editor.CreateState());

            // Creating a new content and saving it as a state.
            editor.Content = "B";
            history.Push(editor.CreateState());

            // Creating a new content and restoring the previous ("B") one.
            editor.Content = "C";
            editor.Restore(history.Pop());

            // Restoring the previous ("A") one.
            editor.Restore(history.Pop());
        }
    }
}
