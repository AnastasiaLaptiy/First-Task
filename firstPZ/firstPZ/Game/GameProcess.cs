using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    class GameProcess : IGameProcess, IResultGameEvent
    {
        public event Display eDisplay = (x)=> { }; 

        public event ColoredDisplay eColoredDisplay =()=> { };

        public Dictionary<CardModel, PlayerModel> getCard(CardModel _cardModel, PlayerModel _playerModel)
        {           
            Dictionary<CardModel, PlayerModel> pairs = new Dictionary<CardModel, PlayerModel>();
            pairs.Add(_cardModel, _playerModel);
            return pairs;
        }

        public void isLuckyPlayer(Dictionary<CardModel, PlayerModel> pairs)
        {
             eDisplay = null;
            eColoredDisplay = null;
            foreach (KeyValuePair<CardModel, PlayerModel> pair in pairs)
            {
                if (pair.Key.luck < pair.Value.cardNum)
                {
                    eDisplay += Display;
                    eDisplay.Invoke("Lucky one");
                }

                else
                {
                    eColoredDisplay += ColoredDisplay;
                    eColoredDisplay.Invoke();
                    eDisplay += Display;
                    eDisplay.Invoke("Unlucky one");
                }
            }
        }

        public void Battle(Dictionary<CardModel, PlayerModel> players)
        {
            eDisplay = null;
            eColoredDisplay = null;
            foreach (KeyValuePair<CardModel, PlayerModel> pair in players)
            {
                if (pair.Key.luck * pair.Value.cardNum < 30)
                {
                    eDisplay += Display;
                    eDisplay.Invoke("Win");
                }
                else
                {
                    eDisplay += Display;
                    eColoredDisplay += ColoredAnotherDisplay;
                    eColoredDisplay.Invoke();
                    eDisplay.Invoke("Lose");
                    eColoredDisplay += ColoredDisplay;
                    eColoredDisplay.Invoke();
                    eDisplay.Invoke("Such a huge mistake");

                }

            }
        }
        public void Display(string s)
        {
            Console.WriteLine($"{s}");
        }

        public void ColoredDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void ColoredAnotherDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }


    }
}
