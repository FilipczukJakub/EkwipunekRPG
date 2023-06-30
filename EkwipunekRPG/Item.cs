using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public abstract class Item : IComparable<Item>
    {
        public int BaseStrength { get; set; }
        public string Description { get; set; }
        public Rarity ItemRarity { get; set; }
        public Stats ItemStats { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Item(int baseStrength, string description, Rarity itemRarity, Stats itemStats, string name, int price)
        {
            BaseStrength = baseStrength;
            Description = description;
            ItemRarity = itemRarity;
            ItemStats = itemStats;
            Name = name;
            Price = price;
        }
        public Item() { }
        public int ItemBonus()
        {
            return BaseStrength*((int)ItemRarity+1);
        }
        public override string ToString()
        {
            return $"Name {Name} Description {Description} BaseStrength {BaseStrength} Description {Description} ItemRarity {ItemRarity} ItemStats {ItemStats.ToString()} Price {Price}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        public int CompareTo(Item? other)
        {
            throw new NotImplementedException();
        }
    }
}
