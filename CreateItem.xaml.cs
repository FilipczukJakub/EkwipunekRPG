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
    /// Logika interakcji dla klasy CreateItem.xaml
    /// </summary>
    public partial class CreateItem : Page
    {
        public CreateItem()
        {
            InitializeComponent();
        }

        public void RadioChecked(object sender, RoutedEventArgs e)
        {
            var name = ((RadioButton)sender).Name;
            if(name.Equals("UtilityRadio"))
            {
                OnUseTextBox.IsEnabled = true;
                WearAt.IsEnabled = false;
                HeadCheck.IsChecked = false;
                BackCheck.IsChecked = false;
                ChestCheck.IsChecked = false;
                LeftHandCheck.IsChecked = false;
                RightHandCheck.IsChecked = false;
                FeetCheck.IsChecked = false;
            }else if(name.Equals("EquipmentRadio"))
            {
                OnUseTextBox.IsEnabled = false;
                OnUseTextBox.Text = "";
                WearAt.IsEnabled = true;
            }
            else
            {
                OnUseTextBox.IsEnabled = true;
                WearAt.IsEnabled = true;
            }
        }

        public void SaveItem(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RarityCombo.Equals(null)) throw new FormException("Rarity not selected");
                if (BaseStrengthBox.Text.Equals("")) throw new FormException("Base strength has no value");
                if (DexterityBox.Text.Equals("")) throw new FormException("Dexterity has no value");
                if (StrengthBox.Text.Equals("")) throw new FormException("Strength has no value");
                if (InteligenceBox.Text.Equals("")) throw new FormException("Intelligence has no value");
                if (ArmorClassBox.Text.Equals("")) throw new FormException("Armor Class has no value");
                if (NameTextBox.Text.Equals("")) throw new FormException("Name has no value");
                if (DescriptionTextBox.Text.Equals("")) throw new FormException("Description has no value");
                Item item;
                string onUse;
                List<CheckBox> checkBoxes= new List<CheckBox>() {HeadCheck,ChestCheck,BackCheck,LeftHandCheck,RightHandCheck,FeetCheck };
                List<EquipmentType> equipmentTypes = new List<EquipmentType>();
                foreach(CheckBox checkBox in checkBoxes)
                {
                    if((bool)checkBox.IsChecked)
                    {
                        equipmentTypes.Add((EquipmentType)Int32.Parse((string)checkBox.Tag));
                    }
                }
                if (equipmentTypes.Count == 0) throw new FormException("Select at lest one equipment type");
                if ((bool)UtilityRadio.IsChecked)
                {
                    item = new Utilities();
                }
                else if ((bool)EquipmentRadio.IsChecked)
                {
                    item = new Equipment();
                }
                else if ((bool)MagickEquipmentRadio.IsChecked)
                {
                    item = new MagickEquipment();
                }
                else
                {
                    throw new FormException("Item type is not selected");
                }
                item.ItemStats = new Stats(
                    Int32.Parse(AdditionallHitPointsBox.Text),
                    Int32.Parse(ArmorClassBox.Text),
                    Int32.Parse(DexterityBox.Text),
                    Int32.Parse(RecoveryHitPointsBox.Text),
                    Int32.Parse(InteligenceBox.Text),
                    Int32.Parse(StrengthBox.Text)
                    );
                item.BaseStrength = Int32.Parse(BaseStrengthBox.Text);
                item.ItemRarity = (Rarity)Int32.Parse((string)((ComboBoxItem)RarityCombo.SelectedItem).Tag);
                item.Description = DescriptionTextBox.Text;
                item.Name = NameTextBox.Text;
                item.Price = Int32.Parse(PriceBox.Text);
                if(item is Equipment)
                {
                    ((Equipment)item).EquipableList = equipmentTypes;
                }
                if (item is MagickEquipment)
                {
                    if (!OnUseTextBox.Text.Contains("**")) throw new FormException("The '**' is required for magick equipments");
                    onUse = OnUseTextBox.Text.Split("**")[0] + item.ItemBonus() + OnUseTextBox.Text.Split("**")[1];
                    ((IUsable)item).OnUse += new IUsable.Usable(delegate
                    {
                        return onUse;
                    });
                }else if(item is Utilities)
                {
                    onUse = OnUseTextBox.Text;
                    ((IUsable)item).OnUse += new IUsable.Usable(delegate
                    {
                        return onUse;
                    });
                }
                Globals.ItemList.Add(item);
                Globals.frame.Navigate(new ItemList());
            }
            catch(FormException ex)
            {
                ExceptionText.Text = ex.Message;
            }
        }
    }
}
