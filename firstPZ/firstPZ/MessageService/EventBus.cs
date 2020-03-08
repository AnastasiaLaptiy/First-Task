using firstPZ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.MessageService
{
    class EventBus
    {
        private Message message = new Message();
        public void CheckPlayerLuck(PlayerEventHandler eventHandler, PlayerManager playerManager, PlayerModel player)
        {
            if (playerManager.IndentifyPlayerLuck(player) > 10)
            {
                eventHandler.IdentifyPlayerLuck += message.PlayerTypicalMessage;
            }
            else
            {
                eventHandler.IdentifyPlayerLuck += message.PlayerStrangeMessage;
            }
        }
        public void CheckPlayerDeck(PlayerEventHandler eventHandler, DeckModel deck)
        {
            foreach (CardModel item in deck.Deck)
            {
                if (item.Health > 2 && item.Damage < 4)
                {
                    eventHandler.IdentifyPlayerDeck += message.PlayerGoodDeckMessage;
                }
                else
                {
                    eventHandler.IdentifyPlayerDeck += message.PlayerAwfulDeckMessage;
                }
            }
        }
        public void CheckWinner(PlayerEventHandler eventHandler, DeckModel deckA, DeckModel deckB)
        {
            /*foreach (CardModel itemA in deckA.Deck ) 
                foreach (CardModel itemB in deckB.Deck)
                {
                    if (itemA.Health < itemB.Damage)
                    {
                        eventHandler.IdentifyWinner += message.LoseMessage;
                    }
                    else if (itemB.Health < itemA.Damage)
                    {
                        eventHandler.IdentifyWinner += message.WinMessage;
                    }
                    else
                    {
                        eventHandler.IdentifyWinner += message.FunMessage;
                    }
                }*/

            for (int i = 0; i < deckA.Deck.Count; i++)
            {
                if (deckA.Deck[i].Health > deckB.Deck[i].Damage)
                {
                    eventHandler.IdentifyWinner += message.WinMessage;
                }
                else if(deckA.Deck[i].Health < deckB.Deck[i].Damage)
                {
                    eventHandler.IdentifyWinner += message.LoseMessage;
                }
                else
                {
                    eventHandler.IdentifyWinner += message.FunMessage;
                }
            }
        }
        public void ShowMessage(PlayerEventHandler eventHandler)
        {
            eventHandler.IdentifyPlayerLuckSub();
            eventHandler.IdentifyPlayerDeckSub();
            eventHandler.IdentifyWinnerSub();
        }
    }
}
