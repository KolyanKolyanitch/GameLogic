using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Card
    {
        public string Name;
        public int Price;
        public int Damage;
        public int Health;
        public string DescriptionEffectCard;
        public string ArtisticDescription;

        public Card(int Price, int Damage, int Health, string Name, string DescriptionEffectCard, string ArtisticDescription)
        {
            this.Price = Price;
            this.Damage = Damage;
            this.Health = Health;
            this.Name = Name;
            this.DescriptionEffectCard = DescriptionEffectCard;
            this.ArtisticDescription = ArtisticDescription;
        }
    }
}
