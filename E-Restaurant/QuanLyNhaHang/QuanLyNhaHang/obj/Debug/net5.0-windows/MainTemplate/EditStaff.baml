   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyNhaHang.MainTemplateQuanLyNhaHang.MainTemplate  5   	   *    $QuanLyNhaHang.MainTemplate.EditStaff   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:QuanLyNhaHang.MainTemplate     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	EditStaff��5	   	   $	��600��6   $	��900��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"    5      �� 5      6%   �� 5       $��3* �6#   60   .+�5"      �� -   5         ��Name$ lbNameEmployee��5#      $
��Name��6-   $��Right=�5$      $��Center=�6-   
���   �$��18(�5%   +   $
��Bold"�5&      $��0��6-   � 5'      -   5        $ grdNameEmployee��5(      $��50,0,0,0q�5)      $��1��5*      .+�5+      �� -   5         ��Name$ recNameEmployee��5+      $��40��5,      $	��300��63    �� RadiusX$ 5��5-      	 �� RadiusY$	 5��63   
�������$
��Left=�5.   1   �� 5/      -   5        
 ��Name$
 txtNameEmployee��50      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee's Name��51      $��14(�54      $��0q�6)    �� MaxLines$ 1��55      $
��Left=�56      $
��Left=�69   $��Center=�57      $��Center=�69   $
��Bold"�58      ��52      �� *ActualWidth+ �� ElementName$ recNameEmployee����53      �� *ActualHeight+$ recNameEmployee�� �� SelectionBrush 55   )   Z� 58      59      �� 5:      -   5        $ lbUserNameEmployee��5;      $��Username��61   $��1��6I   ��5<      �� *HorizontalAlignment+$ lbNameEmployee����5=      �� *VerticalAlignment+$ lbNameEmployee����5>      �� *
Foreground+$ lbNameEmployee����5?      �� *
FontSize+$ lbNameEmployee����5@      �� *
FontWeight+$ lbNameEmployee��� 5A      -   5        $ grdUserNameEmployee��5B      $��1��61   $��1��6D   ��5C      �� *Margin+$ grdNameEmployee����5D      �� *HorizontalAlignment+$ recNameEmployee����5E      �� *ActualWidth+$ recNameEmployee��.+�5F      �� -	   5        $ recUserNameEmployee��5F      ��5G      �� *ActualHeight+$ recNameEmployee����5H      �� *ActualWidth+$ recNameEmployee�� 5I      �� *	RadiusX+$ recNameEmployee��	 5J      �� *	RadiusY+$ recNameEmployee����5K      �� *Stroke+$ recNameEmployee����5L      �� *Margin+$ recNameEmployee����5M      �� *HorizontalAlignment+$ recNameEmployee���� 5N      -
   5        $
 txtUserNameEmployee��5O       �� 
IsReadOnly$
 True��5P      $ Employee's username��5Q      ��5R      �� *ActualWidth+$ txtNameEmployee����5S      �� *ActualHeight+$ txtNameEmployee����5T      �� *
FontSize+$ txtNameEmployee����5U      �� *BorderThickness+$ txtNameEmployee�� 5V      �� *
MaxLines+$ txtNameEmployee�� 5W      Z� ��5X      �� *HorizontalContentAlignment+$ txtNameEmployee����5Y      �� *HorizontalAlignment+$ txtNameEmployee����5Z      �� *VerticalContentAlignment+$ txtNameEmployee����5[      �� *VerticalAlignment+$ txtNameEmployee����5\      �� *
FontWeight+$ txtNameEmployee��5]      �� 5^      -   5        $ lbSex��5_      $	��Sex��6%   $��2��69   ��5`      �� *HorizontalAlignment+$ lbNameEmployee����5a      �� *VerticalAlignment+$ lbNameEmployee����5b      �� *
Foreground+$ lbNameEmployee����5c      �� *
FontSize+$ lbNameEmployee����5d      �� *
FontWeight+$ lbNameEmployee��� 5e      -   5        $ grdSex��5f      $��1��6%   $��2��6=   ��5g      �� *Margin+$ grdNameEmployee����5h      �� *HorizontalAlignment+$ recNameEmployee����5i      �� *ActualWidth+$ recNameEmployee�� 5j      �� 5k      6)   �� 5l      6)   .+�5n      	� -   5         	�Name$ rdoMale��5o      $
��Male��65    "  MaterialDesignLightRadioButton#��[  5p       d� 	IsChecked$
 TrueY�5q      $��16(�65   $
��Left=�5r      $��Center=�65   	� 5s      -   5        $ 	rdoFemale��5t      $��Female��65   $��1��5u      #��[  5v      ��5w      �� *
FontSize+$ rdoMale����5x      �� *HorizontalAlignment+$ rdoMale����5y      �� *VerticalAlignment+$ rdoMale��5z      �� 5{      -   5        $ 
lbPosition��5|      $��Position��6)   $��3��6A   ��5}      �� *HorizontalAlignment+$ lbNameEmployee����5~      �� *VerticalAlignment+$ lbNameEmployee����5      �� *
Foreground+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee��� 5�      -   5        $ grdPosition��5�      $��1��5�      $��3��6)   ��5�   )   �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recPosition��5�      ��5�      �� *ActualHeight+$ recNameEmployee����5�      �� *ActualWidth+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee����5�      �� *Margin+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee���� 5�      -   5         ��Name$ 
cmbPoition��5�      $ Staff's position��5�       �� 
IsEditable$ False��5�      ��5�      �� *HorizontalAlignment+$ txtNameEmployee����5�      �� *
FontWeight+$ txtNameEmployee����5�      �� *ActualWidth+$ recNameEmployee����5�      �� *ActualHeight+$ recNameEmployee����5�      �� *#!LongListToTestComboVirtualization+ �� Text 5�      �� 5�       �� Path$ SelectedTextTwo�5�       �� Mode$ TwoWay=�5�       �� UpdateSourceTrigger$ PropertyChanged=�5�      5�      .@�5�      �� .��6#   	Manager5�      �� 5�      .��6#   Waiter5�      �� 5�      .��6#   Chef5�      ��5�      �� 5�      .R�5�      $� 5�      5�      5�      �� 5�      -   5        $ lbEmailEmployee��5�      $��Email��6-   $��4��6A   ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee��� 5�      -   5        $ grdEmailEmployee��5�      $��1��6-   $��4��6A   ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recEmailEmployee��5�      ��5�      �� *ActualHeight+$ recNameEmployee����5�      �� *ActualWidth+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee���� 5�      -   5        $
 txtEmailEmployee��5�      $ Employee's email��5�      ��5�      �� *ActualWidth+$ txtNameEmployee����5�      �� *ActualHeight+$ txtNameEmployee����5�      �� *
FontSize+$ txtNameEmployee����5�      �� *BorderThickness+$ txtNameEmployee�� 5�      �� *
MaxLines+$ txtNameEmployee�� 5�      Z� ��5�      �� *HorizontalContentAlignment+$ txtNameEmployee����5�      �� *HorizontalAlignment+$ txtNameEmployee����5�      �� *VerticalContentAlignment+$ txtNameEmployee����5�      �� *VerticalAlignment+$ txtNameEmployee����5�      �� *
FontWeight+$ txtNameEmployee��5�      �� 5�      -   5        $ lbSalaryEmployee��5�      $��Salary��61   $��5��6I   ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee��� 5�      -   5        $ grdSalaryEmployee��5�      $��1��61   $��5��6E   ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recSalaryEmployee��5�      ��5�      �� *ActualHeight+$ recNameEmployee����5�      �� *ActualWidth+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee���� 5�      -   5        $
 txtSalaryEmployee��5�      $ Employee's Salary��5�      ��5�      �� *ActualWidth+$ txtNameEmployee����5�      �� *ActualHeight+$ txtNameEmployee����5�      �� *
FontSize+$ txtNameEmployee����5�      �� *BorderThickness+$ txtNameEmployee�� 5�      �� *
MaxLines+$ txtNameEmployee�� 5�      Z� ��5�      �� *HorizontalContentAlignment+$ txtNameEmployee����5�      �� *HorizontalAlignment+$ txtNameEmployee����5�      �� *VerticalContentAlignment+$ txtNameEmployee����5�      �� *VerticalAlignment+$ txtNameEmployee����5�      �� *
FontWeight+$ txtNameEmployee��5�      5�      �� 5�      -   5        $ lbPhoneEmployee��5�      $��Phone��6-   $��6��6A   ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee��� 5�      -   5        $ grdPhoneEmployee��5�      $��1��61   $��6��6E   ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recPhoneEmployee��5�      ��5�      �� *ActualHeight+$ recNameEmployee����5�      �� *ActualWidth+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5      �� *Stroke+$ recNameEmployee����5     �� *HorizontalAlignment+$ recNameEmployee���� 5     -   5        $
 txtPhoneEmployee��5     $ Employee's Phone Number��5     ��5     �� *ActualWidth+$ txtNameEmployee����5     �� *ActualHeight+$ txtNameEmployee����5     �� *
FontSize+$ txtNameEmployee����5     �� *BorderThickness+$ txtNameEmployee�� 5	     �� *
MaxLines+$ txtNameEmployee�� 5
     Z� ��5     �� *HorizontalContentAlignment+$ txtNameEmployee����5     �� *HorizontalAlignment+$ txtNameEmployee����5     �� *VerticalContentAlignment+$ txtNameEmployee����5     �� *VerticalAlignment+$ txtNameEmployee����5     �� *
FontWeight+$ txtNameEmployee��5     5     � 5     -   5        $ grdSelection��5     $��Center=�5     $
��Left=�6.   $��7��5     $��1��6    ��5     �� *ActualWidth+$ recNameEmployee����5     �� *Margin+$ grdNameEmployee�� 5     �� 5     6)   �� 5     6)   �� 5     6)   .+�5     �� -    5         ��Name$ 
btnConfirm��5     $��0��6-   ���	#FFF38413$��Confirm��5  0   
�������$��11(�5  ,   $
��Bold"�6:    ! MaterialDesignFlatMidBgButton#��[ 5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5!     5"     �� 5$     -!   5        $ 	btnCancel��5$     $��2��6,   $��Cancel��5%  S   $��11(�5&  S      MaterialDesignOutlinedButton#��[ 5(     $ 10��5)     ��5%     �� *
Foreground+$ 
btnConfirm����5&     �� *
Background+$ 
btnConfirm����5'     �� *
FontWeight+$ 
btnConfirm��5*     5+     5,     5-     5.     