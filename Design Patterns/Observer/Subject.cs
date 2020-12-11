using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Subject
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        // Push style
        public void NotifyObservers(int value)
        {
            foreach (var observer in Observers)
            {
                observer.Update(value);
            }
        }
    }
}
