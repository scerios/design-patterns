using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_of_responsibility
{
    public class HttpRequest
    {
        private string _username;

        public string Username
        {
            get => _username;
            private set 
            { 
                _username = value; 
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            private set 
            {
                _password = value; 
            }
        }

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }


    }
}
