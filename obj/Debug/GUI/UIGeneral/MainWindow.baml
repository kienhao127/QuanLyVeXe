   M S B A M L   `   `   `  ����E  AQuanLyVeXe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuanLyVeXe
QuanLyVeXe  5   	       QuanLyVeXe.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QuanLyVeXe     5   	     � Title$  
MainWindow��5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowState$ 	Maximized=�5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��50��6.   $	��Top=�6:   $��Right=�6R   .+�5      �� $��30(�6   $	��300��6$   $
��Left=�60   6M   �� 5      -   5         ��Name$ 
btnTimKiem��5   +   $��10, 0, 30, 0q�6   .��6X   Tìm kiếm6b   �� 5       �� CornerRadius$ 50��6    �� Padding$ 5q�6'   $	��100��63   $��50��6?   ._�5      �� -   5        $��btnDatVe��5      
������ $��0q�6Y   .��5      �� 
���   �$��14(�63   
ĐẶT VÉ6I   5      5      �� 5      $ 50��6   $ 5q�6'   $	��100��63   $��50��6?   ._�5      �� -   5        $��btnLichTrinh��5      
������ $��0q�6a   .��5      �� 
���   �$��14(�63   LỊCH TRÌNH6M   5      5      �� 5      -   5         ��Name$ borderDangKy��5   K   $ 50��6   $ 5q�6'   $	��100��63   $��50��6?   ._�5      �� -   5        $��	btnDangKy��5      
������ $��0q�6[   .��5      �� 
���   �$��14(�63   
ĐĂNG KÝ6J   5       5!      �� 5"      -   5        $ borderDangNhap��5"   K   $ 50��6   $ 5q�6'   $	��100��63   $��50��6?   ._�5#      �� -   5        $��btnDangNhap��5#      
������ $��0q�6_   .��5$      �� 
���   �$��14(�63   ĐĂNG NHẬP6L   5%      5&      �� 5'      -   5        	 ��Name$	 txtHello��5'   X   $��Center=�6   $��20(�63   $y�	Collapsed=�6A   
Xin chào:6v   �� 5(      -	   5        $	 txtFullname��5(   �   $��Center=�6   $��20(�63   $��Lương Kiên Hào��6A   $��Medium"�6W   $��10q�6k   $y�	Collapsed=�6w   
����� �6�   �� 5)      -
   5        $ btnThoat��5)      
�������$y�	Collapsed=�6Q   
�������$��10, 0q�6{   .��6�   THOÁT6�   5*       � 5+   
   -   5        
  �Name$

 Main��5+      $��1��6     � NavigationUIVisibility$ Hidden=�6+   $��10q�6K   5,      5-      