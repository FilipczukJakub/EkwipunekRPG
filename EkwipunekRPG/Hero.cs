using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class Hero
    {
        public string Name { get; set; }
        private delegate void EquipmentChangeDelegat(Stats stats);
        private Equipment head;
		public Equipment Head
		{
			get { return head; }
			set 
			{
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.Head))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (head == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            head = value;
                        }
                        else
                        {
                            changeStats(head.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            head = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.Head}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (head != null)
                    {
                        changeStats(head.ItemStats, reduceStats);
                        head = value;
                    }
                }
				
			}
		}
        private Equipment back;
        public Equipment Back
        {
            get { return back; }
            set
            {
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.Back))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (back == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            back = value;
                        }
                        else
                        {
                            changeStats(head.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            back = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.Back}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (back != null)
                    {
                        changeStats(back.ItemStats, reduceStats);
                        back = value;
                    }
                }

            }
        }
        private Equipment chest;
        public Equipment Chest
        {
            get { return chest; }
            set
            {
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.Chest))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (chest == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            chest = value;
                        }
                        else
                        {
                            changeStats(chest.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            chest = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.Chest}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (chest != null)
                    {
                        changeStats(chest.ItemStats, reduceStats);
                        chest = value;
                    }
                }

            }
        }
        private Equipment rightHand;
        public Equipment RightHand
        {
            get { return rightHand; }
            set
            {
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.RightHand))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (rightHand == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            rightHand = value;
                        }
                        else
                        {
                            changeStats(rightHand.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            rightHand = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.RightHand}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (rightHand != null)
                    {
                        changeStats(rightHand.ItemStats, reduceStats);
                        rightHand = value;
                    }
                }

            }
        }
        private Equipment leftHand;
        public Equipment LeftHand
        {
            get { return leftHand; }
            set
            {
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.LeftHand))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (leftHand == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            leftHand = value;
                        }
                        else
                        {
                            changeStats(leftHand.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            leftHand = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.LeftHand}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (leftHand != null)
                    {
                        changeStats(leftHand.ItemStats, reduceStats);
                        leftHand = value;
                    }
                }

            }
        }
        private Equipment feet;
        public Equipment Feet
        {
            get { return feet; }
            set
            {
                // jeślu value jest nulem to zdejmujemy element ekwipunku bez zakładania innego
                if (value != null)
                {
                    // sprawdzenie czy ekwipunek pasuje do slotu
                    if (value.EquipableList.Contains(EquipmentType.Feet))
                    {
                        // sprawdzenie czy coś już było na wyposażeniu
                        if (feet == null)
                        {
                            changeStats(value.ItemStats, incStats);
                            feet = value;
                        }
                        else
                        {
                            changeStats(feet.ItemStats, reduceStats);
                            changeStats(value.ItemStats, incStats);
                            feet = value;
                        }
                    }
                    else
                    {
                        throw new InvalidEquipmentTypeException($"{value.Name} can't be equiped on {EquipmentType.Feet}");
                    }
                }
                else
                {
                    // czy zdejmujemy ekwipunek
                    if (feet != null)
                    {
                        changeStats(feet.ItemStats, reduceStats);
                        feet = value;
                    }
                }

            }
        }
        public List<Item> Inventory { get; set; }
        public Stats HeroStats { get; set; }
        public Hero() 
        {
            Name = "JSON 0'Connor";
            HeroStats= new Stats(10,1,1,10,1,1);
            Inventory= new List<Item>();
        }
        public Hero(Stats stats,List<Item> items, string name)
        {
            this.HeroStats = stats;
            Inventory= items;
        }
		private void reduceStats(Stats stats)
		{
			HeroStats.Dexterity -= stats.Dexterity;
			HeroStats.Inteligence -= stats.Inteligence;
			HeroStats.Strength -= stats.Strength;
			HeroStats.ArmorClass -= stats.ArmorClass;
			HeroStats.HitPoints -= stats.HitPoints;
		}
		private void incStats(Stats stats)
		{
            HeroStats.Dexterity += stats.Dexterity;
            HeroStats.Inteligence += stats.Inteligence;
            HeroStats.Strength += stats.Strength;
            HeroStats.ArmorClass += stats.ArmorClass;
            HeroStats.HitPoints += stats.HitPoints;
        }
        private void changeStats(Stats stats, EquipmentChangeDelegat equipmentChangeDelegat)
        {
            equipmentChangeDelegat(stats);
        }
        public override string ToString()
        {
            var str = $"Hero {Name} "+this.HeroStats.ToString();
            str += " on Head has " + isMagickItem(Head);
            str += " on Back has " + isMagickItem(Back); ;
            str += " on Chest has " + isMagickItem(Chest);
            str += " on Right Hand has " + isMagickItem(RightHand);
            str += " on Left Hand has " + isMagickItem(LeftHand);
            str += " on Feet has " + isMagickItem(Feet);
            
            
            return str;
        }
        private string isMagickItem(Equipment eq)
        {
            var response = "";
            if (eq != null)
            {
                if (eq is MagickEquipment)
                {
                    response += "Magick equipment ";
                }
                else
                {
                    response += "equipment ";
                }
                return response + $"{eq.Name}";
            }
            else
            {
                return response + "nothing";
            }
        }

    }
}
