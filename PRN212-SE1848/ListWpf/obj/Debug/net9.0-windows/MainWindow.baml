   M S B A M L   `   `   `  ����B  >ListWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ListWPFListWPF  5   	       ListWPF.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ListWPF     5   	     � Title$:  4(SE180746 Nguyễn Văn Nguyên)Thao tác trên List��5   	   $	��420��6@   $	��480��6M   .��5	      � .+�5
   
   �� -   5         ��Name$ 	txtGiaTri��5
      $
��Left=�5      $��23��6-   $��	17,10,0,0q�5       �� TextWrapping$
 Wrap=�6%   $	��Top=�5      $��98��6*   �� 5   
   -   5         ��Name$ btnThem��5      $��Thêm vào List��6"   $
��Left=�5      $��
127,13,0,0q�6,   $	��Top=�5      $	��115��6)   65   �� 5   
   -   5         ��Name$ 	lstDuLieu��5       �� SelectionMode$ Multiple=�6%   $
��Left=�5      $	��275��6-   $��	15,38,0,0q�5      $	��Top=�6%   $	��100��5      �� 5   
   $��Giá trị:��6   $
��Left=�6#   $��
127,45,0,0q�5      $	��Top=�6$   �� 5   
   -   5        $ txtGiaTriChen��5      $
��Left=�5      $��23��6-   $��
176,48,0,0q�5      $
 Wrap=�6&   $	��Top=�5      $��66��6*   �� 5    
   $��
Vị trí:��6   $
��Left=�6"   $��
127,73,0,0q�5!      $	��Top=�6$   �� 5#   
   -   5        $ txtViTriChen��5#      $
��Left=�5$      $��23��6-   $��
176,76,0,0q�5%      $
 Wrap=�6&   $	��Top=�5&      $��66��6*   �� 5(   
   -   5        $ btnChen��5(      $��Chèn��6"   $
��Left=�5)      $��176,111,0,0q�6,   $	��Top=�5*      $��66��6)   64   �� 5,   
   -   5        $ btnSapXepTang��5,      $��Sắp xếp tăng��6(   $
��Left=�5-      $��127,143,0,0q�6,   $	��Top=�5.      $	��115��6)   65   �� 50   
   -   5        $ btnSapXepGiam��50      $��Sắp xếp giảm��6(   $
��Left=�51      $��127,180,0,0q�6,   $	��Top=�52      $	��115��6)   65   �� 54   
   -	   5        $ btnXoa1PhanTu��54      $��Xóa 1 phần tử��6(   $
��Left=�55      $��127,220,0,0q�6,   $	��Top=�56      $	��115��6)   65   �� 58   
   -
   5        $ btnXoaNhieuPhanTu��58      $��Xóa nhiều phần tử��6,   $
��Left=�59      $��127,256,0,0q�6,   $	��Top=�5:      $	��115��6)   65   �� 5<   
   -   5        $ btnXoaToanBoPhanTu��5<      $!��Xóa toàn bộ phần tử��6-   $
��Left=�5=      $��127,293,0,0q�6,   $	��Top=�5>      $	��115��6)   65   5?      5@      