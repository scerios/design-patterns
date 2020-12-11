using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class Chart : IObserver
    {
        // Pull style
        public DataSource DataSource { get; set; }

        public Chart()
        {

        }

        // Pull style
        public Chart(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got notified");

            // Pull style
            Console.WriteLine($"Chart got notified with { DataSource.Value }");
        }

        public void Update(int value)
        {
            Console.WriteLine($"Chart got notified with { value }");
        }
    }
}
