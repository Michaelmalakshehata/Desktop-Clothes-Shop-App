   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyProject.ViewsMyProject.Views  5      !    MyProject.Views.ProductView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MyProject.Views     5      .��5	      (� .��5
   
   � -   5          � RowDefinitions  5      �� 5      $��80 �6    5      �� 5      $��* �6    5       � ColumnDefinitions 5      �� 5      $��70 �6#   5      �� 5      $��* �6#   5      ��5      �� 5      .��5      �  � Color$ #204da5��6#    � Offset$	 0.0Q�63   � 5      $ #6cc4d5��6#   $ 1Q�63   5      .+�5      �� $��15q�6   $��RightToLeft=�6%    �� Orientation$ 
Horizontal=�6A   $��0��6Z   $��1��6g   .+�5#      �� $��بحث المنتج��6   
���   �$��12(�5%       $��Medium"�5&       $��
Montserrat)�5'       $��0 20 0 0q�5(       $��14��5)        J� RenderTransformOrigin$ 0.521,0.612&�6,   �� 5+      -   5         ��Name$ search��5+      $��38��5,      $��	 10 0 0 0q�5-      $	��200��5.      .��6@   ��5/      �� 50       j� Stretch$
 None=�51   !    j� 
AlignmentX$
 Left=�52   !   .��53   *   54      55      �� 56      $��	10 0 0 20q�6   $ Vertical=�6-   $��1��6D   $��0��6Q   .+�58      �� -   5        $
��Left=�58      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $��
أضافه��6k   6{   �� 59      -   5        $
��Left=�59      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $��
تعديل��6k   6{   �� 5:      -   5        $
��Left=�5:      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $��حذف��6k   6y   �� 5;      -   5        $
��Left=�5;      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $��التفاصيل��6k   6~   �� 5<      -   5        $
��Left=�5<      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $�� المهملات��6k   6   �� 5=      -   5        $
��Left=�5=      $��0 20 0 0q�64   $��50��6F   $��20��6Q   $��13(�6]   $�� تنشيط��6k   6|   5?      &   System.Windows.Controls.DataGrid  5A      -	   5        	  Name$	 productgrid��5A      $��RightToLeft=�6,   
   AutoGenerateColumns$
 False��6H   $��2��6d   $��2��6q   $	��200��6�   $	��440��6�      
IsReadOnly$
 True��5C      $��8(�5D         Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 35 6)      Header$ 
الكود��64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+6\     5H      $ 63 6)   $ أسم المنتج��64    6H   �� *Name+6c     5I      $ 40 6)   $ 
السعر��64    6C   �� *Price+6_     5J      $ 70 6)   $ التفاصيل��64    6F   �� *
Detailes+6e   4  .System.Windows.Controls.DataGridTemplateColumn  5L      $ الصوره��6.   $ 70 6>      CellTemplate 5M      �� 5N      .R�5O   "   ��  ��Name$ productimage��6(   $��60��6\   $��60��6h   ��6>   �� *
ProductImg+6h   5P      5R        5S      $ 40 6)   $ كود الفئه��64    6G   �� *
CategoryId+6h     5T      $	 105 6)   $ تاريخ الانشاء��65    6L   �� *
CreateDate+6m     5U      $	 100 6)   $ أسم المنشئ��65    6I   �� *CreateUserName+6n     5V      $	 105 6)   $ تاريخ التعديل��65    6L   �� *
UpdateDate+6m     5W      $	 100 6)   $ أسم المعدل��65    6I   �� *UpdateUserName+6n     5X      $	 105 6)   $ تاريخ المسح��65    6J   �� *
DeleteDate+6k     5Y      $	 100 6)   $ أسم الماسح��65    6I   �� *DeleteUserName+6n     5Z      $	 105 6)   $  تاريخ الاعاده ��65    6M   �� *RestoreDate+6o     5[      $	 100 6)   $ أسم المعيد��65    6I   �� *RestoreUserName+6o   5^      5_      5`      5b      