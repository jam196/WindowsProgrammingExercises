   M S B A M L   `   `   `  ����X  TWindows_Programming_Exercises, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Windows_Programming_Exercises.Views#Windows_Programming_Exercises.Views  5      /    )Windows_Programming_Exercises.Views.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Windows_Programming_Exercises.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.2.0.2657, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   �� $
��Auto=�6   $��Disabled=�6:   .��5      �   � 	Resources  5      '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property �� Value��%v   '        �� 5      "  6   .�5      ��  � ��$ 30��62   �� 5       � ��$ 30��63   5      5      .+�5      � $��0��6   ���#F6F6F8.+�5      �� $��10q�6!    �� Orientation$ Vertical=�6-   .+�5      � $��60��6   .+�5      ��  &  "MaterialDesignFloatingActionButton#��[  6%   $
��Left=�6a   ��5   !   Z� ��68   Z� .��5   "   �� $��-5q�6-   .+�5   &        Kind$ ReorderHorizontal=�6>   
�������6W   5   #   5      5      � 5      $
��Left=�6$    � Orientation$ 
Horizontal=�6?   .+�5      �� 
�������$��5q�69   $��20 20q�6M    �� CornerRadius$ 15��6\   ._�5   "   #  MaterialDesignThemes.Wpf.Card  +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�66   	   UniformCornerRadius$	 15Q�5    2   $��5q�5!   2   
�������$	��480��5"   F   $	��500��6R   ���#F6F6F8.��5#   &   �� $��10q�61   $
��Left=�6=   $	��480��6X   .+�5$   *   �� $��35,16,331,16q�5%   )   $��16(�5&   )   $
��Bold"�5'   -   Thêm sinh viên5)   +   � 5*   *   
 � ColumnDefinitions
 5+   .   �� 5,   2   $��3* �6C   �� 5-   2   $��1* �6C   .+�5/   .   �� $��0��69   $��	0,0,0,-96q�6I   .+�50   2   �� -   5        $��MaSVTxt��50   :   $��Center=�6I   $��Center=�51   6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã sinh viên��52   6     MaterialDesignTextBox#��[ 53   6   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ��  �$	��245��54   k   $��17,16,58,16q�55   6   $��33��56   6   $��16(�6B   �� 57   2   -   5        $��HoDemTxt��57   :   $��Center=�6J   $��Center=�58   6   $ Họ đệm��59   6   #��[ 5:   6   
 ��  �$	��245��5;   k   $��17,16,58,16q�5<   6   $��33��5=   6   $��16(�6B   �� 5>   2   -   5        $��TenSVTxt��5>   :   $��Center=�6J   $��Center=�5?   6   $
 Tên��5@   6   #��[ 5A   6   
 ��  �$	��245��5B   k   $��17,16,58,16q�5C   6   $��33��5D   6   $��16(�6B   (  "System.Windows.Controls.DatePicker  5E   2   -   5        $��NgaySinhTxt��5E   =   $��16(�6P   $��35��6^   $	��245��6j    � Language$ vi-VN�5F   6   $��Center=�5G   6   $��17,16,58,16q�5H   6   $ 
Ngày sinh��5I   6   
 ��  �   SelectedDate 5K   6   �� *
NgaySinh+ �� Mode$ TwoWay=��� 5L   2   -   5        $��GioiTinhTxt��5L   ;   $ Giới tính��6N   $��16(�6y   $��35��6�   $��37,16,78,16q�6�   .@�5M   6   �� $	��Nam��6C   �� 5N   6   $
��Nữ��6C   5O   3   �� 5P   2   -   5        $��MaLopTxt��5P   ;    �� DisplayMemberPath$ MaLop��6K   $ 	Mã lớp��6e    �� SelectedValuePath$ MaLop��6�   $��16(�6�   $��35��6�   $��37,16,78,16q�6�   5Q   /   �� 5S   .   $��1��69   $��Center=�6I   $
��Left=�6d   .+�5T   2   �� -   5        #��[  5U   9   ���#0d47a1���#0d47a1��5V   N   Z� .��5X   6   �� $��0q�6A   .+�5Y   :     
�������$	 Add=�6e   5Z   7   5[   3   5\   /   5]   +   5_   '   5`   #   5a      �� 5b      
�������$��5q�69   $��20 20q�6M   $ 15��6\   ._�5c   "     $ Depth0=�66   $	 15Q�5d   2   $��5q�5e   2   
�������$	��480��5f   F   $	��500��6R   ���#F6F6F8.��5g   &   �� $��10q�61   $
��Left=�6=   $	��480��6X   .+�5h   *   �� $��35,16,331,16q�5i   )   $��16(�5j   )   $
��Bold"�5k   -   Sửa sinh viên5m   +   � 5n   *   
 5o   .   �� 5p   2   $��3* �6C   �� 5q   2   $��1* �6C   .+�5s   .   �� $��0��69   $��	0,0,0,-96q�6I   .+�5t   2   �� -   5        $��MaSVTxt1��5t   h   $ Mã sinh viên��6x   $ 
