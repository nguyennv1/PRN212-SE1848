   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Product Management��5
   	   $	��670��6$   $	��710��61   .��5      � .+�5   
   � ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #0099FF��6#    � Offset$ 0Q�63   � 5      $ 	#FF347BDA��6#   $ 0.794Q�65   � 5      $ 	#FF60B1E7��6#   $ 1Q�65   � 5      $ 	#FF596FDD��6#   $ 0.309Q�65   � 5      $ 	#FF472FDE��6#   $ 0.484Q�65   5       � RowDefinitions 5      �� 5      $��60 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��* �6    �� 5      $��30 �6     � ColumnDefinitions 5"      �� 5#      $��119.415 �6#   �� 5$      $��30.585 �6#   �� 5%      $	��47* �6#   �� 5&      $
��513* �6#   .+�5)      �� -   5         ��Name$ label��5)      $��Product Management��6#   $��2��6@   $��0��6P   $��36(�6]   $��2��6k   $��Center=�6   $	��466��6�   �� 5+      -   5        $ label1��5+      $��2,2,2,2q�6$   $��
Product ID��67   $��0��6L   $��1��6\   $��2��6i   �� 5,      -   5        	 ��Name$	 txtProductID��5,      $��4,4,4,4q�6,   $��2��6>   $��1��6N   $�� ��6[   
 �� TextWrapping$

 Wrap=�6c   $��2��6w   ${�False��6�   �� 5.      -   5        $ label2��5.      $��2,2,2,2q�6$   $��0��66   $��2��6F   $��Product Name��6S   $��2��6j   �� 5/      -   5        $	 txtProductName��5/      $��4,4,4,4q�6.   $��2��6@   $��2��6P   $�� ��6]   $

 Wrap=�6e   $��2��6y   �� 51      -   5        $ label8��51      $��2,2,2,2q�6$   $��Price��66   $��0��6F   $��3��6V   $��2��6c   �� 52      -   5        $	 txtPrice��52      $��4,4,4,4q�6)   $��2��6;   $��3��6K   $�� ��6X   $

 Wrap=�6`   $��2��6t   �� 54      -	   5        $ label3��54      $��2,2,2,2q�6$   $��Units In Stock��66   $��0��6O   $��4��6_   $��2��6l   �� 55      -
   5        $	 txtUnitsInStock��55      $��4,4,4,4q�6/   $��2��6B   $��4��6R   $�� ��6`   $

 Wrap=�6h   $��2��6|   �� 57      -   5        $ label4��57      $��2,2,2,2q�6$   $��Category��66   $��0��6I   $��5��6Y   $��2��6f   �� 58      -   5         ��Name$ cboCategory��58      $��4,4,4,4q�6,   $��2��6>   $��5��6N   $��2��6[   &   System.Windows.Controls.DataGrid  5;      -   5          Name$ dgData��5;      $��4,4,4,63q�6'   $��2��6:   $��6��6J   $��2��6W   6k   �� 5<      -   5         ��Name$ 	btnCreate��5<      $��Create��6)   $
��Left=�6:   $��29,365,0,16q�6U   $��6��6j   $��2��6w   $	��121��6�   ���	#FF0099FF
�������
�������$��3��6�   $��1��6�   6�   �� 5=      -   5        $ 	btnUpdate��5=      $��Update��6(   $��3��69   $
��Left=�6I   $��87,365,0,16q�6d   $��6��6y   $	��118��6�   ���	#FF1B7140
�������$��2��6�    J� RenderTransformOrigin$ 0.37,0.2&�6�   6�   �� 5>      -   5        $ 	btnDelete��5>      $��Delete��6(   $��3��69   $
��Left=�6I   $��221,365,0,16q�6d   $��6��6z   $��2��6�   $	��127��6�   
����������	#FFA2AA3D6�   �� 5@      -   5        $ btnClose��5@      $��Close��6'   $��3��67   $
��Left=�6G   $��371,365,0,18q�6b   $��6��6x   $��2��6�   $	��120��6�   ���	#FFEF8F18
�������6�   5B      5C      5D      