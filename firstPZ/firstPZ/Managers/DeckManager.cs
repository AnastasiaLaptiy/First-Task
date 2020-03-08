using firstPZ.Models;
using System.Collections.Generic;

namespace firstPZ.Managers
{
    public class DeckManager
    {
        public List<CardModel> CreateDeck()
        {
            List<CardModel> deck = new List<CardModel>();
            for (int i = 0; i < 3; i++)
            {
                CardManager createCard = new CardManager();
                deck.Add(createCard.createCard());
            }
            return deck;
        }
    }
}