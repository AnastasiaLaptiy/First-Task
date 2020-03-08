using firstPZ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.Managers
{
    class DeckManager
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