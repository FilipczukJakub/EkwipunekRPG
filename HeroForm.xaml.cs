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
    /// Logika interakcji dla klasy HeroForm.xaml
    /// </summary>
    public partial class HeroForm : Page
    {
        Hero hero = new Hero();
        public HeroForm(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            var allEquipment = hero.Inventory;
            var allWearable = allEquipment.FindAll(x => x is MagickEquipment || x is Equipment);
            var headList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.Head));
            var chestList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.Chest));
            var backList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.Back));
            var leftHandList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.LeftHand));
            var rightHandList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.RightHand));
            var feetList = allWearable.FindAll(x => ((Equipment)x).EquipableList.Contains(EquipmentType.Feet));
            headList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.Head }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            chestList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.Chest }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            backList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.Back }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            leftHandList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.LeftHand }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            rightHandList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.RightHand }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            feetList.Insert(0, new Equipment(new List<EquipmentType> { EquipmentType.Feet }, 0, "", Rarity.Uncommon, new Stats(0, 0, 0, 0, 0, 0), "", 0));
            HeadItem.ItemsSource = headList;
            ChestItem.ItemsSource = chestList;
            BackItem.ItemsSource = backList;
            LeftHandItem.ItemsSource = leftHandList;
            RightHandItem.ItemsSource = rightHandList;
            FeetItem.ItemsSource = feetList;
            if(hero.Head != null)
            {
                HeadItem.SelectedIndex = headList.IndexOf(hero.Head);
            }
            if (hero.Chest != null)
            {
                ChestItem.SelectedIndex = chestList.IndexOf(hero.Chest);
            }
            if (hero.Back != null)
            {
                BackItem.SelectedIndex = backList.IndexOf(hero.Back);
            }
            if (hero.LeftHand != null)
            {
                LeftHandItem.SelectedIndex = leftHandList.IndexOf(hero.LeftHand);
            }
            if (hero.RightHand != null)
            {
                RightHandItem.SelectedIndex = rightHandList.IndexOf(hero.RightHand);
            }
            if (hero.Feet != null)
            {
                FeetItem.SelectedIndex = feetList.IndexOf(hero.Feet);
            }
            PrintHeroStats();
            FillEquipmentList();
            
        }

        public void PrintHeroStats()
        {
            Name.Text = hero.Name;
            MaxHitPoints.Text = hero.HeroStats.HitPoints.ToString();
            CurrentHitPoints.Text = hero.HeroStats.ActuallHitPoints.ToString();
            Strength.Text = hero.HeroStats.Strength.ToString();
            Dexterity.Text = hero.HeroStats.Dexterity.ToString();
            Intelligence.Text = hero.HeroStats.Inteligence.ToString();
            ArmorClass.Text = hero.HeroStats.ArmorClass.ToString();
        }

        public void ItemChange(object sender, RoutedEventArgs e)
        {
            var item = (Equipment)((ComboBox)sender).SelectedItem;
            if(item != null) {
                if(item.Name.Equals(""))
                {
                    Unequip(item);
                }
                else
                {
                    Equip(item);
                }
            }
            PrintHeroStats();
        }

        public void Equip(Equipment item)
        {
            if (item is MagickEquipment)
            {
                item = (MagickEquipment)item;
            }
            if (item.EquipableList.Contains(EquipmentType.Head))
            {
                hero.Head = item;
            }
            else if (item.EquipableList.Contains(EquipmentType.Back))
            {
                hero.Back = item;
            }
            else if (item.EquipableList.Contains(EquipmentType.LeftHand))
            {
                hero.LeftHand = item;
            }
            else if (item.EquipableList.Contains(EquipmentType.RightHand))
            {
                hero.RightHand = item;
            }
            else if (item.EquipableList.Contains(EquipmentType.Chest))
            {
                hero.Chest = item;
            }
            else if (item.EquipableList.Contains(EquipmentType.Feet))
            {
                hero.Feet = item;
            }
        }

        public void Unequip(Equipment item)
        {
            if (item.EquipableList.Contains(EquipmentType.Head))
            {
                hero.Head = null;
            }
            else if (item.EquipableList.Contains(EquipmentType.Back))
            {
                hero.Back = null;
            }
            else if (item.EquipableList.Contains(EquipmentType.LeftHand))
            {
                hero.LeftHand = null;
            }
            else if (item.EquipableList.Contains(EquipmentType.RightHand))
            {
                hero.RightHand = null;
            }
            else if (item.EquipableList.Contains(EquipmentType.Chest))
            {
                hero.Chest = null;
            }
            else if (item.EquipableList.Contains(EquipmentType.Feet))
            {
                hero.Feet = null;
            }
        }

        public void AddEquipment(object sender,RoutedEventArgs e)
        {
            Globals.frame.Navigate(new EquipmentToAdd(hero));
        }

        public void UseEquipment(object sender,RoutedEventArgs e)
        {
            var item = Globals.ItemList.Find(x => x.Name.Equals(((Button)sender).Content));
            if (item is IUsable)
            {
                ItemEffect.Text = ((IUsable)item).UseItem();
                hero.IncreaseStats(item.ItemStats);
                if(item is Utilities)
                { 
                    hero.Inventory.Remove(item);
                    ClearEquipmentList();
                    FillEquipmentList();
                }
            }

        }

        public void ClearEquipmentList()
        {
            EquipmentList.Children.Clear();
        }

        public void FillEquipmentList()
        {
            foreach (var item in hero.Inventory)
            {
                var button = new Button();
                button.Content = item.Name;
                button.Click += new RoutedEventHandler(UseEquipment);
                EquipmentList.Children.Add(button);
            }
        }
    }
}
