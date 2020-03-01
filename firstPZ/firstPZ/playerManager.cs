using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class playerManager
    {
        Random random = new Random();
        public playerModel createPlayer(int id, string name, int cardNum)
        {
            playerModel player = new playerModel();
            player.id = id;
            player.name = name;
            player.cardNum = random.Next(5) * cardNum;
            return player;
        }
    }
}
