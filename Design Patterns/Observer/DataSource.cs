using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class DataSource : Subject
    {
        private int _value;
        public int Value {
            get => _value;
            set
            {
                _value = value;
                NotifyObservers();

                // Push style communication
                NotifyObservers(value);
            }
        }
    }
}
