using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    interface IGameProcess
    {
        Dictionary<cardModel, playerModel> getCard(cardModel _cardModel, playerModel _playerModel);
        void isLuckyPlayer(Dictionary<cardModel, playerModel> pairs);

    }
}
