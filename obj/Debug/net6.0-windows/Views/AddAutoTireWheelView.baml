   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TiresShopApplicationTiresShopApplication  5      /    )TiresShopApplication.AddAutoTireWheelView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:TiresShopApplication     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      � $	��430��6      � ColumnDefinitions  5
   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� -   5         ��Name$ AutoModifCombobox��5      $��5q�66   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Автомобиль��6A    "  MaterialDesignOutlinedComboBox#���   6m   $	��195��6�   ��5      �� 5      .R�5      �� ��5   "   `� 5   &    �� StringFormat$ {0} {1} ({2})��63   .1�5   *   ��  �� Path$ Model�62   6A   �� 5   *   $
 Year�62   6@   �� 5   *   $ Diameter�62   6D   5   '   5      5      5      �� 5       -   5        $ DriveUnitCombobox��5       $��5q�66   $ Привод��6A   #���   6i   ��5!      �� 5"      .R�5#      �� ��6(   �� *Name+6@   5$      5&      �� 5'      -   5         ��Name$ PriceTextbox��5'      $��5q�60    ! MaterialDesignOutlinedTextBox#��[ 5(      $	��Top=�5)       �� AcceptsReturn$
 True��5*       �� TextWrapping$
 Wrap=�5+      "	 �� VerticalScrollBarVisibility$
	 Auto=�5,      $ Стоимость��5-      �� 5.      -   5        $ AmountTextbox��5.      $��5q�61   #��[ 5/      $
 True��50      $
 Wrap=�51      $
	 Auto=�52      $ Количество��54      $	��193��6A   $��47��6M   
 � Cursor$
 IBeam��6Y   �� 58      -   5        $ SeasonTextbox��58      $��5q�62   #��[ 59      $
 True��5:      $
 Wrap=�5;      $
	 Auto=�5<      $ 
Сезон��5=      $	��193��5>      $��47��6"   �� 5?      -   5        $ LoadsTextbox��5?      #��[ 5@      $
 True��5A      $
 Wrap=�5B      $
	 Auto=�5C      $% Мак.скорость в км��5D      $	��193��6H   $��48��6T   �� 5F      -   5         ��Name$ 
SaveButton��5F      $��20q�6-   $��Сохранить��69   6h   5G      � 5I      -   5         �Name$ 	GridPhoto��5I      $	��Top=�6Z   $	��250��6r   .+�5J      �� 
�������$	��200��6(   $	��200��65   �� 5K      
�������$	��190��6)   $	��190��66   �� 5L      
�������$	��210��6)   $	��170��66   �� 5M      
�������$	��170��6)   $	��210��66   �� 5N       $  MaterialDesignHeadline3TextBlock#��[ 6   
�������$U��OНажмите здесь, чтобы загрузить изображение��5O      $��23(�6N   $��Center=�6\   $��Center=�5P       �� TextAlignment$ Center=�67   $
��Wrap=�6N   $	��149��6b   $
��None=�5Q      5R      �� 5S      -	   5         ��Name$ PlaceForPhoto��5S      $��40,10,40,10q�6/   $	��190��6E   $	��190��6U   �� 5T      -
   5        $ 	LoadsText��5T      $��5,222,12,-60q�6-   #��[ 5U      $
 True��5V      $
 Wrap=�5W      $
	 Auto=�5X      $y�Hidden=�5Y      $ Тип��5Z      $	��193��6:   $��48��6F   �� 5[      -   5        $
 Text��5[      $��5,284,12,-122q�6(   #��[ 5\      $
 True��5]      $
 Wrap=�5^      $
	 Auto=�5_      $y�Hidden=�5`      $ Цвет��5a      $	��193��6;   $��48��6G   5c      � 5d      5f      5g      5j      5k      