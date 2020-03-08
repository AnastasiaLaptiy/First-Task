using System;
using System.Collections.Generic;
using System.Text;

namespace firstPZ.Models
{
    class CardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public bool IsDeathrattle { get; set; }
        public bool IsLifesteal { get; set; }
    }
}
