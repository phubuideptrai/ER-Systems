   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyNhaHang.MainTemplateQuanLyNhaHang.MainTemplate  5   	   ,    &QuanLyNhaHang.MainTemplate.AddNewTable   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:QuanLyNhaHang.MainTemplate     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  AddNewTable��5	   	   $	��250��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5      �� 5      6"   �� 5      6"    5      �� 5      6%   �� 5      $��3* �6#   60   .+�5      �� -   5         ��Name$ 
lbNameMeal��5      $
��Name��6)   $��Right=�5      $��Center=�6-   
���   �$��18(�5   +   $
��Bold"�5      $��0��6-   � 5       -   5        $ grdNameMeal��5!      $��50,0,0,0q�5"      $��1��5#      .+�5$      �� -   5         ��Name$ recNameMeal��5$      $��40��5%      $	��300��63    �� RadiusX$ 5��5&       �� RadiusY$ 5��63   
�������$
��Left=�5'   1   �� 5(      -   5        	 ��Name$	 txtNameTable��5)      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Table's Name��5*      $��14(�5-      $��0q�6)    �� MaxLines$ 1��5.      $
��Left=�5/      $
��Left=�69   $��Center=�50      $��Center=�69   $
��Bold"�51      ��5+      �� *ActualWidth+ �� ElementName$ recNameMeal����5,      �� *ActualHeight+$ recNameMeal�� �� SelectionBrush 5.   )   Z� 51      52      � 53      -   5        $ grdCategory1��54      $��1��55      $��1��6)   ��54   *   �� *Margin+$ grdNameMeal��55   )   � 56      -   5        $ grdPriceMeal��57      $��1��6)   $��2��6=   ��58      �� *Margin+$ grdNameMeal��� 59      -	   5        $ grdSelection��59      $��Center=�5<      $
��Left=�6.   $��6��5=      $��1��6    ��5:      �� *ActualWidth+$ recNameMeal����5;      �� *Margin+$ grdNameMeal�� 5>      �� 5?      6)   �� 5@      6)   �� 5A      6)   .+�5C      �� -
   5         ��Name$ 
btnConfirm��5C      $��0��6-   ���	#FFF38413$��Confirm��5D   0   
�������$��11(�5E   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5F      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5G      6G   �� 5I      -   5        $ 	btnCancel��5I      $��2��6,   $��Cancel��5J   S   $��11(�5K   S      MaterialDesignOutlinedButton#��[ 5M      $ 10��5N      ��5J      �� *
Foreground+$ 
btnConfirm����5K      �� *
Background+$ 
btnConfirm����5L      �� *
FontWeight+$ 
btnConfirm��5N   G   5O      5P      5R      5S      