using System;

namespace firstPZ
{
    class PlayerManager
    {
        Random random = new Random();
        public PlayerModel CreatePlayer(int id, string name, int cardNum)
        {
            PlayerModel player = new PlayerModel
            {
                Id = id,
                Name = name,
                CardNum = random.Next(5) * cardNum
            };
            return player;
        }
        public int isLuckyPlayer(PlayerModel player)
        {
            Console.WriteLine("Am I lucky player?");
            return player.CardNum;
        }
    }
}
