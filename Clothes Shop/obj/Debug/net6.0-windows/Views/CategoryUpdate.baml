   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Clothes_Shop.ViewsClothes_Shop.Views  5   	   '    !Clothes_Shop.Views.CategoryUpdate   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Clothes_Shop.Views     5   	   $	��300��5      $	��400��6     � WindowStyle$
  None=�5	   
    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      (� .��5      � -   5         � RowDefinitions 5   
   �� 5      $��25 �6   5      �� 5      $	��200 �6   5      �� 5      $��* �6   5      ��5   
   �� 5      .��5      �  � Color$ #204da5��6    � Offset$	 0.0Q�6/   � 5      $ #6cc4d5��6   $ 1Q�6/   5       .+�5"   
   � $��0��6    � ColumnDefinitions 5$      �� 5&      $��25 �6#   �� 5'      $��25 �6#   �� 5(      $��* �6#   .+�5+      �� -   5         ��Name$ btnClose��5+      $��0q�5,      $��X��5-      
�������$��12(�5/      $��
Montserrat)�50      	 � Cursor$
	 Hand��51      $��0��52      ��55      �� 56      
 �� 
TargetType"
 ��6   .�57      ��  �� Property � �� �� Value �#DA34AE67    �� Triggers 58      P� 59       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5:   "   ��  � �� �#C62DAE6?   5;      5=      ��5?      �� 5@       �� 
TargetType" ��6&   .R�5A      �� $��18��6!   $��18��6,    �� CornerRadius$ 9��5B   )   #��z��5C   )   ._�5D      �� $��Center=�6/   $��Center=�5E   7   5F      5G      5I      �� 5J      -   5        $ btnMinimize��5J      $��0q�5K      $��-��5L      
�������$��16(�5N      $��
Montserrat)�5O      $
	 Hand��5P      $��1��5Q      ��5T      �� 5U      "
 ��6   .�5V      ��  � �� �#28AEED67    5W      P� 5X       �@J�IsMouseOver$
 True��6=   . �5Y   "   ��  � �� �#278BEF6?   5Z      5\      ��5_      �� 5`      " ��6&   .R�5a      �� $��18��6!   $��18��6,   $ 9��5b   )   #��z��5c   )   ._�5d      �� $��Center=�6/   $��Center=�5e   7   5f      5g      5j      5m      �� 5o   
   $��RightToLeft=�6    �� Orientation$ 
Horizontal=�61   $��1��6J   $��1��6W   .+�5s      �� $��أسم الفئه��6   
���   �$��20(�5u       $��Medium"�5v       $��
Montserrat)�5w       $��	5 15 10 0q�5x       $��40��5y       �� 5{      -   5         ��Name$ txtCategory��5{      $��40��5|      $��11(�5}      $��
 0 0 20 20q�5~      $	��250��5      .��6F   ��5�      �� 5�       j� Stretch$
 None=�5�       j� 
AlignmentX$
 Left=�5�      .��5�   &   5�      5�      �� 5�   
   $��Center=�6   $��RightToLeft=�62   $ 
Horizontal=�6N   $��2��6g   .+�5�      �� -   5        $��	0 0 0  10q�5�      $	��100��6)   $��40��65   $��
تعديل��6B   $��16(�6a   5�      5�      5�      5�      