using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_of_responsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.Username == "admin" && request.Password == "1234");

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
