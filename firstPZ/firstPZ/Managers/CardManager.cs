using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class CardManager
    {
        Random random = new Random();
        public CardModel createCard(int id, string name, int luck)
        {
            CardModel cardModel = new CardModel
            {
                luck = random.Next(10) - luck,
                id = id,
                name = name
            };

            return cardModel;
        }
    }
}
