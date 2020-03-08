using firstPZ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.Managers
{
    class CardManager
    {
        Random random = new Random();
        public CardModel createCard()
        {
            CardModel cardModel = new CardModel
            {
                Id = random.Next(5),
                Name = "cardName",
                Damage = random.Next(5),
                Health = random.Next(5),
                IsDeathrattle = true,
                IsLifesteal = false
            };
            return cardModel;
        }
    }
}
