using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public class SpreadSheet : IObserver
    {
        // Pull style
        public DataSource DataSource { get; set; }

        public SpreadSheet()
        {

        }

        // Pull style
        public SpreadSheet(DataSource dataSource)
        {
            DataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified");

            // Pull style
            Console.WriteLine($"Spreadsheet got notified with { DataSource.Value }");
        }

        public void Update(int value)
        {
            Console.WriteLine($"Spreadsheet got notified with { value }");
        }
    }
}
