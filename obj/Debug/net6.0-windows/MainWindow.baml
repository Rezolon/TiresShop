   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TiresShopApplicationTiresShopApplication  5   	   %    TiresShopApplication.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:TiresShopApplication     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  ШИНЫ.RU��5	   	   $	��650��6   $
��1000��6&   
������  � AllowsTransparency$
 True��6L    � WindowStyle$
 None=�6f    � 
ResizeMode$ NoResize=�6y    � Icon$ tire.ico��6�   .��5
      � 
������ .+�5   
   ��  �� CornerRadius$ 8��6       GlobalPrimaryBackgroundColor#��[  6"   ._�5      � -   5         �Name$ GridNavigation��5       � ColumnDefinitions 5      �� 5      $
��auto �6'   66   �� 5      $��* �6'   63    � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $��* �6$   61   .+�5      �� $��1��6   	 �� Orientation$	 
Horizontal=�6-   $��Right=�6F   $	��Top=�6b   $��5q�6z   .+�5      �� -   5        
 ��Name$
 MinimizeButton��5        
ControlKey#��[ 65     MinimizeIcon#���  6Y   6�   �� 5      -   5        $
 FullViewButton��5      #��[ 65     MaximizeIcon#���  6Y   6�   �� 5      -   5        $
 CloseAppButton��5      #��[ 65     	CloseIcon#���  6Y   
 � Tag$ CloseButton��6    � Cursor$
 Hand��6�   5      �� 5!      -   5         ��Name$ 
MenuBorder��5!       " GlobalSecondaryBackgroundColor#��[ 6-   $ 8,0,0,8��6j   $��50��6�   $
��Left=�6�   $��2��5"      ._�5#      � $
��Left=�6    5$      �� 5%      $
��auto �6,   6<   �� 5&      $��* �6,   69   .+�5)      � $��0��6   $��30��6,   $��0 10 0 0q�68   $	��210��6J   .+�5*      �� $2��,pack://application:,,,/Images/tires_icon.png��6$   $
��Left=�6Z   $��13 0 0 0q�6u   6�   �� 5+      $��ШИНЫ.RU��6$   $��20(�66   $��0 -2 0 0q�6D   $��Center=�6V   $��Center=�6q   $
��Bold"�6�   6�   5,      �� 5.      $��1��6%   $��0 30 0 0q�62   $
��Left=�6D   $	��Top=�6_   .+�50      �� $	 
Horizontal=�6)   .+�51   "   �� -   5        $
 SearchTiresButton��51   )     
MenuButton#���  6D   $�� ��6�   .��52   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ album=�6>   $��25��6K   $��25��6V   $��Center=�6b   $��Center=�6}   6�   54   #   �� 55   "   $��КАТАЛОГ ШИН��6(     LightFontStyle#���  6>   56      �� 58      $	 
Horizontal=�6)   .+�59   "   �� -   5        $
 SearchWheelsButton��59   )   #���  6E   .��5:   &     $ Dharmachakra=�6>   $��25��6R   $��25��6]   $��Center=�6i   $��Center=�6�   5<   #   �� 5=   "   $!��КАТАЛОГ ДИСКОВ��6(   #���  6A   5>      �� 5@      $	 
Horizontal=�6)   .+�5A   "   �� -	   5        $
 
CartButton��5A   )   #���  6=   .��5B   &     $
 Cart=�6>   $��25��6J   $��25��6U   $��Center=�6a   $��Center=�6|   5C   #   �� 5D   "   $��КОРЗИНА��6(   #���  6:   5E      �� 5G      $	 
Horizontal=�6)   .+�5H   "   �� -
   5        $
 SettingsButton��5H   )   #���  6A   .��5I   &     $	 Cog=�6>   $��25��6I   $��25��6T   $��Center=�6`   $��Center=�6{   5J   #   �� 5K   "   $��НАСТРОЙКИ��6(   #���  6<   5L      �� 5N      -   5         ��Name$ AdminPanelStackPanel��5N   )   $	 
Horizontal=�6G   .+�5O   "   �� -   5        $
 AdminPanelButton��5O   )   #���  6C   .��5P   &     $ AccountCogOutline=�6>   $��25��6W   $��25��6b   $��Center=�6n   $��Center=�6�   5Q   #   �� 5R   "   $��АДМИН-ПАНЕЛЬ��6(   #���  6?   5S      5T      5V      5W      d� 5Z      $��1��6     ToggleButton#���  6/   $	��Top=�6V   $
��Left=�6n    � Triggers 5[      :� 5\       :� RoutedEvent$ ToggleButton.Unchecked��6'   .[�5]      �� .��5^   "   �� -   5         ��Name$ HideStackPanel��5^   -   .��5_   &   W�  �� 
TargetName$ 
MenuBorder��66    �� TargetProperty$ Width�6Y    g� 	BeginTime	 0:0:06{    W� From 1706�   	 W� To 506�    g� Duration$ 0:0:0.2D�6�   6�   5`   #   5a      5b      :� 5c      $ ToggleButton.Checked��6'   .[�5d      �� .��5e   "   �� -   5        $ ShowStackPanel��5e   -   .��5f   &   W� $ 
MenuBorder��66   $ Width�6Y   	 0:0:06{    506�    2006�   $ 0:0:0.2D�6�   6�   5g   #   5h      5i      5k       � 5n      -   5          �Name$ 	MainFrame��5n      $��1��5o      $��1��6(   $��20q�5p      5r      �� 5s      -   5         ��Name$ NameUser��5s      $��1��6*   $��Пользователь��6:   $��
0,6,110,10q�6Q   $��Right=�6e   $	��200��6�   $
��Bold"�6�   �� 5t      -   5        $ 	labelname��5t      $��1��6+   $��Каталог шин��6;   $
��Left=�6Q   $��77,8,0,0q�6l   $	��Top=�6~   $��20(�6�   $
��Bold"�6�   $��Arial Black)�6�   5w      5x      5y      5z      