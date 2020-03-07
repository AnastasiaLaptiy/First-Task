using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.MessageService
{
    class EventBus
    {
        Message message = new Message();
        public void Performance (EventHandler eventHandler, PlayerManager playerManager, PlayerModel player)
        {
            if (playerManager.isLuckyPlayer(player) > 0)
            {
                eventHandler.FirstSubscriber += message.TypicalMessage;
                eventHandler.FirstSub();
            }
            else
            {
                eventHandler.SecondSubscriber +=message.StrangeMessage;
                eventHandler.SecondSub();
            }
          
        }


    }
}
