   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5          QuanLyNhaHang.StaffCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyNhaHang     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��50��5	      .��5      � .+�5   
   �� $��5q�5      
�������  �� CornerRadius$  10��5      ._�5      �  � ColumnDefinitions 5      �� 5      $��20 �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $	��100 �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $	��140 �6'   .+�5      �� $��50��5      $��Center=�5      $��Center=�5       � 	Resources 5        �� 
TargetType �� Property �� Value��%_   '��       �� 5!      " ��6    .�5"      ��  �@��CornerRadius$ 10��6=   5#      5$      5%      �� 5&      -   5         ��Name$  employeeBasicInfoContainer��5'      $��1��5(      $	��5,0q�5)       �� Orientation$ 
Horizontal=�5*      .+�5+      �� -   5         ��Name$ 
nameTxtBox��5,      $��Center=�5-      $��Center=�5.      
���   �$��Nguyen Doan Thinh��50      51      �� 52      -   5        $ employeeSalaryContainer��53      $��2��54      $��5q�55      $ 
Horizontal=�56      .+�57      �� -   5        $ salaryTxtBox��58      $��Center=�59      $��Center=�5:      
���   �$��
100000 Vnd��5<      5=      �� 5>      -   5        $��employeePosition��5?      $��3��5@      $��5q�5A      $ 
Horizontal=�5B      .+�5C      �� -   5        $ positionTxtBox��5D      $��Center=�5E      $��Center=�5F      
���   �$
��Chef��5H      5I      �� 5J      -   5        $��employeeMail��5K      $��4��5L      $��5q�5M      $ 
Horizontal=�5N      .+�5O      �� -   5        $ 
mailTxtBox��5P      $��Center=�5Q      $��Center=�5R      
���   �$��
@gmail.com��5T      5U      �� 5V      -	   5        $��employeePhone��5W      $��5��5X      $��5q�5Y      $ 
Horizontal=�5Z      .+�5[      �� -
   5        $ phoneTxtBox��5\      $��Center=�5]      $��Center=�5^      
���   �$
��0987��5`      5a      � 5b      $��6��6   $
��Left=�6'    5c      �� 5d      �� 5e      �� 5f      .+�5h      �� -   5        	 ��Name$	 
editButton��5i      $��0��5j      
�������
�������.��5o      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��5p      
�������
   Kind$
 Pencil=�5r      5s      �� 5t      $��1��5u      $��41��5v      $��20��5w      
������� � LayoutTransform 5y      �� 5z       �� Angle$ 90Q�6.   5|      �� 5}      -   5        $	 deleteButton��5~      $��2��5      
�������
�������.��5�        -   5          Name$ 
deleteIcon��5�      
�������$
 
GarbageCan=�5�      5�      5�      5�      5�      5�      5�      