   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	       QuanLyNhaHang.AddNewMeal   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
AddNewMeal��5	   	   $	��400��6   $	��900��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"    5      �� 5      6%   �� 5      $��3* �6#   60   .+�5      �� -   5         ��Name$ 
lbNameMeal��5      $
��Name��6)   $��Right=�5      $��Center=�6-   
���   �$��18(�5    +   $
��Bold"�5!      $��0��6-   � 5"      -   5        $ grdNameMeal��5#      $��50,0,0,0q�5$      $��1��5%      .+�5&      �� -   5         ��Name$ recNameMeal��5&      $��40��5'      $	��300��63    �� RadiusX$ 5��5(      	 �� RadiusY$	 5��63   
�������$
��Left=�5)   1   �� 5*      -   5        
 ��Name$
 txtNameMeal��5+      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Meal's Name��5,      $��14(�5/      $��0q�6)    �� MaxLines$ 1��50      $
��Left=�51      $
��Left=�69   $��Center=�52      $��Center=�69   $
��Bold"�53      ��5-      �� *ActualWidth+ �� ElementName$ recNameMeal����5.      �� *ActualHeight+$ recNameMeal�� �� SelectionBrush 50   )   Z� 53      54      �� 55      -   5        $ 
lbCategory��56      $��Category��6)   $��1��6A   ��57      �� *HorizontalAlignment+$ 
lbNameMeal����58      �� *VerticalAlignment+$ 
lbNameMeal����59      �� *
Foreground+$ 
lbNameMeal����5:      �� *
FontSize+$ 
lbNameMeal����5;      �� *
FontWeight+$ 
lbNameMeal��� 5<      -   5        $ grdCategory��5=      $��1��5>      $��1��6)   ��5=   )   �� *Margin+$ grdNameMeal��.+�5?      �� -	   5        $ recCategory��5?      ��5@      �� *ActualHeight+$ recNameMeal����5A      �� *ActualWidth+$ recNameMeal�� 5B      �� *	RadiusX+$ recNameMeal��	 5C      �� *	RadiusY+$ recNameMeal����5D      �� *Stroke+$ recNameMeal����5E      �� *Margin+$ recNameMeal����5F      �� *HorizontalAlignment+$ recNameMeal���� 5G      -
   5        $��cmbCategory��5H      $ Meal's category��5I       �� 
IsEditable$ False��5L      ��5J      �� *HorizontalAlignment+$ txtNameMeal����5K      �� *
FontWeight+$ txtNameMeal����5M      �� *ActualWidth+$ recNameMeal����5N      �� *ActualHeight+$ recNameMeal����5O      �� *#!LongListToTestComboVirtualization+ �� Text 5P      �� 5Q       �� Path$ SelectedTextTwo�5R       �� Mode$ TwoWay=�5S       �� UpdateSourceTrigger$ PropertyChanged=�5T      5U      ��5W      �� 5X      .R�5Y      $� 5Z      5\      5^      �� 5_      -   5        $ lbPriceMeal��5`      $��Price��6)   $��2��6=   ��5a      �� *HorizontalAlignment+$ 
lbNameMeal����5b      �� *VerticalAlignment+$ 
lbNameMeal����5c      �� *
Foreground+$ 
lbNameMeal����5d      �� *
FontSize+$ 
lbNameMeal����5e      �� *
FontWeight+$ 
lbNameMeal��� 5f      -   5        $ grdPriceMeal��5g      $��1��6)   $��2��6=   ��5h      �� *Margin+$ grdNameMeal��.+�5i      �� -   5        $ recPriceMeal��5i      ��5j      �� *ActualHeight+$ recNameMeal����5k      �� *ActualWidth+$ recNameMeal�� 5l      �� *	RadiusX+$ recNameMeal��	 5m      �� *	RadiusY+$ recNameMeal����5n      �� *Stroke+$ recNameMeal����5o      �� *HorizontalAlignment+$ recNameMeal���� 5p      -   5        $
 txtPriceMeal��5q      $ Meal's price��5r      ��5s      �� *ActualWidth+$ txtNameMeal����5t      �� *ActualHeight+$ txtNameMeal����5u      �� *
FontSize+$ txtNameMeal����5v      �� *BorderThickness+$ txtNameMeal�� 5w      �� *
MaxLines+$ txtNameMeal�� 5x      Z� ��5y      �� *HorizontalContentAlignment+$ txtNameMeal����5z      �� *HorizontalAlignment+$ txtNameMeal����5{      �� *VerticalContentAlignment+$ txtNameMeal����5|      �� *VerticalAlignment+$ txtNameMeal����5}      �� *
FontWeight+$ txtNameMeal��5~      5      � 5�      -   5        $ grdSelection��5�      $��Center=�5�      $
��Left=�6.   $��6��5�      $��1��6    ��5�      �� *ActualWidth+$ recNameMeal����5�      �� *Margin+$ grdNameMeal�� 5�      �� 5�      6)   �� 5�      6)   �� 5�      6)   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��6-   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�      6G   �� 5�      -   5        $ 	btnCancel��5�      $��2��6,   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $ 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�   G   5�      5�      5�      5�      