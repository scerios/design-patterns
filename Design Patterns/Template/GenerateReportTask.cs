using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Template
{
    public class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generating report.");
        }
    }
}
