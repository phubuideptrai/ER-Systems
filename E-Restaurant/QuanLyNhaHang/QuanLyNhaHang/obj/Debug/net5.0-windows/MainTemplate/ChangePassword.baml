   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	   "    QuanLyNhaHang.ChangePassword   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ChangePassword��5	   	   $	��400��6    $	��900��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"    5      �� 5      6%   �� 5      $��3* �6#   60   .+�5      �� -   5         ��Name$ lbUserNameEmployee��5      $��UserName��61   $��Right=�5      $��Center=�6-   
���   �$��18(�5    +   $
��Bold"�5!      $��0��6-   � 5"      -   5        $ grdUserNameEmployee��5#      $��50,0,0,0q�5$      $��1��5%      .+�5&      �� -   5         ��Name$ recUserNameEmployee��5&      $��40��5'      $	��300��63    �� RadiusX$ 5��5(      	 �� RadiusY$	 5��63   
�������$
��Left=�5)   1   �� 5*      -   5        
 ��Name$
 txtUserNameEmployee��5+       �� 
IsReadOnly$
 True��5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee's UserName��5-      $��14(�50      $��0q�6)    �� MaxLines$ 1��51      $
��Left=�52      $
��Left=�69   $��Center=�53      $��Center=�69   $
��Bold"�54      ��5.      �� *ActualWidth+ �� ElementName$ recNameEmployee����5/      �� *ActualHeight+$ recUserNameEmployee�� �� SelectionBrush 51   )   Z� 54      55      �� 56      -   5        $ lbPasswordEmployee��57      $��Password��60   $��1��6G   ��58      �� *HorizontalAlignment+$ lbUserNameEmployee����59      �� *VerticalAlignment+$ lbUserNameEmployee����5:      �� *
Foreground+$ lbUserNameEmployee����5;      �� *
FontSize+$ lbUserNameEmployee����5<      �� *
FontWeight+$ lbUserNameEmployee��� 5=      -   5        $ grdPasswordEmployee��5>      $��1��60   $��1��6D   ��5?      �� *Margin+$ grdUserNameEmployee��.+�5@      �� -	   5        $ recPasswordEmployee��5@      ��5A      �� *ActualHeight+$ recUserNameEmployee����5B      �� *ActualWidth+$ recUserNameEmployee�� 5C      �� *	RadiusX+$ recUserNameEmployee��	 5D      �� *	RadiusY+$ recUserNameEmployee����5E      �� *Stroke+$ recUserNameEmployee����5F      �� *HorizontalAlignment+$ recUserNameEmployee��G� 5G      -
   5         G�Name$ txtPasswordEmployee��5H      $ Employee's password��5I      ��5J      �� *ActualWidth+$ txtUserNameEmployee����5K      �� *ActualHeight+$ txtUserNameEmployee����5L      �� *
FontSize+$ txtUserNameEmployee����5M      �� *BorderThickness+$ txtUserNameEmployee�� G� SelectionBrush 5N      Z� ��5O      �� *HorizontalContentAlignment+$ txtUserNameEmployee����5P      �� *HorizontalAlignment+$ txtUserNameEmployee����5Q      �� *VerticalContentAlignment+$ txtUserNameEmployee����5R      �� *VerticalAlignment+$ txtUserNameEmployee����5S      �� *
FontWeight+$ txtUserNameEmployee��5T      �� 5U      -   5        $ lbConfirmPassword��5V      $��Confirm��62   $��2��6K   ��5W      �� *HorizontalAlignment+$ lbUserNameEmployee����5X      �� *VerticalAlignment+$ lbUserNameEmployee����5Y      �� *
Foreground+$ lbUserNameEmployee����5Z      �� *
FontSize+$ lbUserNameEmployee����5[      �� *
FontWeight+$ lbUserNameEmployee��� 5\      -   5        $ grdConfirmPassword��5]      $��1��62   $��2��6F   ��5^      �� *Margin+$ grdUserNameEmployee��.+�5`      �� -   5        $ recConfirmPassword��5`      ��5a      �� *ActualHeight+$ recUserNameEmployee����5b      �� *ActualWidth+$ recUserNameEmployee�� 5c      �� *	RadiusX+$ recUserNameEmployee��	 5d      �� *	RadiusY+$ recUserNameEmployee����5e      �� *Stroke+$ recUserNameEmployee����5f      �� *HorizontalAlignment+$ recUserNameEmployee��G� 5g      -   5        $ txtConfirmPassword��5h      $ Confirm password��5i      ��5j      �� *ActualWidth+$ txtUserNameEmployee����5k      �� *ActualHeight+$ txtUserNameEmployee����5l      �� *
FontSize+$ txtUserNameEmployee����5m      �� *BorderThickness+$ txtUserNameEmployee�� 5n      Z� ��5o      �� *HorizontalContentAlignment+$ txtUserNameEmployee����5p      �� *HorizontalAlignment+$ txtUserNameEmployee����5q      �� *VerticalContentAlignment+$ txtUserNameEmployee����5r      �� *VerticalAlignment+$ txtUserNameEmployee����5s      �� *
FontWeight+$ txtUserNameEmployee��5u      � 5v      -   5        $ grdSelection��5v      $��Center=�5y      $
��Left=�6.   $��7��5z      $��1��6    ��5w      �� *ActualWidth+$ recUserNameEmployee����5x      �� *Margin+$ grdUserNameEmployee�� 5{      �� 5|      6)   �� 5}      6)   �� 5~      6)   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��6-   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�      6G   �� 5�      -   5        $ 	btnCancel��5�      $��2��6,   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $ 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�   G   5�      5�      5�      5�      