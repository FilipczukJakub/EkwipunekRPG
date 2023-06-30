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
    /// Logika interakcji dla klasy HeroList.xaml
    /// </summary>
    public partial class HeroList : Page
    {
        public HeroList()
        {
            InitializeComponent();
            var list = Globals.HeroList;
            listaBohaterow.ItemsSource = list;
        }

        public void Hero_Double_Click(object sender, RoutedEventArgs e)
        {
            var name = ((Button)sender).Tag.ToString();
            var hero = Globals.HeroList.Find(x => x.Name.Equals(name));
            Globals.frame.Navigate(new HeroForm(hero));
        }
    }
}
