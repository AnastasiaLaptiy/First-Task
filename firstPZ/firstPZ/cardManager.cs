using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class cardManager
    {
        Random random = new Random();
        public cardModel createCard(int id, string name, int luck)
        {
            cardModel cardModel = new cardModel();
            
            cardModel.id = id;
            cardModel.name = name;
            cardModel.luck = random.Next(5) - luck;
            return cardModel;
        }
    }
}
