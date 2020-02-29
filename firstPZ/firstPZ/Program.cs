using System;
using System.Collections.Generic;

namespace firstPZ
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
           cardManager cm = new cardManager();
            cm.createCard(1, "name",1);
            playerManager pm = new playerManager();
            pm.createPlayer(5, "player", 1);
            Game game = new Game();
            game.eventForTest += DisplayMessage;
            game.isValid( game.getCard(cm, pm));
           


        Console.ReadKey();
        }

        private static void DisplayMessage(string str)
        {
            Console.WriteLine($"{str}");
            
        }
    }
}
