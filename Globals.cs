using EkwipunekRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Projekt_PZ
{
    public static class Globals
    {
        public static List<Hero> HeroList = new List<Hero>();
        public static List<Item> ItemList = new List<Item>();
        public static Frame frame = new Frame();
        public static void IncreaseStats(this Hero hero,Stats stats)
        {
            hero.HeroStats.Dexterity += stats.Dexterity;
            hero.HeroStats.Strength += stats.Strength;
            hero.HeroStats.Inteligence += stats.Inteligence;
            hero.HeroStats.ActuallHitPoints += stats.ActuallHitPoints;
            hero.HeroStats.HitPoints += stats.HitPoints;
        }
    }
}
