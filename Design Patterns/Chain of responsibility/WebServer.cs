using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_of_responsibility
{
    public class WebServer
    {
        private Handler _handler;

        public Handler Handler
        {
            get => _handler;
            private set
            { 
                _handler = value; 
            }
        }

        public WebServer(Handler handler) 
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}
