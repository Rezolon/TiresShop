   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TiresShopApplication.ViewsTiresShopApplication.Views  5      )    #TiresShopApplication.Views.CartPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TiresShopApplication.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  CartPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��7* �6   6*   .+�5   
   �� $��2��6    "  GlobalSecondaryBackgroundColor#��[  5       �� CornerRadius$ 10��5      5      �� 5   
   -   5         ��Name$ FilterStackPanel��5       �� Orientation$ 
Horizontal=�6/   $��	10 10 0 0q�6H   $��0��6[   .+�5      �� -   5         ��Name$ 	BuyButton��5      $��50��6(   $��50��64   $��5 0 0 0q�6?   $��0q�6P    � Cursor$
 Hand��6\   
�������.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Cart=�6*   $��30��66   $��30��6A   
�������6M   5      �� 5      -   5        $ ClearButton��5      $��50��6*   $��50��66   $��5 0 0 0q�6A   $��0q�6R   $
 Hand��6^   
�������.��5        $ Trash=�6*   $��30��67   $��30��6B   
�������6N   5      '  !MaterialDesignThemes.Wpf.PopupBox  5!         	StaysOpen$
 True��6&   	   PopupContent.	 5"      � $	��250��6   .+�5#      �� .+�5$      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5%      �� $
��Id: ��6(   $��Center=�64   $��Center=�6O   $��17(�6l   6|   �� 5&      -   5        
 ��Name$
 IdForDeleteTextbox��5&   &   $��50��6B   $��Center=�6M   $��Center=�6q   6�   �� 5'      -   5        $ DeleteButton��5'   %   $��Удалить по id��6;   
��� ���$��5 0 0 0q�6g     MaterialDesignFlatButton#���  6x   6�   5(      5)      5*      5+      5/      �� 51   
   $��25(�6   $��Center=�6"   $��Right=�6=   $��0 0 20 0q�6Y   �� 52      $�Итого:��6   6#    �� 53      -   5         ��Name$ PriceTextblock��53      $�[]��6*   $
��Bold"�64   6H    �� 54      $�руб.��6   6    55      � 58   
   $��1��6   $��10q�6   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGridView��59         CanUserAddRows$
 True��61      SelectionMode$ Single=�6G      SelectionUnit$ FullRow=�6^      AutoGenerateColumns$ False��6v   $��16(�6�      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Код��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Id+6O     5<      $ Наименование��6)    6?   �� *
TireName+6^     5=      $ Диаметр��6)    6:   �� *
Diameter+6Y     5>      $ Привод��6)    69   �� *	DriveUnit+6Y     5@      $. (Стоимость за комплект��6)    6H   �� *Price+ �� StringFormat$ {0:#.## руб}��6�   4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Изображение��6-      CellTemplate 5B      �� 5C      .R�5D   "   �� $��50��6A   $��50��6P   ��6(   �� *Image+6]   5E      5G      5J      5L      5O      5P      