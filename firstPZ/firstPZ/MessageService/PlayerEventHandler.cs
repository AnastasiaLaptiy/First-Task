using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    public delegate void IdentifyPlayerLuck();
    class PlayerEventHandler
    {
        public event IdentifyPlayerLuck FirstSubscriber = () => { };
        public event IdentifyPlayerLuck SecondSubscriber = () => { };
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

