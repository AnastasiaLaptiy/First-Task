using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    interface IGame
    {
        Dictionary<cardManager, playerManager> getCard(cardManager _cardModel, playerManager _playerModel);
    //    void playerBattle(playerModel fistPlayer, playerModel secondPlayer, cardModel firstCard, cardModel secondCard);

    }
}
