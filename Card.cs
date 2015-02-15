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
        public string DescriptionEffectCard;
        public string ArtisticDescription;
        public string CardType;
        public string Rarity;

        public struct EffectDescription //применимо к зданиям
        {
            public int changeAllHealth;
            public int changeAllDamage;
            public int changeTargetHealth;
            public int changeTargetDamage;
            public bool giveShield;
            public bool giveTwoAttacks;
            public bool giveStealth;
            public bool killStealth;
            public bool giveSilens;

            public string callCreature;
        }
        public struct CreatureDescription
        {
            public int damage;
            public int health;
            public EffectDescription effects;
        }
        public struct SpellDescription
        {
            public bool isAOE;
            public EffectDescription effects;
        }
        public struct AmmunitionDescr
        {
            public bool isWeapon;
            public int durability;
            public int defence;
        }

        public Card(int Price, string Name, string DescriptionEffectCard, string ArtisticDescription)
        {
            this.Price = Price;
            this.Name = Name;
            this.DescriptionEffectCard = DescriptionEffectCard;
            this.ArtisticDescription = ArtisticDescription;
        }


    }
}
