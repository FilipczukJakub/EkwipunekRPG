using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class Equipment : Item
    {
        public List<EquipmentType> EquipableList { get; set; }
        public Equipment() 
        {
            EquipableList = new List<EquipmentType>();
        }
        public Equipment(List<EquipmentType> type, int baseStrength, string description, Rarity itemRarity, Stats itemStats, string name, int price) : base(baseStrength, description, itemRarity, itemStats, name, price)
        {
            EquipableList = type;
        }
        public override string ToString()
        {
            var str = " can be equipted on";
            EquipableList.ForEach(x => str += " " + x+",");
            return base.ToString() +str ;
        }
    }
}
