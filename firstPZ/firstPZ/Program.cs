using System;
using System.Collections.Generic;

namespace firstPZ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GameProcess process = new GameProcess();
            cardManager cm = new cardManager();
            cardModel test = cm.createCard(1, "name", 1);
            playerManager pm = new playerManager();
            playerModel player = pm.createPlayer(1, "player", 1);
            process.isLuckyPlayer(process.getCard(test, player));
            process.Battle(process.getCard(test, player));
            Console.ReadKey();

        }
      
    }
}
