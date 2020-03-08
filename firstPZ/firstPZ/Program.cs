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
            EventBus eventBus = new EventBus();
            DeckManager deckManager = new DeckManager();
            PlayerEventHandler playerEventHandlerA = new PlayerEventHandler();
            PlayerEventHandler playerEventHandlerB = new PlayerEventHandler();
            PlayerEventHandler winner = new PlayerEventHandler();

            var playerA= player.CreatePlayerDeck(1, deckManager.CreateDeck());
            var playerB = player.CreatePlayerDeck(2, deckManager.CreateDeck());
            PlayerModel testPlayerA = player.CreatePlayer(1, "playerA", -4);
            PlayerModel testPlayerB = player.CreatePlayer(2, "playerB", 4);

            eventBus.CheckPlayerLuck(playerEventHandlerA, player, testPlayerA);
            eventBus.CheckPlayerDeck(playerEventHandlerA, playerA);
            eventBus.ShowMessage(playerEventHandlerA);
            
            eventBus.CheckPlayerLuck(playerEventHandlerB, player, testPlayerB);
            eventBus.CheckPlayerDeck(playerEventHandlerB, playerB);
            eventBus.ShowMessage(playerEventHandlerB);

            eventBus.CheckWinner(winner, playerA, playerB);
            eventBus.ShowMessage(winner);

            Console.ReadKey();
        }

    }
}
