   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TiresShopApplicationTiresShopApplication  5      (    "TiresShopApplication.CardWheelView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:TiresShopApplication     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��318��5	      $	��300��6   
������ $��10q�6@   +  %MaterialDesignThemes.Wpf.ShadowAssist    ShadowDepth$  Depth5=�6L   .��5
      � -   5         �Name$ CardMainGridWheel��5
      .+�5   
   �� 
������� �� CornerRadius$ 5��5      �� 5   
   .+�5      �� $��Stretch=�6   $	��164��67   $��5q�6D   .+�5      �� -   5         ��Name$ NameCardTextblock��5      $��20(�6Q   $
��Bold"�6_   $��WrapWithOverflow=�6q   ��67   �� *
TireName+6q   �� 5      -   5        $ CodeArticleCardTextblock��5      $��15(�6>   $��0 20 0 0q�6L   �� 5      $�Код:��6    �� 5      $
��Bold"�6.   �6   �� *Id+6.   5      �� 5      -   5        $ DiameterTireCardTextblock��5      $
��Wrap=�6?   �� 5      $�Тип-размер:��6   $��15(�6-    �� 5      $
��Bold"�64   �6   �� *
Diameter+64   5      �� 5       �� 5!      $�Привод: ��6   $��15(�6*   6:    �� 5"      $
��Bold"�65   �6   �� *	DriveUnit+6I   5#      �� 5$      �� 5%      $�Количество: ��6   $��15(�6.   6>    �� 5&      $
��Bold"�62   �6   �� *Amount+6F   5'      �� 5)      -   5        $ PriceCardTextblock��5)      �� 5*      $��25(�6J   $��
UltraBlack"�6X   �6   �� *Price+ �� StringFormat$ {0:#.##}��.�6q   5,       �� 5-      $�руб.��6   $��15(�6&   5.      5/      �� 52       �� Orientation$ 
Horizontal=�6   $	��145��62   .+�53      �� $��5 0 0 0q�6   $	��120��54      $��Stretch=�55      $��Stretch=�69   .+�58      �� .+�59      �� �� 5:      $�Тип: ��6"   $��13(�6/    �� 5;      -   5         ��Name$ WholesaleTextblock��5;   "   $
��Bold"�6a   �6>   �� *Type+ �� Mode$ OneWay=�6u   5<      �� 5=      �� 5>      $�
Цвет: ��6"   $��13(�60   6@    �� 5?      -   5        $ TunningTextblock��5?   "   $
��Bold"�6`   �6<   �� *Color+$ OneWay=�6t   5@      5B      �� 5E      $ 
Horizontal=�6!   $
��auto��6:   $��0 15 0 0q�6H   .+�5F      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Star=�62   
��� ���6W     5G      $
 Star=�62   
��� ���6W     5H      $
 Star=�62   
��� ���6W     5I      $
 Star=�62   
��� ���6W     5J      $
 Star=�62   
�������6R   5K      �� 5M      $ 
Horizontal=�6!   $��4 3 0 0q�6:   $��8��6K   .+�5N      A� $��8��6"   ��5O      
� 5P   "   .��5Q   &   � 	 � Color$	 
LightGreen��63   
 � Offset$	
 0.5Q�6F   6U   � 5R   &   $	 Green��63   $
 1Q�6A   6N   5S   #   5U      �� 5V      $��в наличии��6$   $��7(�65   $��5 0 0 0q�6B   
������� �� Padding$ 0q�6e   $��Center=�6q   6�   5W      �� 5Y      -   5         ��Name$ AddToCartButton��5Y      
��� � �$��0q�5[      $��0 15 0 0q�61   $��30��5\      $��30��6)   $��0q�64   $
��Left=�5]       � Cursor$
 Hand��5^   ;   .��5`        $
 Cart=�62   5a      5c      �� 5e      $��	0 0 0 -60q�6   $��Right=�5g      $��Bottom=�64   $	��198��5h      $	��180��6%   ��5f      �� *Image+5h   %   5j      5l      5m      5n      