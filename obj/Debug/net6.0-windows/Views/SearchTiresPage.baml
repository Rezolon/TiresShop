   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TiresShopApplication.ViewsTiresShopApplication.Views  5      0    *TiresShopApplication.Views.SearchTiresPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TiresShopApplication.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  SearchTiresPage��5
       N� 
Background
 ���� .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��7* �6   6*   .+�5   
   �� $��2��6    "  GlobalSecondaryBackgroundColor#��[  5       �� CornerRadius$ 10��5      5      �� 5   
   -   5         ��Name$ FilterStackPanel��5       �� Orientation$ 
Horizontal=�6/   $��	10 10 0 0q�6H   $��0��6[   .+�5      �� -   5         ��Name$ AutoMarkCombobox��5       " MaterialDesignOutlinedComboBox#���  5      
���   �
�������$	��150��5      $��50��6#   $��Center=�6/   $��5q�5      $��Center=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Марка автомобиля��5         
Foreground
 �   ���5       �� 5!      .R�5"      �� $��15(�6$   ��5#      �� 5%   &   	 �� Path$
	 Name�6.   6<   5)      5*      5,      �� 5-      -   5        $ AutoModifCombobox��5-      #���  5.      
���   �
�������$	��150��51      $��50��6#   $��Center=�6/   $��5q�52      $��5 0 0 0q�6#   $' !Модель автомобиля��53      
 �   ���54      �� 55      .R�56      �� $��15(�6$   ��57      `� 58   "   
 �� StringFormat$
 {0} {1}��6/   .1�59   &   �� $	 	NameModel�6.   6A   �� 5:   &   $
	 Year�6.   6<   5<   #   5>      5?      5A      �� 5C      -   5        $ DriveUnitCombobox��5C      #���  5D      
���   �
�������$	��150��5G      $��50��6#   $��Center=�6/   $��5q�5H      $��5 0 0 0q�6#   $ Привод��5I      
 �   ���5J      �� 5K      .R�5L      �� $��15(�6$   ��62   �� *Name+5M      5O      �� 5Q      $ 
Horizontal=�6   $��5 0 0 0q�62   $��Center=�6C   .+�5R      �� -   5         ��Name$ PriceFromTextbox��5R       ! MaterialDesignOutlinedTextBox#��[ 5S      
�������
 �   �
���   �$	��Top=�5U      $��53��5V      $	��150��6&   $��0 0 0 0q�62    �� AcceptsReturn$
 True��5W       �� TextWrapping$ NoWrap=�5X      $ Цена от...��5Y       � Cursor$ IBeam��6F   �� 5Z      -   5        $ PriceToTextbox��5Z      #��[ 5[      
�������$	��Top=�5]      $��53��5^      $	��150��6&   $��5 0 0 0q�62   $
 True��5_      $ NoWrap=�5`      $ Цена до...��5a      $ IBeam��6F   �� 5c      -   5        $ TextboxSearch��5c      #��[ 5d      
�������$	��Top=�5f      $��53��5g      $	��250��6&   $��5 0 0 0q�62   $
 True��5h      $ NoWrap=�5i      $ Поиск...��5j      $ IBeam��6D   5k      �� 5m      -   5         ��Name$ ClearFilterFieldsButton��5m      $��50��66   $��50��6B   $��5 0 0 0q�6M   $��0q�6^   
�������.��5n      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CloseOctagon=�6*   $��30��6>   $��30��6I   6X   5o      �� 5q      -	   5        $ SearchButton��5q      $��50��6+   $��50��67   $��5 0 0 0q�6B   $��0q�6S   
�������$
 Hand��6�   .��5r        $ Magnify=�6*   $��30��69   $��30��6D   
�������6P   5s      5u      �� 5z   
   $��1��6   $��10q�6%   .��5{      � -
   5         �Name$ MainWrapPanel��5{      $��Center=�6/   5}      5      5�      