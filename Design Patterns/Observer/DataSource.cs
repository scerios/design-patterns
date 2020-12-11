using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class DataSource : Subject
    {
        public int Value {
            get => Value;
            set
            {
                Value = value;
                NotifyObservers();

                // Push style communication
                NotifyObservers(value);
            }
        }
    }
}
