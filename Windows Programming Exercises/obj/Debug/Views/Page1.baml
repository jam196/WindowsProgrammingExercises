   M S B A M L   `   `   `  ����X  TWindows_Programming_Exercises, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Windows_Programming_Exercises.Views#Windows_Programming_Exercises.Views  5      /    )Windows_Programming_Exercises.Views.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:Windows_Programming_Exercises.Views     5      b ^MaterialDesignThemes.Wpf, Version=4.2.0.2657, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6N   .��5      � .+�5	   
   �� $
��Auto=�6   $��Disabled=�6:   .��5
      �   � 	Resources  5      '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property �� Value��%v   '        �� 5      "  6   .�5      ��  � ��$ 30��62   �� 5       � ��$ 30��63   5      5      .+�5      � $��0��6   ���#F6F6F8.+�5      �� $��10q�6!    �� Orientation$ Vertical=�6-   .+�5      � $��60��6   .+�5      ��  &  "MaterialDesignFloatingActionButton#��[  6%   $
��Left=�6a   ��5   !   Z� ��68   Z� .��5   "   �� $��-5q�6-   .+�5   &        Kind$ ReorderHorizontal=�6>   
�������6W   5   #   5      5      � 5      $��Center=�6$    � Orientation$ Vertical=�6A   .+�5      � $��Center=�6(   $ 
Horizontal=�6E   .+�5   "   �� -   5        $��Danh Sách Sinh Viên��5   )   $	��500��6G   $
��10 0q�6h   �� 5   "   -   5        $��Danh Sách Lớp��5   )   $	��500��6A   $
��10 0q�6M   6[   5      � 5       $
��Left=�6(   $ 
Horizontal=�6C   .+�5!   "   �� -   5        $��SoDVHT��5!   *   $��Center=�68   $��Center=�5"   6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập số DVHT��5#   6     MaterialDesignTextBox#��[ 5$   6   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 ��  �$	��205��5%   k   $��16q�5&   6   $��33��5'   6   $��16(�6B   �� 5(   "   -   5        $+��%Lấy danh sách môn lọc theo DVHT��5(   )   $	��250��6S   $
��10 0q�6_   6m   �� 5)   "   -   5        $��	Combobox1��5)   +   	 �� DisplayMemberPath$	 MaLop��6<   
 �� SelectedValuePath$
 MaLop��6V   $	��200��6p   $
��Left=�6|   $
��20 0q�6�   �� 5*   "   -   5        $0��*Lấy danh sách sinh viên theo mã lớp��5*   )   $	��280��6W   6c   5+      &   System.Windows.Controls.DataGrid  5,      -   5        $��Table1��5,   '   $
��1020��6]   $
��0 20q�6j      AutoGenerateColumns . ��65   ��  �� Path$ 
DataTable1�6x   5-      5.      5/      50      51      52      53      