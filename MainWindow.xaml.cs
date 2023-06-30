using EkwipunekRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Projekt_PZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            navigation.Navigate(new Navigation());
            FillItemList();
            FillHeroList();
        }

        public void FillHeroList()
        {
            var hero1 = new Hero();
            hero1.Inventory.Add(Globals.ItemList.ElementAt(0));
            hero1.Inventory.Add(Globals.ItemList.ElementAt(1));
            hero1.Inventory.Add(Globals.ItemList.ElementAt(3));
            Globals.HeroList.Add(hero1);
            var hero2 = new Hero();
            hero2.Inventory.Add(Globals.ItemList.ElementAt(2));
            hero2.Inventory.Add(Globals.ItemList.ElementAt(4));
            hero2.Name = "J'Query";
            Globals.HeroList.Add(hero2);
        }

        public void FillItemList()
        {
            Equipment equipment = new Equipment(
                    new List<EquipmentType> { EquipmentType.LeftHand, EquipmentType.RightHand },
                    2,
                    "Shield made out of dragon scales",
                    Rarity.Uncommon,
                    new Stats(0, 2, 0, 0, 0, 0),
                    "Dragon Shield",
                    500);
            Globals.ItemList.Add(equipment);
            MagickEquipment magickEquipment = new MagickEquipment(
                new List<EquipmentType> { EquipmentType.Head },
                3,
                "Horned helmet, which allows ramming enemies",
                Rarity.Epic,
                new Stats(5, 2, 0, 0, 0, 2),
                "Ram",
                600);
            magickEquipment.OnUse += new IUsable.Usable(delegate
            {
                return $"Deal additionall {magickEquipment.ItemBonus()} damage and " +
                $"move the enemy up to 3 tiles back";
            });
            Globals.ItemList.Add(magickEquipment);
            Utilities utilities = new Utilities(
                1,
                "Red in taste and color",
                Rarity.Common,
                new Stats(0,0,0,10,0,0),
                "Common Healing Potion",
                10
                );
            utilities.OnUse += new IUsable.Usable(delegate
            {
                return $"Hit points recovered!";
            });
            Globals.ItemList.Add(utilities);
            utilities = new Utilities(
                2,
                "Better than coffee",
                Rarity.Uncommon,
                new Stats(0,0,3,0,0,3),
                "Elixir of Agitation",
                40);
            utilities.OnUse += new IUsable.Usable(delegate
            {
                return "Dexterity and strenth boosted";
            });
            Globals.ItemList.Add(utilities);
            magickEquipment = new MagickEquipment(
                new List<EquipmentType> { EquipmentType.Feet },
                2,
                "Name speaks for itslef",
                Rarity.Rare,
                new Stats(0, 1, 2, 0, 0, 0),
                "Shoes of Walking on Water",
                100);
            magickEquipment.OnUse += new IUsable.Usable(delegate
            {
                return $"You can walk on water a distans equal to this many tiles: {magickEquipment.ItemBonus()}";
            });
            Globals.ItemList.Add(magickEquipment);
            equipment = new Equipment(
                new List<EquipmentType> { EquipmentType.Chest},
                3,
                "Surprisingly light weighted and durable",
                Rarity.Rare,
                new Stats(0,4,0,10,0,2),
                "Chain Mail of Moon's Glow",
                120);
            Globals.ItemList.Add(equipment);

        }

    }
}
