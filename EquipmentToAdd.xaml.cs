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
    /// Logika interakcji dla klasy EquipmentToAdd.xaml
    /// </summary>
    public partial class EquipmentToAdd : Page
    {
        List<Item> list = new List<Item>();
        Hero hero;
        public EquipmentToAdd(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            list = Globals.ItemList;
            list = list.FindAll(x => !hero.Inventory.Contains(x));
            GridItemList.ItemsSource = list;
        }

        public void Item_Double_Click(object sender, RoutedEventArgs e)
        {
            var pole = textBlock;
            var itemName = ((Button)sender).Tag.ToString();
            var item = list.Find(x => x.Name.Equals(itemName));
            hero.Inventory.Add(item);
            Globals.frame.Navigate(new HeroForm(hero));
        }
    }
}
