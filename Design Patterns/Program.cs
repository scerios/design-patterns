﻿using Design_Patterns.Command;
using Design_Patterns.Command.editor;
using Design_Patterns.Command.fx;
using Design_Patterns.Iterator;
using Design_Patterns.Memento;
using Design_Patterns.Observer;
using Design_Patterns.State;
using Design_Patterns.Strategy;
using Design_Patterns.Template;
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
            var history = new Memento.History();

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

        /// <summary>
        /// Quite similar to State pattern, difference is there is no state here at all. Dependency is injected right when calling the method.
        /// One object's any methods can act in a lot of ways depending on what other classes are injected.
        /// </summary>
        static void Strategy()
        {
            var imageStorage = new ImageStorage();
            imageStorage.Store(
                "File",
                new JpegCompressor(),
                new BlackAndWhiteFilter()
                );
        }

        /// <summary>
        /// By using an abstract base class code duplication can be removed if multiple classes would do the same methods.
        /// </summary>
        static void Template()
        {
            var transferMoneyTask = new TransferMoneyTask();
            transferMoneyTask.Execute();

            var generateReportTask = new GenerateReportTask();
            generateReportTask.Execute();
        }

        /// <summary>
        /// With Command its easy to build an independent framework that anyone can use. By creating a custom service which implements a base interface,
        /// any command can be run with the same method, depending on the service.
        /// </summary>
        static void Command()
        {
            // One command attached to an action.
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            // Multiple commands attached to an action.
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();

            // Using the undo mechanism. Multiple commands are implementing the same interface(s) and using the same history.
            var history = new Command.editor.History();
            var document = new HtmlDocument();
            document.Content = "Hello";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);

            var undoCommant = new UndoCommand(history);
            undoCommant.Execute();

            Console.WriteLine(document.Content);
        }

        /// <summary>
        /// By adding different Observers (interfaces) to a list, whenever a selected property's setter is used, all the observers can be notified and
        /// all of them can behave differently.
        /// 
        /// There are 2 additional styles:
        /// Push style: Any value can be added as a parameter to the NotifyObservers(value).
        /// Pull style: Every observer will have an inverse coupling with the DataSource which is flexible and they will get their values independently.
        /// </summary>
        static void Observer()
        {
            var dataSource = new DataSource();
            var sheetOne = new SpreadSheet();
            var sheetTwo = new SpreadSheet();
            var chart = new Chart();

            dataSource.AddObserver(sheetOne);
            dataSource.AddObserver(sheetTwo);
            dataSource.AddObserver(chart);

            dataSource.Value = 1;
        }
    }
}
