namespace firstPZ
{
    public delegate void IdentifyPlayer();

    public class PlayerEventHandler
    {
        public event IdentifyPlayer IdentifyPlayerLuck = () => { };

        public event IdentifyPlayer IdentifyPlayerDeck = () => { };

        public event IdentifyPlayer IdentifyWinner = () => { };

        public void IdentifyPlayerLuckSub()
        {
            IdentifyPlayerLuck.Invoke();
        }

        public void IdentifyPlayerDeckSub()
        {
            IdentifyPlayerDeck.Invoke();
        }

        public void IdentifyWinnerSub()
        {
            IdentifyWinner.Invoke();
        }
    }
}

