   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyNhaHang.MainTemplateQuanLyNhaHang.MainTemplate  5      *    $QuanLyNhaHang.MainTemplate.InfoStaff   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:QuanLyNhaHang.MainTemplate     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  	InfoStaff��5	      $	��900��5
      $	��600��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��5      $��0,50,0,0q�5       � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#       5&      �� 5'      �� 5(      $��3* �6#   .+�5*      �� -   5         ��Name$ lbNameEmployee��5+      $��0��5,      $��Right=�5-      $��Center=�5.      $
��Name��5/      $��18(�50      $
��Bold"�51      
���   �52      � 53      -   5        $ grdNameEmployee��54      $��1��55      $��50,0,0,0q�56      .+�57      �� -   5         ��Name$ recNameEmployee��58      $	��300��59      $��40��5:      $
��Left=�5;       �� RadiusX$ 5��5<      	 �� RadiusY$	 5��5=      
�������5>      �� 5?      -   5        
 ��Name$
 txtNameEmployee��5@      $
��Left=�5C      $��Center=�5D      $
��Left=�5E      $��Center=�5F      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee's Name��5G      $��0q�5H      $��14(�5I      $
��Bold"�5J       �� MaxLines$ 1��5K      ��5A      �� *ActualWidth+ �� ElementName$ recNameEmployee����5B      �� *ActualHeight+$ recNameEmployee�� �� SelectionBrush 5L      Z� 5M      �� 5N      -   5        $ lbUserNameEmployee��5O      $��1��5P      $��Username��5S      ��5Q      �� *HorizontalAlignment+$ lbNameEmployee����5R      �� *VerticalAlignment+$ lbNameEmployee����5T      �� *
FontSize+$ lbNameEmployee����5U      �� *
FontWeight+$ lbNameEmployee����5V      �� *
Foreground+$ lbNameEmployee��� 5W      -   5        $ grdUserNameEmployee��5X      $��1��5Y      $��1��5Z      ��5[      �� *ActualWidth+$ recNameEmployee����5\      �� *Margin+$ grdNameEmployee����5]      �� *HorizontalAlignment+$ recNameEmployee��.+�5^      �� -	   5        $ recUserNameEmployee��5_      ��5`      �� *ActualWidth+$ recNameEmployee����5a      �� *ActualHeight+$ recNameEmployee����5b      �� *Margin+$ recNameEmployee����5c      �� *HorizontalAlignment+$ recNameEmployee�� 5d      �� *	RadiusX+$ recNameEmployee��	 5e      �� *	RadiusY+$ recNameEmployee����5f      �� *Stroke+$ recNameEmployee���� 5g      -
   5        $
 txtUserNameEmployee��5h      $ Employee's username��5o       �� 
IsReadOnly$
 True��5s      ��5i      �� *ActualWidth+$ txtNameEmployee����5j      �� *ActualHeight+$ txtNameEmployee����5k      �� *HorizontalAlignment+$ txtNameEmployee����5l      �� *VerticalAlignment+$ txtNameEmployee����5m      �� *HorizontalContentAlignment+$ txtNameEmployee����5n      �� *VerticalContentAlignment+$ txtNameEmployee����5p      �� *BorderThickness+$ txtNameEmployee����5q      �� *
FontSize+$ txtNameEmployee����5r      �� *
FontWeight+$ txtNameEmployee�� 5t      �� *
MaxLines+$ txtNameEmployee�� 5u      Z� 5v      �� 5w      -   5        $ lbSex��5x      $��2��5y      $	��Sex��5|      ��5z      �� *HorizontalAlignment+$ lbNameEmployee����5{      �� *VerticalAlignment+$ lbNameEmployee����5}      �� *
FontSize+$ lbNameEmployee����5~      �� *
FontWeight+$ lbNameEmployee����5      �� *
Foreground+$ lbNameEmployee��� 5�      -   5        $ grdSex��5�      $��2��5�      $��1��5�      ��5�      �� *ActualWidth+$ recNameEmployee����5�      �� *Margin+$ grdNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee�� 5�      �� 5�      �� 5�      .+�5�      	� -   5         	�Name$ rdoMale��5�      $
��Left=�5�      $��Center=�5�      $
��Male��5�      $��16(�5�       d� 	IsChecked$
 TrueY�5�       "  MaterialDesignLightRadioButton#��[  5�      	� 5�      -   5        $ 	rdoFemale��5�      $��1��5�      $��Female��5�      #��[  5�      ��5�      �� *HorizontalAlignment+$ rdoMale����5�      �� *VerticalAlignment+$ rdoMale����5�      �� *
FontSize+$ rdoMale��5�      5�      �� 5�      -   5        $ 
lbPosition��5�      $��3��5�      $��Position��5�      ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee��� 5�      -   5        $ grdPosition��5�      $��3��5�      $��1��5�      ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recPosition��5�      ��5�      �� *ActualWidth+$ recNameEmployee����5�      �� *ActualHeight+$ recNameEmployee����5�      �� *Margin+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee���� 5�      -   5         ��Name$ tblPosition��5�      $��10q�5�      $��Center=�5�      $��18(�5�      
���   �$��Position��5�      5�      �� 5�      -   5        $ lbEmailEmployee��5�      $��4��5�      $��Email��5�      ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee��� 5�      -   5        $ grdEmailEmployee��5�      $��4��5�      $��1��5�      ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recEmailEmployee��5�      ��5�      �� *ActualWidth+$ recNameEmployee����5�      �� *ActualHeight+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee���� 5�      -   5        $
 txtEmailEmployee��5�      $ Employee's email��5�      ��5�      �� *ActualWidth+$ txtNameEmployee����5�      �� *ActualHeight+$ txtNameEmployee����5�      �� *HorizontalAlignment+$ txtNameEmployee����5�      �� *VerticalAlignment+$ txtNameEmployee����5�      �� *HorizontalContentAlignment+$ txtNameEmployee����5�      �� *VerticalContentAlignment+$ txtNameEmployee����5�      �� *BorderThickness+$ txtNameEmployee����5�      �� *
FontSize+$ txtNameEmployee����5�      �� *
FontWeight+$ txtNameEmployee�� 5�      �� *
MaxLines+$ txtNameEmployee�� 5�      Z� 5�      �� 5�      -   5        $ lbSalaryEmployee��5�      $��5��5�      $��Salary��5�      ��5�      �� *HorizontalAlignment+$ lbNameEmployee����5�      �� *VerticalAlignment+$ lbNameEmployee����5�      �� *
FontSize+$ lbNameEmployee����5�      �� *
FontWeight+$ lbNameEmployee����5�      �� *
Foreground+$ lbNameEmployee��� 5�      -   5        $ grdSalaryEmployee��5�      $��5��5�      $��1��5�      ��5�      �� *Margin+$ grdNameEmployee��.+�5�      �� -   5        $ recSalaryEmployee��5�      ��5�      �� *ActualWidth+$ recNameEmployee����5�      �� *ActualHeight+$ recNameEmployee����5�      �� *HorizontalAlignment+$ recNameEmployee�� 5�      �� *	RadiusX+$ recNameEmployee��	 5�      �� *	RadiusY+$ recNameEmployee����5�      �� *Stroke+$ recNameEmployee���� 5�      -   5        $ 	tblSalary��5�      $��10q�5�      $��Center=�5�      $��18(�5�      
���   �$��Salary��5�      5      �� 5     -   5        $ lbPhoneEmployee��5     $��6��5     $��Phone��5     ��5     �� *HorizontalAlignment+$ lbNameEmployee����5     �� *VerticalAlignment+$ lbNameEmployee����5     �� *
FontSize+$ lbNameEmployee����5     �� *
FontWeight+$ lbNameEmployee����5	     �� *
Foreground+$ lbNameEmployee��� 5
     -   5        $ grdPhoneEmployee��5     $��6��5     $��1��5     ��5     �� *Margin+$ grdNameEmployee��.+�5     �� -   5        $ recPhoneEmployee��5     ��5     �� *ActualWidth+$ recNameEmployee����5     �� *ActualHeight+$ recNameEmployee����5     �� *HorizontalAlignment+$ recNameEmployee�� 5     �� *	RadiusX+$ recNameEmployee��	 5     �� *	RadiusY+$ recNameEmployee����5     �� *Stroke+$ recNameEmployee���� 5     -   5        $
 txtPhoneEmployee��5     $ Employee's Phone Number��5     ��5     �� *ActualWidth+$ txtNameEmployee����5     �� *ActualHeight+$ txtNameEmployee����5     �� *HorizontalAlignment+$ txtNameEmployee����5     �� *VerticalAlignment+$ txtNameEmployee����5     �� *HorizontalContentAlignment+$ txtNameEmployee����5     �� *VerticalContentAlignment+$ txtNameEmployee����5      �� *BorderThickness+$ txtNameEmployee����5!     �� *
FontSize+$ txtNameEmployee����5"     �� *
FontWeight+$ txtNameEmployee�� 5#     �� *
MaxLines+$ txtNameEmployee�� 5$     Z� 5&     � 5'     -   5        $ grdSelection��5(     $��7��5)     $��1��5*     $
��Left=�5-     $��Center=�5.     ��5+     �� *ActualWidth+$ recNameEmployee����5,     �� *Margin+$ grdNameEmployee�� 5/     �� 50     �� 51     �� 52     .+�54     �� -    5         ��Name$ 
btnConfirm��55     $��0��56     +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��57     ���	#FFF38413$��Confirm��5:     $��11(�5;     $
��Bold"�5<     
������� ! MaterialDesignFlatMidBgButton#��[ 5>     �� 5@     -!   5        $ 	btnCancel��5A     $��2��5B     $ 10��5C     $��Cancel��5F     $��11(�5G        MaterialDesignOutlinedButton#��[ 5J     ��5D     �� *
Foreground+$ 
btnConfirm����5H     �� *
FontWeight+$ 
btnConfirm����5I     �� *
Background+$ 
btnConfirm��5J     5K     5L     5M     5N     