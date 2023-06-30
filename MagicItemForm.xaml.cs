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
    /// Logika interakcji dla klasy MagicItemForm.xaml
    /// </summary>
    public partial class MagicItemForm : Page
    {
        public MagicItemForm(MagickEquipment magickEquipment)
        {
            InitializeComponent();
            Name.Text = magickEquipment.Name;
            Rarity.Text = magickEquipment.ItemRarity.ToString();
            Desctiption.Text = magickEquipment.Description;
            OnUse.Text = magickEquipment.UseItem();
            Price.Text = magickEquipment.Price.ToString();
            ArmorClass.Text = magickEquipment.ItemStats.ArmorClass.ToString();
            AdditionallHitPoints.Text = magickEquipment.ItemStats.ActuallHitPoints.ToString();
            RecoveryHitPoints.Text = magickEquipment.ItemStats.HitPoints.ToString();
            Strength.Text = magickEquipment.ItemStats.Strength.ToString();
            Dexterity.Text = magickEquipment.ItemStats.Dexterity.ToString();
            Intelligence.Text = magickEquipment.ItemStats.Inteligence.ToString();
            BaseStrength.Text = magickEquipment.BaseStrength.ToString();
        }
    }
}
