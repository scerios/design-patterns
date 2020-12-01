using Design_Patterns.Memento;
using Design_Patterns.State;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Basically it keeps the state of an object in a list so it can be recovered and restored.
        /// </summary>
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

        /// <summary>
        /// Useful abstraction technic to avoid too many if statements. Polymorphism and dependency injection all at once.
        /// </summary>
        static void State()
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
