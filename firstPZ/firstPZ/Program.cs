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
            cardModel testCM = cm.createCard(1, "name", -155);
            playerManager pm = new playerManager();
            playerModel testPM = pm.createPlayer(1, "player", 1);
            process.isLuckyPlayer(process.getCard(testCM, testPM));
            process.Battle(process.getCard(testCM, testPM));
            Console.ReadKey();
        }
      
    }
}
