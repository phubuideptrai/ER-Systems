   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	       QuanLyNhaHang.ChefForm   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Chef's Form��5	   	   $
��auto��6   $
��1000��6+    � WindowStartupLocation$ CenterScreen=�68    � WindowStyle$
 None=�6]   .��5
      � .+�5   
   �  � RowDefinitions 5      �� 5      $��60 �6    �� 5      .+�5      � $��60��6   $��0��6   $	��Top=�6,   ���	#FFDA8046 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�6'      ShadowDepth$ 1Q�66      Color$ 	#FFACACAC��6F   .+�5      �� $��Change meal status��6   $��35(�66   
�������$��Center=�5      $��Center=�65   6S   �� 5      -   5         ��Name$ passwordSave��5      $��Center=�5      $��Center=�5      $��35(�5      
�������$y�Hidden=�5      $	��asd��5      �� 5      	 �� Orientation$	 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        $ tblName��5       $�� Chef��61   
�������$��Center=�6Q   $��18(�6l   6|   '  !MaterialDesignThemes.Wpf.PopupBox  5       $��5q�6/   
   PlacementMode$
 BottomAndAlignRightEdges=�6:      	StaysOpen$ False��5!   +   
�������   PopupContent. 5"      �� $	��150��6%   .+�5#      �� -   5         ��Name$ 
InfoButton��5$      $��
Info Staff��5%      5&      �� 5'      -   5        $��ChangepasswordButton��5(   %   $��Change password��5'   %    � Cursor$
 Hand��5*   !   62   �� 5+      �� 5,      -   5        $ LogoutButton��5,   %   $��Logout��6;   $
 Hand��5-   <   6L   5.      5/      50      51      � 52      $��1��6   $��0,10,0,0q�6     53      �� 54      $��30 �6$   �� 55      .+�57      � $��0��6   .+�58      +   %QuanLyNhaHang.ChangeMealStatusManager  59      � 5:      -   5         �Name$ mealCardContainer��5:      $��1��62   $��0,50,0,0q�6?   .+�5;      �� $��	0,-50,0,0q�6#   .��5<      �� -   5         ��Name$ spMealStatusChef��5<   %   $	 Vertical=�6?   .+�5=      (   "QuanLyNhaHang.ChangeMealStatusCard  5?      5@      5A      5B      5C      5F      5G      