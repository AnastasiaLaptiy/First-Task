using System;
using System.Collections.Generic;
using System.Text;
 
namespace firstPZ
{
    public delegate int FirstEvent(PlayerModel pm);
    class EventHandler
    {
        public event FirstEvent FirstSubscriber;
        public event FirstEvent SecondSubscriber;

        public void FirstSub()
        {
            if(FirstSubscriber!= null)
            {
                Message message = new Message();
                message.TypicalMessage();
            }

        }
        public void SecondSub()
        {
            if (SecondSubscriber != null)
            {
                Message message = new Message();
                message.StrangeMessage();
            }

        }
    }
}
