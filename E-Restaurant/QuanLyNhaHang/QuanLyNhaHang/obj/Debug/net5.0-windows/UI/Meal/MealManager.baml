   M S B A M L   `   `   `  ����  QuanLyNhaHang    QuanLyNhaHang.MealManager   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5      $
��auto��6   .��5	      � $
��auto��6   $
��auto��6   $��5q�6&   .+�5   
   � $��0��6     � ColumnDefinitions  5      �� 5      $��30 �6#   �� 5      $��2* �6#   �� 5      $��* �6#   �� 5      $	��100 �6#   �� 5      $	��160 �6#   �� 5      $	��140 �6#   .+�5      �� $	��Top=�6   $��Center=�6/   $��18��6L   $��18��6X    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 10��69   5      5      5      �� 5       �� Orientation$ 
Horizontal=�6   $��1��62   $	��Top=�6B   $��16��6Z   $
��10,0q�6f   .+�5      �� $
��Meal��6   �� 5      -   5        $��btnSortName��5      $��18��6,   $
��auto��68   $��5,0,0,0q�6E   
������ .��5       '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��nameSortIcon��5    .      Kind$ ArrowBottom=�6B   
���  ��$��Center=�6f   $��Center=�6�   5!      5"      �� 5#      $ 
Horizontal=�6   $��2��62   $	��Top=�6B   $��16��6Z   .+�5%      �� $��Category��6   �� 5&      -   5        $��btnSortCategory��5&      $��18��60   $
��auto��6<   $��5,0,0,0q�6I   
������ .��5'        -   5        $��categorySortIcon��5'   .   $ ArrowBottom=�6F   
���  ��$��Center=�6j   $��Center=�6�   5(      5)      �� 5*      $ 
Horizontal=�6   $��3��62   $	��Top=�6B   $��16��6Z   .+�5,      �� $��Price��6   �� 5-      -   5        $��btnSortPrice��5-      $��18��5.      $
��auto��6%   $��5,0,0,0q�5/      
������ .��52        -   5        $��priceSortIcon��53      $ ArrowBottom=�54      
���  ��$��Center=�56      $��Center=�57      58      59      �� 5:      $ 
Horizontal=�6   $��4��62   $	��Top=�6B   .+�5;      �� $��Order quantity��6   �� 5<      -   5        $��btnSortQuantity��5<      $��18��5=      $
��auto��6%   $��5,0,0,0q�5>      
������ .��5A        -   5        $��quantitySortIcon��5B      $ ArrowBottom=�5C      
���  ��$��Center=�5E      $��Center=�5F      5G      5H      �� 5I      $ 
Horizontal=�6   $��5��62   $	��Top=�6B   $��16��6Z   .+�5K      �� $��Manage��6   5N      5P      5S      5T      