using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_of_responsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler Next
        {
            get => _next;
            private set 
            {
                _next = value; 
            }
        }

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (_next != null)
            {
                _next.Handle(request);
            }
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
