   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Clothes_Shop.ViewsClothes_Shop.Views  5   	   (    "Clothes_Shop.Views.CategoryDeleted   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Clothes_Shop.Views     5   	     � WindowStyle$
  None=�5	   
    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      (� .��5      � -   5         � RowDefinitions 5   
   �� 5      $��25 �6    6.   �� 5      $��80 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   ��5   
   �� 5      .��5      �  � Color$ #204da5��6    � Offset$	 0.0Q�6/   � 5      $ #6cc4d5��6   $ 1Q�6/   5       .+�5"      � $��0��6    5$      �� 5&      $��25 �6'   �� 5'      $��25 �6'   �� 5(      $��* �6'   .+�5+      �� -   5         ��Name$ btnClose��5+      $��0q�5,      $��X��5-      
�������$��12(�5/      $��
Montserrat)�50      	 � Cursor$
	 Hand��51      $��0��52      ��55      �� 56      
 �� 
TargetType"
 ��6    .�57      ��  �� Property � �� �� Value �#DA34AE6;    �� Triggers 58      P� 59   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5:   &   ��  � �� �#C62DAE6C   5;   #   5=      ��5?      �� 5@       �� 
TargetType" ��6*   .R�5A      �� $��18��6%   $��18��60    �� CornerRadius$ 9��5B   )   #��z��5C   )   ._�5D   "   �� $��Center=�63   $��Center=�6N   5E      5F      5H      �� 5I      -   5        $ btnMinimize��5I      $��0q�5J      $��-��5K      
�������$��16(�5M      $��
Montserrat)�5N      $
	 Hand��5O      $��1��5P      ��5S      �� 5T      "
 ��6    .�5U      ��  � �� �#28AEED6;    5V      P� 5W   "    �@J�IsMouseOver$
 True��6A   . �5X   &   ��  � �� �#278BEF6C   5Y   #   5[      ��5^      �� 5_      " ��6*   .R�5`      �� $��18��6%   $��18��60   $ 9��5a   )   #��z��5b   )   ._�5c   "   �� $��Center=�63   $��Center=�5d   7   5e      5f      5i      5j      �� 5k      $��15q�6   $��RightToLeft=�6%    �� Orientation$ 
Horizontal=�6A   $��1��6Z   $��1��6g   .+�5l      �� $��بحث الفئه��6   
���   �$��12(�5n       $��Medium"�5o       $��
Montserrat)�5p       $��0 20 0 0q�5q       $��14��5r        J� RenderTransformOrigin$ 0.521,0.612&�6,   �� 5t      -   5         ��Name$ search��5t      $��38��5u      $��	 10 0 0 0q�5v      $	��200��5w      .��6B   ��5x      �� 5y       j� Stretch$
 None=�5z       j� 
AlignmentX$
 Left=�5{      .��5|   &   5}      5~      �� 5      $��	10 0 0 20q�6   $ Vertical=�6-   $��2��6D   $��0��6Q   .+�5�      �� -   5        $
��Left=�5�      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��أسترجاع��6]   6o   �� 5�      -   5        $
��Left=�5�      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��التفاصيل��6]   6p   �� 5�      -   5        $
��Left=�5�      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��
تنشيط��6]   6m   5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ categoryData��5�      $��RightToLeft=�6)      AutoGenerateColumns$ False��6E   $��2��6a   $��2��6n   $	��200��6~   $	��380��6�      
IsReadOnly$
 True��5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6%      Header$ 
الكود��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+6X     5�      $	 120 6%   $ أسم الفئه��61    6D   �� *Name+6_     5�      $	 105 6)   $ تاريخ الانشاء��65    6L   �� *
CreateDate+6m     5�      $	 100 6)   $ أسم المنشئ��65    6I   �� *CreateUserName+6n     5�      $	 105 6)   $ تاريخ التعديل��65    6L   �� *
UpdateDate+6m     5�      $	 100 6)   $ أسم المعدل��65    6I   �� *UpdateUserName+6n     5�      $	 105 6)   $ تاريخ المسح��65    6J   �� *
DeleteDate+6k     5�      $	 100 6)   $ أسم الماسح��65    6I   �� *DeleteUserName+6n     5�      $	 105 6)   $  تاريخ الاعاده ��65    6M   �� *RestoreDate+6o     5�      $	 100 6)   $ أسم المعيد��65    6I   �� *RestoreUserName+6o   5�      5�      5�      5�      