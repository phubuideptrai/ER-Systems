   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5      (    "QuanLyNhaHang.ChangeMealStatusCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:QuanLyNhaHang  5      $��50��5	      .��5
      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��5q�6:   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $	��100 �6'   �� 5      $��80 �6'   �� 5      $��2* �6'   �� 5      $��80 �6'   .+�5      �� -   5         ��Name$ mealInfo��5      $��0��6/    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5         ��Name$ mealName��5       $��Pork with rice��62   $��	10,0,10,0q�6H   $
��Left=�6[   $��Center=�6v   
���   �6�   5      �� 5      -   5        $ mealCategoryContainer��5      $��1��6<   $ 
Horizontal=�6L   .+�5      �� -   5        $ mealCategory��5       $��	Main dish��66   $��	10,0,10,0q�6G   $
��Left=�6Z   $��Center=�6u   
���   �6�   5      �� 5      -   5        $ mealOrderQuantity��5      $��2��68   $��Center=�6H   $��Center=�6e   .+�5      �� -   5        $ mealQuantity��5       $��2��66   $��	10,0,10,0q�6?   $
��Left=�6R   $��Center=�6m   5      �� 5       -   5        $ mealAddtionalNote��5       $��3��68   $��Center=�6H   $��Center=�6e   .+�5!      �� -   5        $ additonalNote��5!       $��
Less spicy��67   $��	10,0,10,0q�6I   $
��Left=�6\   $��Center=�6w   5#      �� 5$      -	   5        $��mealStatusChange��5$      $��4��65   $
��Left=�6E   $��Center=�6`   .+�5%      �� -
   5         ��Name$ cbStatus��5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Change status��5&      .@�5'      �� .��6'   
Not done5)      �� 5*      .��6'   Done5,      5-      5.      50      51      52      53      