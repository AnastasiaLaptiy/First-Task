using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    interface IActionGame
    {
        void getCard(cardModel cardModel, playerModel playerModel);
        void playerBattle(playerModel fistPlayer, playerModel secondPlayer, cardModel firstCard, cardModel secondCard);

    }
}
