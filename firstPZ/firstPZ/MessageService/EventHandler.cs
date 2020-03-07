using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    public delegate void FirstEvent();
    class EventHandler
    {
        public event FirstEvent FirstSubscriber;
        public event FirstEvent SecondSubscriber;

        public void FirstSub()
        {
            FirstSubscriber?.Invoke();
        }

        public void SecondSub()
        {
            SecondSubscriber?.Invoke();
        }

    }
}

