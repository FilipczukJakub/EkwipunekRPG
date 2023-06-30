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
    /// Logika interakcji dla klasy ItemForm.xaml
    /// </summary>
    public partial class ItemForm : Page
    {
        public ItemForm(Equipment equipment)
        {
            InitializeComponent();
            Name.Text = equipment.Name;
            Rarity.Text = equipment.ItemRarity.ToString();
            Desctiption.Text = equipment.Description;
            Price.Text = equipment.Price.ToString();
            ArmorClass.Text = equipment.ItemStats.ArmorClass.ToString();
            AdditionallHitPoints.Text = equipment.ItemStats.ActuallHitPoints.ToString();
            RecoveryHitPoints.Text = equipment.ItemStats.HitPoints.ToString();
            Strength.Text = equipment.ItemStats.Strength.ToString();
            Dexterity.Text = equipment.ItemStats.Dexterity.ToString();
            Intelligence.Text = equipment.ItemStats.Inteligence.ToString();
            BaseStrength.Text = equipment.BaseStrength.ToString();
        }
    }
}
