using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator
{
    public class BrowseHistory
    {
        public List<string> Urls { get; set; } = new List<string>();

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastUrl = Urls[lastIndex];

            Urls.RemoveAt(lastIndex);

            return lastUrl;
        }

        public IIterator<string> createIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history.Urls[_index];
            }

            public bool HasNext()
            {
                return _index < _history.Urls.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
