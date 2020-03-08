using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ
{
    public delegate void IdentifyPlayer();
    class PlayerEventHandler
    {
        public event IdentifyPlayer IdentifyPlayerLuck = () => { };
        public event IdentifyPlayer IdentifyPlayerDeck = () => { };
        public event IdentifyPlayer IdentifyWinner = () => { };
        public void IdentifyPlayerLuckSub()
        {
            IdentifyPlayerLuck?.Invoke();
        }
        public void IdentifyPlayerDeckSub()
        {
            IdentifyPlayerDeck?.Invoke();
        }
        public void IdentifyWinnerSub()
        {
            IdentifyWinner?.Invoke();
        }
    }
}

