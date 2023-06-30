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
    /// Logika interakcji dla klasy Navigation.xaml
    /// </summary>
    /// 
    
    public partial class Navigation : Page
    {

        
        public Navigation()
        {
            
            InitializeComponent();
            Globals.frame = mainFrame;
            Globals.frame.Navigate(new HeroList());
        }
        
        public void ListaBohaterow(object sender, RoutedEventArgs e)
        {
            Globals.frame.Navigate(new HeroList());
        }

        public void DodajPrzedmiot(object sender, RoutedEventArgs e)
        {
            Globals.frame.Navigate(new CreateItem());
        }

        public void ListaPrzedmiotow(object sender, RoutedEventArgs e)
        {
            Globals.frame.Navigate(new ItemList());
        }
        
        public void DodajBohatera(object sender, RoutedEventArgs e)
        {
            Globals.frame.Navigate(new AddHero());
        }
    }
}
