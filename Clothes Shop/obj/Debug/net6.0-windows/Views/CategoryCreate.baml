   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Clothes_Shop.ViewsClothes_Shop.Views  5   	   '    !Clothes_Shop.Views.CategoryCreate   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Clothes_Shop.Views     5   	   $	��300��5	   	   $	��400��6     � WindowStyle$
  None=�5
   
    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      (� .��5      �  � RowDefinitions 5      �� 5      $��25 �6$   5      �� 5      $	��200 �6$   5      �� 5      $��* �6$   5      ��5      �� 5      .��5      �  � Color$ #204da5��6'    � Offset$	 0.0Q�67   � 5       $ #6cc4d5��6'   $ 1Q�67   5!      .+�5#      � $��0��6    � ColumnDefinitions 5%      �� 5'      $��25 �6+   �� 5(      $��25 �6+   �� 5)      $��* �6+   .+�5,      �� -   5         ��Name$ btnClose��5,      $��0q�5-   %   $��X��5.   %   
�������$��12(�50   %   $��
Montserrat)�51   %   	 � Cursor$
	 Hand��52   %   $��0��53   %   ��56      �� 57      
 �� 
TargetType"
 ��6$   .�58   "   ��  �� Property � �� �� Value �#DA34AE6?    �� Triggers 59   "   P� 5:   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5;   *   ��  � �� �#C62DAE6G   5<   '   5>      ��5@      �� 5A       �� 
TargetType" ��6.   .R�5B   "   �� $��18��6)   $��18��64    �� CornerRadius$ 9��5C   1   #��z��5D   1   ._�5E   &   �� $��Center=�67   $��Center=�6R   5F   #   5G      5I      �� 5J      -   5        $ btnMinimize��5J      $��0q�5K      $��-��5L      
�������$��16(�5N      $��
Montserrat)�5O      $
	 Hand��5P      $��1��5Q      ��5T      �� 5U      "
 ��6    .�5V      ��  � �� �#28AEED6;    5W      P� 5X   "    �@J�IsMouseOver$
 True��6A   . �5Y   &   ��  � �� �#278BEF6C   5Z   #   5\      ��5_      �� 5`      " ��6*   .R�5a      �� $��18��6%   $��18��60   $ 9��5b   1   #��z��5c   1   ._�5d   "   �� $��Center=�63   $��Center=�6N   5e      5f      5i      5j      �� 5l      $��RightToLeft=�6    �� Orientation$ 
Horizontal=�65   $��1��6N   $��1��6[   .+�5m      �� $��أسم الفئه��6   
���   �$��20(�5o       $��Medium"�5p       $��
Montserrat)�5q       $��	5 15 10 0q�5r       $��40��5s       �� 5u      -   5         ��Name$ txtCategory��5u      $��40��5v      $��11(�5w      $��
 0 0 20 20q�5x      $	��250��5y      .��6A   ��5z      �� 5{       j� Stretch$
 None=�5|       j� 
AlignmentX$
 Left=�5}      .��5~   &   5      5�      �� 5�   
   $��Center=�6   $��RightToLeft=�62   $ 
Horizontal=�6N   $��2��6g   .+�5�      �� -   5        $��0 0 0 10q�5�      $	��100��6(   $��40��64   $��
أضافه��6A   $��16(�6`   5�      5�      5�      5�      