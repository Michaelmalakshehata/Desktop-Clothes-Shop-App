   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyProject.ViewsMyProject.Views  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null4%clr-namespace:DAL.Models;assembly=DAL
DAL.Models 5      "    MyProject.Views.CategoryView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MyProject.Views     5      8Models%clr-namespace:DAL.Models;assembly=DAL     5      .��5      (� .��5   
   � -   5          � RowDefinitions  5      �� 5      $��80 �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��70 �6#   �� 5      $��* �6#   ��5      �� 5      .��5      �  � Color$ #204da5��6#    � Offset$	 0.0Q�63   � 5      $ #6cc4d5��6#   $ 1Q�63   5      .+�5      �� $��15q�6   $��RightToLeft=�6%    �� Orientation$ 
Horizontal=�6A   $��0��6Z   $��1��6g   .+�5"      �� $��بحث الفئه��6   
���   �$��12(�5$       $��Medium"�5%       $��
Montserrat)�5&       $��0 25 0 0q�5'       $��14��5(        J� RenderTransformOrigin$ 0.521,0.612&�6,   �� 5*      -   5         ��Name$ search��5*      $��38��5+      $��	 10 0 0 0q�5,      $	��200��5-      .��6B   ��5.      �� 5/       j� Stretch$
 None=�50   )    j� 
AlignmentX$
 Left=�51   )   .��52   *   53      54      �� 55      $��	10 0 0 20q�6   $ Vertical=�6-   $��1��6D   $��0��6Q   .+�57      �� -   5        $
��Left=�57      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��
أضافه��6]   6m   �� 58      -   5        $
��Left=�58      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��
تعديل��6]   6m   �� 59      -   5        $
��Left=�59      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��حذف��6]   6k   �� 5:      -   5        $
��Left=�5:      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��التفاصيل��6]   6p   �� 5;      -   5        $
��Left=�5;      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $�� المهملات��6]   6q   �� 5<      -   5        $
��Left=�5<      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $�� تنشيط��6]   6n   5>      &   System.Windows.Controls.DataGrid  5@      -	   5        	  Name$	 categoryData��5@      $��RightToLeft=�6-   
   AutoGenerateColumns$
 False��6I   $��1��6e   $��1��6r   $	��200��6�   $	��380��6�      
IsReadOnly$
 True��5B         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6%      Header$ 
الكود��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+6X     5G      $	 120 6)   $ أسم الفئه��65    6H   �� *Name+6c     5H      $	 105 6)   $ تاريخ الانشاء��65    6L   �� *
CreateDate+6m     5I      $	 100 6)   $ أسم المنشئ��65    6I   �� *CreateUserName+6n     5J      $	 105 6)   $ تاريخ التعديل��65    6L   �� *
UpdateDate+6m     5K      $	 100 6)   $ أسم المعدل��65    6I   �� *UpdateUserName+6n     5L      $	 105 6)   $ تاريخ المسح��65    6J   �� *
DeleteDate+6k     5M      $	 100 6)   $ أسم الماسح��65    6I   �� *DeleteUserName+6n     5N      $	 105 6)   $  تاريخ الاعاده ��65    6M   �� *RestoreDate+6o     5O      $	 100 6)   $ أسم المعيد��65    6I   �� *RestoreUserName+6o   5R      5S      5T      5V      