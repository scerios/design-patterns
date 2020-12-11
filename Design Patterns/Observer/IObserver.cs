using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer
{
    public interface IObserver
    {
        void Update();

        // Push style
        void Update(int value);
    }
}
