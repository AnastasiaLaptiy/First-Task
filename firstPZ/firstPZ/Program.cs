using System;
using System.Collections.Generic;

namespace firstPZ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GameProcess process = new GameProcess();
            CardManager cm = new CardManager();
            CardModel testCM = cm.createCard(1, "name", -155);
            PlayerManager pm = new PlayerManager();
            PlayerModel testPM = pm.createPlayer(1, "player", 1);
            process.isLuckyPlayer(process.getCard(testCM, testPM));
            process.Battle(process.getCard(testCM, testPM));
            Console.ReadKey();
        }
      
    }
}
