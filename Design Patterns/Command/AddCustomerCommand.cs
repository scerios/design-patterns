using System;
using System.Collections.Generic;
using System.Text;
using Design_Patterns.Command.fx;

namespace Design_Patterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        public CustomerService Service { get; set; }

        public AddCustomerCommand(CustomerService service)
        {
            Service = service;
        }

        public void Execute()
        {
            Service.AddCustomer();
        }
    }
}
