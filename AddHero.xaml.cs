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
    /// Logika interakcji dla klasy AddHero.xaml
    /// </summary>
    public partial class AddHero : Page
    {
        public AddHero()
        {
            InitializeComponent();
        }

        public void SaveHero(object sender, RoutedEventArgs e)
        {
            try {
                
                List<Item> items = new List<Item>();
                var name = NameTextBox.Text;
                if (name.Equals("")) throw new FormException("Hero is missing his name");
                if (
                    ArmorClassBox.Text.Equals("") || 
                    DexterityBox.Text.Equals("") ||
                    InteligenceBox.Text.Equals("") ||
                    StrengthBox.Text.Equals("")) throw new FormException("Incorect hero statistics");
                var stats = new Stats(
                    10,
                    Int32.Parse(ArmorClassBox.Text),
                    Int32.Parse(DexterityBox.Text),
                    10,
                    Int32.Parse(InteligenceBox.Text),
                    Int32.Parse(StrengthBox.Text)
                    );

                var hero = new Hero(stats, items, name);
                hero.Name = name;
                Globals.HeroList.Add(hero);

                Globals.frame.Navigate(new HeroList());
            }catch(FormException ex)
            {
                ExceptionText.Text = ex.Message;
            }
        }
    }
}
