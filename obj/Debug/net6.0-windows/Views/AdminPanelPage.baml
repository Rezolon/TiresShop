   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TiresShopApplication.ViewsTiresShopApplication.Views  5      /    )TiresShopApplication.Views.AdminPanelPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TiresShopApplication.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  AdminPanelPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��7* �6   6*   .+�5   
   �� $��2��6    "  GlobalSecondaryBackgroundColor#��[  5       �� CornerRadius$ 10��5      5      �� 5   
   -   5         ��Name$ FilterStackPanel��5       �� Orientation$ 
Horizontal=�6/   $��	10 10 0 0q�6H   $��0��6[   .+�5      �� -   5         ��Name$ WorkTableCombobox��5       " MaterialDesignOutlinedComboBox#���  5      
���   �
�������$	��150��5      $��50��6#   $��Center=�6/   $��5q�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Справочники��5          
Foreground
 �   �$��16(�6q   5!      �� 5#      -   5         ��Name$ 	AddButton��5#      $��50��6(   $��50��64   $��5 0 0 0q�6?   $��0q�6P   	 � Cursor$
	 Hand��6\   
�������.��5$      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 PlusBox=�6*   $��30��69   $��30��6D   
�������6P   5%      ]� 53      .+�55      �� -   5        $ Buttom_Amount��55      $	��450��60   $��50��6<   $
��Left=�6H   $-��'Изменение количества��6^   $��	10 0 10 0q�6~   $
	 Hand��6�   
�������$y�Hidden=�6�   $��16(�6�   �� 56      -   5        $ Buttom_User��56      $	��240��6.   $��50��6:   $
��Left=�6F   $<��6Добавить нового пользователя��6^   $��5 0 0 0q�6�   $
	 Hand��6�   
�������$y�Hidden=�6�   $��16(�6�   �� 57      -   5        $ Buttom_Status��57      $	��198��60   $��50��6<   $
��Left=�6H   $'��!Изменение статуса��6^   $
	 Hand��6z   $��5 0 0 0q�6�   
�������$y�Hidden=�6�   $��16(�6�   �� 58      -   5        $ ExportSales��58      $��Экспорт��6.   $��50��6A   $��Right=�6g   $
	 Hand��6~   
�������$y�Hidden=�6�   6�   �� 59      -   5        $ Username��59      #���  5:      
���   �
�������$	��230��5=      $��50��6#   $��Center=�6/   $��5q�5>      $y�Hidden=�5?      $ Сотрудники��5@      
 �   �$��16(�6p   ��5A      �� 5B      .R�5C      �� $��15(�6(   ��5D   "   `� 5E   &    �� StringFormat$  {0} {1} {2}��63   .1�5F   *   ��  �� Path$
 name�62   6@   �� 5G   *   $ surname�62   6C   �� 5H   *   $ 
patronymic�62   6F   5J   '   5L      5M      5O      �� 5P      -	   5         ��Name$ labelDateOT��5P      $��Период с ��6-   $��35��6A   $
��Bold"�6M   ���	#DD000000$y�Hidden=�6v   $��	 0 0 10 0q�6�   $��16(�6�   $��80��6�   (  "System.Windows.Controls.DatePicker  5Q      -
   5          Name$ DataOT��5Q      
�������
���   ����	#89000000$
��Left=�6l   $��45��6�   $	��100��6�   $��0 0 10 0q�6�   $y�Hidden=�6�   $��14(�6�   �� 5R      -   5        $ labelDateDo��5R      $
��По��6.   $��35��6;   $
��Bold"�6G   ���	#DD000000$y�Hidden=�6p   $�� 0 0 0 0q�6�   $��16(�6�   $��80��6�     5S      -   5        $ DataDO��5S      
�������
���   ����	#89000000$
��Left=�6k   $��45��6�   $	��100��6�   $��	 0 0 10 0q�6�   $y�Hidden=�6�   �� 5T      -   5        $ ClearFilterFieldsButton��5T      $��50��6:   $��50��6F   $��5 0 0 0q�6Q   $��0q�6b   
�������$y�Hidden=�6�   $��16(�6�   .��5U        $
 CloseOctagon=�6.   $��35��6B   $��35��6M   6\   5V      �� 5Y      -   5        $ SearchButton��5Y      $��50��6/   $��50��6;   $��5 0 5 0q�6F   $��0q�6W   
�������$
	 Hand��6�   $y�Hidden=�6�   $��16(�6�   .��5Z        $
 Magnify=�6.   $��35��6=   $��35��6H   
�������6T   5[      5\      5]      � 5^   
   $��1��6   $��10q�6   .+�5_      &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGridView��5_         CanUserAddRows$
 True��61      SelectionMode$ Single=�6G      SelectionUnit$ FullRow=�6^   $��16(�6v   5a      5b      5e      5f      