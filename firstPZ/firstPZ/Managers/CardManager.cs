using firstPZ.Models;
using System;
namespace firstPZ.Managers
{
    public class CardManager
    {
        private Random random = new Random();

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
