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
    /// Logika interakcji dla klasy UtilityForm.xaml
    /// </summary>
    public partial class UtilityForm : Page
    {
        public UtilityForm(Utilities utilities)
        {
            InitializeComponent();
            Name.Text = utilities.Name;
            Rarity.Text = utilities.ItemRarity.ToString();
            Desctiption.Text = utilities.Description;
            Price.Text = utilities.Price.ToString();
            ArmorClass.Text = utilities.ItemStats.ArmorClass.ToString();
            AdditionallHitPoints.Text = utilities.ItemStats.ActuallHitPoints.ToString();
            RecoveryHitPoints.Text = utilities.ItemStats.HitPoints.ToString();
            Strength.Text = utilities.ItemStats.Strength.ToString();
            Dexterity.Text = utilities.ItemStats.Dexterity.ToString();
            Intelligence.Text = utilities.ItemStats.Inteligence.ToString();
            BaseStrength.Text = utilities.BaseStrength.ToString();
            OnUse.Text = utilities.UseItem();
        }
    }
}
