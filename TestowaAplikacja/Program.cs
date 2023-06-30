using EkwipunekRPG;

namespace TestowaAplikacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stats staty = new Stats(1,2,3,4,5,6);
            Stats staty2 = new Stats(5,5,5,5,5,5);
            var eq = new MagickEquipment(new List<EquipmentType>() {EquipmentType.Head },3,"Opis", Rarity.Rare,staty,"Korona mocy",1000);
            var ut = new Utilities(3, "Opis", Rarity.Legendary, staty, "Granat dymny", 1000);
            var miecz = new MagickEquipment(new List<EquipmentType>() { EquipmentType.RightHand,EquipmentType.LeftHand},3,"Ognisty miecz w którym zaklęto smoczy ogień",Rarity.Legendary,staty2,"Ognisty miecz",1000);
            var peleryna = new Equipment(new List<EquipmentType>() { EquipmentType.Back},3,"Peleryna wędrowca. Dobrze chroni przed trudami podróży",Rarity.Common,staty2,"Peleryna wędrowca",1000);
            //Console.WriteLine(eq.UseItem(x => $"{x.Name} zwiększyła odporność o {x.ItemBonus()}"));
            miecz.OnUse += x => $"{x.Name} zapłoną ogniem o intensywności {x.ItemBonus()}";
            Console.WriteLine(miecz.UseItem());
            Hero hero = new Hero();        
            hero.Head = eq;
            hero.LeftHand = miecz;
            hero.Back= peleryna;
            //Console.WriteLine(hero.HeroStats.ToString());
            //hero.LeftHand = null;
            Console.WriteLine(hero.ToString());
        }
    }
}