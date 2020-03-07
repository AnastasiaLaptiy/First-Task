using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.MessageService
{

    class EventBus
    {
        public void Performance (EventHandler eventHandler, PlayerManager playerManager, PlayerModel player)
        {
            if (playerManager.isLuckyPlayer(player) > 0)
            {
                eventHandler.FirstSubscriber += playerManager.isLuckyPlayer;
                eventHandler.FirstSub();
            }
            else
            {
                eventHandler.SecondSubscriber += playerManager.isLuckyPlayer;
                eventHandler.SecondSub();
            }
        }


    }
}
