using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class playerManager
    {
        public playerModel createPlayer(int id, string name, int cardNum)
        {
            playerModel player = new playerModel();
            player.id = id;
            player.name = name;
            player.cardNum = 1; /*rand*/
            return player;
        }
    }
}
