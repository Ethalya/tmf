   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ 
MainWindow��5
   	   $	��800��6   $
��1200��6)   .��5      ��  �� Padding$ 15q�6   ._�5   
   � $	��-15q�6    � ColumnDefinitions 5      �� 5      $	��32* �6#   �� 5      $��1029* �6#   �� 5      $
��131* �6#   ��5      �� 5       �� ImageSource$2 ,pack://siteoforigin:,,,/resources/Soraka.jpg��6   .+�5      �� $%��Are you looking for a Teammate?��6   $��40(�6?    �� TextAlignment$ Center=�6M   $��12,275,420.503,423q�6d   
�������$��	Tw Cen MT)�6�   $	��628��6�   $��2��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5   &   �� 5      $��60(�6   $ Center=�6&   $��10,329,419.503,329q�6=   
�������$��	Tw Cen MT)�6l   $��2��6�    5        5      �� 5   %   $�Sign ��6)   �� 68   $�up��6<   �� 6H   $� ��6L   �� 6W   $
�now!��6[   6j   �� 5      -   5        $��123,562,579.503,105q�5      $��Sign up��6I   $��40(�6[   
�������$��	Tw Cen MT)�6�   $��1��6�   ��6|   Z�  5        5          Opacity$	 0.5Q�6'   	   	Direction$		 313Q�65   ��5"      �� 5#      $3 -pack://siteoforigin:,,,/resources/button1.png��6!   ��5%      �� 5&      
 �� 
TargetType"
 ��6   .�5'      ��  �� Property � �� �� Value
 �����67   �� 5(       � �� 5)      �� 5*   "    �� 
TargetType" ��62   .R�5+   &   �� #��z��6-   
������ $��0q�6q   ._�5,   *   �� $��Center=�6;   $��Center=�6X   5-   '   5.   #   50       �� Triggers 51      P� 52       P� Property �@J�IsMouseOver P� Value . . �53   "   ��  � ��
 ���� 6?   54      56      58      �� 59      -   5        $��123,445,579.503,223q�59      $��Login��62   $��40(�6B   
�������$��	Tw Cen MT)�6z   $��1��6�   $��0q�6�   ��6�   Z�  5:        5;      $	 0.5Q�6'   ��5=      �� 5>      $3 -pack://siteoforigin:,,,/resources/button1.png��6!   ��5@      �� 5A      "
 ��6   .�5B      ��  � ��
 �����67   �� 5C       � �� 5D      �� 5E   "   " ��62   .R�5F   &   �� #��z��6-   
������ $��0q�6q   ._�5G   *   �� $��Center=�6;   $��Center=�6X   5H   '   5I   #   5K       5L      P� 5M       �@J�IsMouseOver . . �5N   "   ��  � ��
 ���� 6?   5O      5Q      5S      �� 5T      $
��Left=�6   $	��258��6/   $��	73,36,0,0q�6<   $	��Top=�6O   $	��559��6g   $5��/pack://siteoforigin:,,,/resources/TMF Logo2.png��6s   $��1��6�   5U      5V      5W      5X      