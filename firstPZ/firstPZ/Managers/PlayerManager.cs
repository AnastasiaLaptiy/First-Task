using firstPZ.Models;
using System;
using System.Collections.Generic;

namespace firstPZ
{
    public class PlayerManager
    {
        private Random random = new Random();

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

        public int IndentifyPlayerLuck(PlayerModel player)
        {
            Console.WriteLine("Am I lucky player?");
            return player.CardNum;
        }

        public DeckModel CreatePlayerDeck(int id, List<CardModel> deck)
        {
            DeckModel deckModel = new DeckModel
            {
                Id = id,
                Deck = deck
            };
            return deckModel;
        }
    }
}
