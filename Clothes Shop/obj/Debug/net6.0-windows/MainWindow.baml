   M S B A M L   `   `   `  ����G  CClothes Shop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Clothes_ShopClothes_Shop  5   	   ;"clr-namespace:MyProject.ViewModelsMyProject.ViewModels  5   	   1clr-namespace:MyProject.ViewsMyProject.Views  5   	       Clothes_Shop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Clothes_Shop     5   	   9
viewmodels"clr-namespace:MyProject.ViewModels     5   	   /viewsclr-namespace:MyProject.Views     5   	   -   5          � Title$
  Home��5
   	   $	��700��6   $	��900��6#    � AllowsTransparency$ False��5      
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5       �� DataType,   &MyProject.ViewModels.ProductViewModels!   MyProject.Views.ProductView � DataContext-   'MyProject.ViewModels.CategoryViewModels"   MyProject.Views.CategoryView��%�   (��       5   4   *, +)(�� X     5   5   *, +)�� 5   
   productViewTemplate��"  64   .R�5         6    �� 5      �� 5   
   categoryViewTemplate��"  65   .R�5         6!   �� 5      5      .��5      � .+�5   
   �� ��5      �� 5      .��5      �  � Color$ #204da5��6#   	 � Offset$		 0.0Q�63   � 5      $ #6cc4d5��6#   $	 1Q�63   5      5       ]� 5!   
   .+�5"      (� $��Right=�6   .��5#      � -   5        
 �Name$
 	sidePanel��5#      $��Right=�6+   $	��130��6G   .+�5$      �� ���#204da5.+�5%      � $��30��6   ���#204da5$��0 0 0 40q�6@    � ColumnDefinitions 5&      �� 5'   "   $��35 �63   6@   �� 5(   "   $��* �63   6?   .+�5*      �� -   5        $��0��5*   %   $
��Left=�65   $��5 5 0 0q�6P   $��20��6a   $	��Top=�6m   
������ 
������ .��5+   "   �� $��images/menu_80px.png��6(   5,      �� 5-      -   5         ��Name$
 User��5-   �   $��Century Gothic)�6(   $��10(�6D   
�������
������ $
��Bold"�6   $��1��6�   $��Center=�6�   $��Center=�6�   6  5.      �� 5/      $��Disabled=�6#   $��Century Gothic)�6Y   $��14(�6u   
�������
������ 
������ $
��Bold"�6�   .@�50      �� -   5        $��30��50   +   .��51   "   ��  �� Orientation$ 
Horizontal=�6-   .+�52   &   �� $'��!images/iconmonstr-cube-18-240.png��6,   $��20��6W   $��Center=�6c   �� 53   &   $��15 0 0 0q�60   $��الفئات��6B   $��Center=�6P   54   #   55      �� 56      -   5        $��30��56   +   $��0 20 0 0q�67   .��57   "   �� $ 
Horizontal=�6-   .+�59   &   �� $��images/carCategory.png��6,   $��20��6L   $��Center=�6X   �� 5:   &   $��15 0 0 0q�60   $��المنتجات��6B   $��Center=�6R   5;   #   5<      �� 5?      -   5        $��30��5?   +   $��	0 150 0 0q�67   .��5@   "   �� $ 
Horizontal=�6-   .+�5A   &   �� $*��$images/iconmonstr-log-out-10-240.png��6,   $��20��6Z   $��Center=�6f   �� 5B   &   $��15 0 0 0q�60   $��تسجيل خروج��6B   $��Center=�6T   5C   #   5D      5E      5F      5G      5H      � 5I      -   5        $
 	homePanel��5I      $
��Left=�6'   .+�5K      ]� .+�5L      � -	   5        $
 panelHeader��5L      $	��Top=�60   $��50��6H   $	��Top=�6T   .+�5M      �� -
   5        $
��Left=�5M   !   $��5 5 0 0q�6<   $��30��6M   $	��Top=�6Y   
������ 
������ .��5N      �� $��images/cancel_80px.png��6$   5P      �� 5Q      -   5        $
��Left=�5Q   !   $��45 5 0 0q�6<   $��30��6N   $	��Top=�6Z   
������ 
������ .��5R      �� $%��images/maximize_window_80px.png��6$   5S      �� 5U      -   5        $
��Left=�5U   !   $��85 5 0 0q�6<   $��30��6N   $	��Top=�6Z   
������ 
������ .��5V      �� $%��images/minimize_window_80px.png��6$   5X      5Y      ]� 5Z      $��Bottom=�6    .+�5^      �� ��6)   �� 5`      5a      5b      5c      5d      5e      