using System.Collections.Generic;

namespace firstPZ.Models
{
    public class DeckModel
    {
        public int Id { get; set; }

        public List<CardModel> Deck { get; set; }
    }
}
