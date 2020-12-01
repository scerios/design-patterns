﻿using Design_Patterns.Iterator;
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
        /// Limitation is there is only 1 state which can be active.
        /// </summary>
        static void State()
        {
            var canvas = new Canvas();

            // MouseDown() and MouseUp() going to do differently based on which Tool is applied.
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }

        /// <summary>
        /// Since the Iterator doesn't depend on the type of collection, the same code can be used to iterate through any collection. 
        /// If collection is changed, only the class that holds the collection has to be changed aswell.
        /// </summary>
        static void Iterator()
        {
            var history = new BrowseHistory();
            history.Push("A");
            history.Push("B");
            history.Push("C");

            var iterator = history.createIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }
    }
}
