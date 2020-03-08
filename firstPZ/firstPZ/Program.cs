using System;
using firstPZ.Managers;
using firstPZ.MessageService;

namespace firstPZ
{
    class Program
    {

        static void Main(string[] args)
        {
            PlayerManager player = new PlayerManager();
            PlayerEventHandler playerEventHandler = new PlayerEventHandler();
            PlayerModel testPlayer = player.CreatePlayer(1, "player", -4);
            EventBus eventBus = new EventBus();
            eventBus.CheckPlayerLuck(playerEventHandler, player, testPlayer);

            DeckManager deckManager = new DeckManager();
            var playerA= player.CreatePlayerDeck(1, deckManager.CreateDeck());
           // var playerB = player.CreatePlayerDeck(2, deckManager.CreateDeck());

            eventBus.CheckPlayerDeck(playerEventHandler, playerA);
            eventBus.ShowMessage(playerEventHandler);

            Console.ReadKey();
        }

    }
}
