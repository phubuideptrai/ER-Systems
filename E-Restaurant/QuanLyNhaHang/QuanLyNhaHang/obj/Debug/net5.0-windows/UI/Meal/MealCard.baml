   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5          QuanLyNhaHang.MealCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyNhaHang     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $��30 �6'   �� 5      $��2* �6'   �� 5      $��* �6'   �� 5      $	��100 �6'   �� 5      $	��160 �6'   �� 5      $	��140 �6'   .+�5      �� $��50��5      $��Center=�5      $��Center=�5       � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 10��6=   5       5!      5"      �� 5#      -   5         ��Name$ mealInfo��5$      $��1��5%      $
��Left=�5&       �� Orientation$ 
Horizontal=�5'      .+�5)      �� -   5         ��Name$ mealName��5*      $
��10,0q�5+      $
��Left=�5,      $��Center=�5-      
���   �$��Pork with rice��5/      50      �� 51      -   5        $ mealCategoryContainer��52      $��2��53      $
��Left=�54      $ 
Horizontal=�55      .+�56      �� -   5        $ mealCategory��57      $
��10,0q�58      $��Center=�59      $��Center=�5:      
���   �$��	Main dish��5<      5=      �� 5>      -   5        $ mealPriceContainer��5?      $��3��5@      $��Center=�5A      $��Center=�5B      .+�5C      �� -   5        $ 	mealPrice��5D      $
��10,0q�5E      $��Center=�5F      $��Center=�5G      $��
100000 Vnd��5H      5I      �� 5J      -   5        $ ��mealOrderQuantityContainer��5K      $��4��5L      $��Center=�5M      $��Center=�5N      .+�5O      �� -   5        $ orderQuantity��5P      $��	10,0,10,0q�5Q      $	��100��5R      5S      � 5T      -	   5        $��5��5U      $
��Left=�5V       5X      �� 5Y      �� 5Z      �� 5[      .+�5]      �� -
   5        	 ��Name$	 
editButton��5^      $��0��5_      
�������
�������.��5e      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��5f      
�������
   Kind$
 Pencil=�5h      5i      �� 5j      $��1��5k      $��41��5l      $��20��5m      
������� � LayoutTransform 5o      �� 5p       �� Angle$ 90Q�6.   5r      �� 5s      -   5        $	 deleteButton��5t      $��2��5u      
�������
�������.��5z        -   5          Name$ 
deleteIcon��5{      
�������$
 
GarbageCan=�5}      5~      5      5�      5�      5�      5�      