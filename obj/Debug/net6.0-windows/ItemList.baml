   M S B A M L   `   `   `  ����E  AProjekt_PZ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Projekt_PZ
Projekt_PZ  5          Projekt_PZ.ItemList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Projekt_PZ     5        N� Title$  ItemList��5	      .��5      �� .+�5   
   �� -   5         ��Name$ 	textBlock��5      $	��300��6'    �� TextAlignment$ Center=�63   List of Items6Y   �� 5   
   -   5        $��GridItemList��5       $��2��6   $��1q�64   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����6H   �� 5       � ��$ 1,1,1,1q�68   6J   5       �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$
 auto��63    �� CellTemplate 5      �� 5      .R�5   "   �� 	 ��Name$	 
NameButton��6)   -   5        

 � Tag
 5   =   ��  �� Path$
 Name���6W   �� $
 Name���6u   �� 6�   5      5      �� 5      $��Description��6W   $
 auto��6l    �� DisplayMemberBinding 6%   �� $ Description�6l   �� 5      $��Rarity��6V   $
 auto��6f    6%   �� $ 
ItemRarity�6f   �� 5      $��Price��6Q   $
 auto��6`    6%   �� $ Price�6`   �� 5       $��Armor Class��6`   $
 auto��6u    6%   �� $ ItemStats.ArmorClass�6u   �� 5!      $��Max Hit Points��6f   $
 auto��6~    6%   �� $  ItemStats.ActuallHitPoints�6~   �� 5"      $��
Hit Points��6_   $
 auto��6s    6%   �� $ ItemStats.HitPoints�6s   �� 5#      $��Strength��6^   $
 auto��6p    6%   �� $ ItemStats.Strength�6p   �� 5$      $��	Dexterity��6_   $
 auto��6r    6%   �� $ ItemStats.Dexterity�6r   �� 5%      $��Intelligence��6a   $
 auto��6w    6%   �� $ ItemStats.Inteligence�6w   5&      5(      5)      5*      