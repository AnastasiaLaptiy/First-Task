using firstPZ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.MessageService
{
    class EventBus
    {
        Message message = new Message();
        public void CheckPlayerLuck (PlayerEventHandler eventHandler, PlayerManager playerManager, PlayerModel player)
        {
            if (playerManager.IndentifyPlayerLuck(player) > 10)
            {
                eventHandler.FirstSubscriber += message.PlayerTypicalMessage;
            }
            else
            {
                eventHandler.SecondSubscriber +=message.PlayerStrangeMessage;
            }
          
        }
        public void CheckPlayerDeck(PlayerEventHandler eventHandler, DeckModel deck)
        {
            foreach(CardModel item in deck.Deck)
            {
                if(item.Health>2 && item.Damage < 4)
                {
                    eventHandler.FirstSubscriber += message.PlayerGoodDeckMessage;
                }
                else
                {
                    eventHandler.SecondSubscriber += message.PlayerAwfulDeckMessage;
                }                   
            }
        }
        public void ShowMessage(PlayerEventHandler eventHandler)
        {
            eventHandler.FirstSub();
            eventHandler.SecondSub();
        }

    }
}