MaSinhVien��6�   $ 
MaSinhVien��6�   $��16(�6�   $��35��6�   $��37,16,78,16q�6�   �� 5u   2   -	   5        $��	HoDemTxt1��5u   :   $��Center=�6K   $��Center=�5v   6   $ Họ đệm��5w   6   #��[ 5x   6   
 ��  �$	��245��5y   k   $��17,16,58,16q�5z   6   $��33��5{   6   $��16(�6B   �� 5|   2   -
   5        $��	TenSVTxt1��5|   :   $��Center=�6K   $��Center=�5}   6   $
 Tên��5~   6   #��[ 5   6   
 ��  �$	��245��5�   k   $��17,16,58,16q�5�   6   $��33��5�   6   $��16(�6B     5�   2   -   5        $��NgaySinhTxt1��5�   =   $��16(�6Q   $��35��6_   $	��245��6k   $ vi-VN�5�   6   $��Center=�5�   6   $��17,16,58,16q�5�   6   $ 
Ngày sinh��5�   6   
 ��  � 5�   6   �� *
NgaySinh+$ TwoWay=��� 5�   2   -   5        $��GioiTinhTxt1��5�   ;   $ Giới tính��6O   $��16(�6z   $��35��6�   $��37,16,78,16q�6�   .@�5�   6   �� $	��Nam��6C   �� 5�   6   $
��Nữ��6C   5�   3   �� 5�   2   -   5        $��	MaLopTxt1��5�   ;   $ MaLop��6L   $ 	Mã lớp��6f   $ MaLop��6�   $��16(�6�   $��35��6�   $��37,16,78,16q�6�   5�   /   �� 5�   .   $��1��69   $��Center=�6I   $
��Left=�6d   .+�5�   2   �� -   5        #��[  5�   9   ���#1b2a4e���#1b2a4e��5�   N   Z� .��5�   6   �� $��0q�6A   .+�5�   :     
�������$
 Edit=�5�   =   5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   5�      �� 5�      
�������$��5q�69   $��20 20q�6M   $ 15��6\   ._�5�   "     $ Depth0=�66   $	 15Q�5�   2   $��5q�5�   2   
�������$	��480��5�   F   $	��200��6R   ���#F6F6F8.��5�   &   �� $��10q�61   $
��Left=�6=   $	��480��6X   .+�5�   *   �� $��35,16,331,16q�5�   )   $��16(�5�   )   $
��Bold"�5�   -   Xóa sinh viên5�   +   � 5�   *   
 5�   .   �� 5�   2   $��3* �6C   �� 5�   2   $��1* �6C   .+�5�   .   �� $��0��69   $��	0,0,0,-96q�6I   .+�5�   2   �� -   5        $��MaSVTxt2��5�   ;   $ Mã sinh viên��6K   $ 
MaSinhVien��6y   $ 
MaSinhVien��6�   $��16(�6�   $��35��6�   $��37,16,78,16q�6�   5�   /   �� 5�   .   $��1��69   $��Center=�6I   $
��Left=�6d   .+�5�   2   �� -   5        #��[  5�   9   ���#df4759���#df4759��5�   N   Z� .��5�   6   �� $��0q�6A   .+�5�   :     
�������$ Delete=�5�   =   5�   7   5�   3   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      