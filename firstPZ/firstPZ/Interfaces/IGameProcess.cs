using System;
using System.Collections.Generic;
using System.Text;


namespace firstPZ
{
    interface IGameProcess
    {
        Dictionary<CardModel, PlayerModel> getCard(CardModel _cardModel, PlayerModel _playerModel);
        void isLuckyPlayer(Dictionary<CardModel, PlayerModel> pairs);
        void Battle(Dictionary<CardModel, PlayerModel> players);
        void Display(string s);
        void ColoredDisplay();
        void ColoredAnotherDisplay();

    }
}
