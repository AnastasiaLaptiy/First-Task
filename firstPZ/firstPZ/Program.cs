using System;
using firstPZ.MessageService;

namespace firstPZ
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PlayerManager pm = new PlayerManager();
            EventHandler eventHandler = new EventHandler();                       
            PlayerModel testPM = pm.CreatePlayer(1, "player", 5);
            EventBus eventBus = new EventBus();
            eventBus.Performance(eventHandler, pm, testPM);
            
            Console.ReadKey();
        }
      
    }
}
