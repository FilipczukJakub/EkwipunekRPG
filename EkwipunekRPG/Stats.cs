using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class Stats
    {
        public int ActuallHitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Dexterity { get; set; }
        public int HitPoints { get; set; }
        public int Inteligence { get; set; }
        public int Strength { get; set; }
        public Stats() { }
        public Stats(int actuallHitPoints, int armorClass, int dexterity, int hitPoints, int inteligence, int strength)
        {
            ActuallHitPoints = actuallHitPoints;
            ArmorClass = armorClass;
            Dexterity = dexterity;
            HitPoints = hitPoints;
            Inteligence = inteligence;
            Strength = strength;
        }
        public override string ToString()
        {
            return $"ActuallHitPoints {ActuallHitPoints} ArmorClass {ArmorClass} Dexterity {Dexterity} HitPoints {HitPoints} Inteligence {Inteligence} Strength {Strength}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }
        
    }
}
