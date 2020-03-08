namespace firstPZ.Models
{
    public class CardModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public bool IsDeathrattle { get; set; }

        public bool IsLifesteal { get; set; }
    }
}
