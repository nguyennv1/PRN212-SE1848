   M S B A M L   `   `   `  ����M  INguyenVanNguyenWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyenVanNguyenWPFNguyenVanNguyenWPF  5   	   &     NguyenVanNguyenWPF.ProductWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyenVanNguyenWPF     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ 	lvProduct��5
      $��	0,0,0,283q�6Q    �� View 5      �� 5      .P�5      �� $��Mã sản phẩm��6%    �� DisplayMemberBinding 6:   �� *Id+�� 5      $��Tên sản phẩm��6%    6;   �� *Name+�� 5      $��
Mã loại��6%    66   �� *
CategoryId+�� 5      $��Giá sản phẩm��6%    6;   �� *	UnitPrice+�� 5      $��	Trong kho��6%    68   �� *
UnitsStock+5      5      �� 5   
   $��Ma san pham��6   $
��Left=�6&   $��
79,170,0,0q�6A   $	��Top=�6U   �� 5   
   $��Ten san pham��6   $
��Left=�6'   $��78,0,0,0q�6B   $��Center=�6T   �� 5   
   $��
Mã loại��6   $
��Left=�6"   $��
79,240,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Giá Sản phẩm��6   $
��Left=�6'   $��
79,278,0,0q�6B   $	��Top=�6V   �� 5   
   $��	Trong kho��6   $
��Left=�6$   $��
79,321,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6!   $��205,174,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��	205,0,0,0q�6>   $
 Wrap=�6Q   $��Center=�6e   $	��120��6�   �� 5   
   -   5        $ txtCategoryId��5      $
��Left=�6)   $��205,248,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ txtUnitPrice��5      $
��Left=�6(   $��205,282,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ txtUnitsStock��5      $
��Left=�6)   $��205,325,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5!   
   -   5         ��Name$ btnSaveProduct��5!      $��Thêm sản phẩm��6)   $
��Left=�6A   $��205,374,0,0q�6\   $	��Top=�6q   ���	#FFA0FF9F$��32��6�   �� 5"   
   -   5        $ btnSua��5"      $��Sửa sản phẩm��6!   $
��Left=�68   $��335,374,0,0q�6S   $	��Top=�6h   $��96��6�   ���	#FFA1ECFC$��32��6�   �� 5#   
   -	   5        $ btnXoa��5#      $��Xóa sản phẩm��6!   $
��Left=�68   $��473,374,0,0q�6S   $	��Top=�6h   $��84��6�   ���	#FFFF4848$��32��6�   5&      5'      