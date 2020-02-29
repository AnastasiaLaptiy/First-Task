using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class Game //: IGame  //, ICardService
    {

       public delegate void _isValid(string s);
       public event _isValid eventForTest;
        public Dictionary<cardManager, playerManager> getCard(cardManager _cardModel, playerManager _playerModel)
        {
            Dictionary<cardManager, playerManager> pairs = new Dictionary<cardManager, playerManager>();
            pairs.Add(_cardModel, _playerModel);
            return pairs;
        }

        public void isValid(Dictionary<cardManager, playerManager> pair)
        {
            foreach(KeyValuePair<cardManager, playerManager> a in pair)
            {
                if (a.Key.luck == 0) eventForTest?.Invoke("win");
            }
        }

        
        
    }
}
