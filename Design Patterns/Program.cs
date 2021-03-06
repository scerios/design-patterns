﻿using Design_Patterns.Chain_of_responsibility;
using Design_Patterns.Command;
using Design_Patterns.Command.editor;
using Design_Patterns.Command.fx;
using Design_Patterns.Iterator;
using Design_Patterns.Mediator;
using Design_Patterns.Memento;
using Design_Patterns.Observer;
using Design_Patterns.State;
using Design_Patterns.Strategy;
using Design_Patterns.Template;
using Design_Patterns.Visitor;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Allows restoring an object to a previous state.
        /// 
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
        /// Allows an object to behave differently depending on the state it is in.
        /// 
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
        /// Allows iterating over an object without having to expose the object’s internal structure (which may change in the future).
        /// 
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
        /// Allows passing different algorithms (behaviours) to an object. Allows defining a template (skeleton) for an operation.
        /// Specific steps will then be implemented in subclasses.
        /// 
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
        /// Allows decouple a sender from a receiver. The sender will talk to the receive through a command. Commands can be undone and persisted.
        /// 
        /// With Command its easy to build an independent framework that anyone can use. By creating a custom service which implements a base interface,
        /// any command can be run with the same method, depending on the service.
        /// </summary>
        static void Command()
        {
            // One command attached to an action.
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Command.fx.Button(command);
            button.Click();

            // Multiple commands attached to an action.
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();

            // Using the undo mechanism. Multiple commands are implementing the same interface(s) and using the same history.
            var history = new Command.editor.History();
            var document = new Command.editor.HtmlDocument();
            document.Content = "Hello";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);

            var undoCommant = new UndoCommand(history);
            undoCommant.Execute();

            Console.WriteLine(document.Content);
        }

        /// <summary>
        /// Allows an object notify other objects when its state changes.
        /// 
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

        /// <summary>
        /// Allows an object to encapsulate the communication between other objects.
        /// 
        /// Among the classes there's a meditor class which helps all the other classes communicate with each other without having any coupling.
        /// </summary>
        static void Mediator()
        {
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();
        }

        /// <summary>
        /// Allows building a chain of objects to process a request.
        /// 
        /// By using a chain, tight coupling can be get rid of. Whenever a new link is added to anywhere in the chain, the handling class doesn't need to be recompiled.
        /// This system is open to extensions and close to modifications. (Open-Close principle)
        /// </summary>
        static void ChainOfResponsibility()
        {
            // authentication -> log -> compress
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var server = new WebServer(authenticator);
            server.Handle(new HttpRequest("admin", "1234"));

        }

        /// <summary>
        /// Allows adding new operations to an object structure without modifying it.
        /// 
        /// Use only if object structure is stable but new operations are modified frequently.
        /// By adding an extensibility point, new type of operations can be added to an element without modifying the element itself. 
        /// </summary>
        static void Visitor()
        {
            var document = new Visitor.HtmlDocument();
            document.AddNode(new HeadingNode());
            document.AddNode(new AnchorNode());
            document.Execute(new HighlightOperation());
        }
    }
}
