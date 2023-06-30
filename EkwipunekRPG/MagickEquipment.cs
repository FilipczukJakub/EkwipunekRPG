using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class MagickEquipment : Equipment, IUsable
    {
        public event IUsable.Usable OnUse;
        public MagickEquipment() { }
        public MagickEquipment(List<EquipmentType> type, int baseStrength, string description, Rarity itemRarity, Stats itemStats, string name, int price) : base(type, baseStrength, description, itemRarity, itemStats, name, price) { }
        public string UseItem()
        {
            return OnUse?.Invoke(this);
        }
        public override string ToString()
        {
            return "Magick Item "+base.ToString();
        }
    }
}
