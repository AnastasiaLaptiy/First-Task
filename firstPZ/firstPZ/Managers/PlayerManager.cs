using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class PlayerManager
    {
        Random random = new Random();
        public PlayerModel createPlayer(int id, string name, int cardNum)
        {
            PlayerModel player = new PlayerModel
            {
                id = id,
                name = name,
                cardNum = random.Next(5) * cardNum
            };
            return player;
        }
    }
}
