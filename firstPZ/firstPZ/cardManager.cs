using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class cardManager
    {
        public cardModel createCard(int id, string name, int luck)
        {
           
            cardModel cardModel = new cardModel();
            cardModel.id = id;
            cardModel.name = name;
            cardModel.luck = 1;  //rand
            return cardModel;
        }
/*        public List<cardModel> createDeck(cardModel cm)
        {
            List<cardModel> listCard = new List<cardModel>();
            for (int i = 0; i < 30; i++)
            {

            }
            return listCard;

        }*/
    }
}
