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
    /// Logika interakcji dla klasy ItemList.xaml
    /// </summary>
    public partial class ItemList : Page
    {
        List<Item> list = new List<Item>();
        public ItemList()
        {
            InitializeComponent();
            list = Globals.ItemList;
            GridItemList.ItemsSource = list;
        }

        public void Item_Double_Click(object sender, RoutedEventArgs e)
        {
            var pole = textBlock;
            var itemName = ((Button)sender).Tag.ToString();
            var item = list.Find(x => x.Name.Equals(itemName));
            if (item is MagickEquipment)
            {
                Globals.frame.Navigate(new MagicItemForm((MagickEquipment)item));
            }else if(item is Utilities)
            {
                Globals.frame.Navigate(new UtilityForm((Utilities)item));
            }
            else if(item is Equipment)
            {
                Globals.frame.Navigate(new ItemForm((Equipment)item));
            }
        }
    }
}
