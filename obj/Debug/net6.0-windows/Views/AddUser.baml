   M S B A M L   `   `   `  ����O  KTiresShopApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TiresShopApplication.ViewsTiresShopApplication.Views  5      (    "TiresShopApplication.Views.AddUser   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TiresShopApplication.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $	��500��6    $	��200��6-   .+�5      �� .+�5      �� $��0 25 0 5q�6   $��Center=�6*   $��12(�6G   $
��Bold"�6U   $@��:Добавление нового пользователя��6g   �� 5      -   5          ��Name$  AddLogin��5      $��5q�6(    !  MaterialDesignOutlinedTextBox#��[  5      $	��Top=�5       �� AcceptsReturn$
 True��5       �� TextWrapping$
 Wrap=�5      " �� VerticalScrollBarVisibility$
 Auto=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$* $Введите новый логин��5       � Cursor$ IBeam��6F   �� 5      -   5        $  AddName��5      $��5q�6'   #��[  5      $	��Top=�5      $
 True��5      $
 Wrap=�5      $
 Auto=�5      $ Введите имя��5      $ IBeam��6>   �� 5      -   5        $  
AddSurname��5      $��5q�6*   #��[  5      $	��Top=�5      $
 True��5      $
 Wrap=�5      $
 Auto=�5       $&  Введите фамиллию ��5!      $ IBeam��6D   �� 5"      -   5        $  Addpatronymic��5"      $��5q�6-   #��[  5#      $	��Top=�5$      $
 True��5%      $
 Wrap=�5&      $
 Auto=�5'      $&  Введите отчество ��5(      $ IBeam��6D   �� 5)      -   5        $  AddPassword��5)      $��5q�6+   #��[  5*      $	��Top=�5+      $
 True��5,      $
 Wrap=�5-      $
 Auto=�5.      $, &Введите новый пароль��5/      $ IBeam��6G   �� 50      -   5         ��Name$ 	Type_user��50      $��5q�6*   $% Тип пользователя��65    " MaterialDesignOutlinedComboBox#���  6g   .@�51      �� $��admin��6   �� 52      $��manager��6   53      �� 54      -   5         ��Name$ 
SaveButton��54      $��5q�6)   $	��150��64   $��Сохранить��6@   $
 Hand��6T   6b   55      57      58      