   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Logowanie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ 	Logowanie��5
   	   $	��800��6   $
��1200��6(   .��5      ��  �� Padding$ 15q�6   ._�5   
   � $	��-15q�6   ��5      �� 5       �� ImageSource$0 *pack://siteoforigin:,,,/resources/ashe.jpg��6   .+�5      �� -   5        $��txtLogin��5      $��35(�6&   $��233,474,633,248q�64   
�������$��	Tw Cen MT)�6v   ��6M   Z� 6�   �� 5      $��	Password:��6   $��40(�6)   $��47,537,935,177q�67   
�������$��	Tw Cen MT)�6b    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5   &   G� 5      -   5        $��txtPassword��5      $��35(�6-   $��233,537,633,185q�6;   
�������$��	Tw Cen MT)�6}   ��6T   Z� 6�   �� 5      -   5        $��Sign in��5      $��40(�6'   $��233,614,633,60q�65   
�������$��	Tw Cen MT)�6w    5        5      ��5      �� 5      $3 -pack://siteoforigin:,,,/resources/button3.png��6!   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����67   �� 5        � �� 5!      �� 5"   "   	 �� 
TargetType"	 ��62   .R�5#   &   �� #��z��6-   
������ $��0q�6q   ._�5$   *   �� $��Center=�6;   $��Center=�6X   5%   '   5&   #   5(      
 �� Triggers
 5)      P� 5*       P� Property �@J�IsMouseOver P� Value . . �5+   "   ��  � ��
 ���� 6?   5,      5.      50      �� 51      -   5        $��Sign up��51      $��40(�6'   $��853,614,27,60q�65   
�������$��	Tw Cen MT)�6t    52        53      ��55      �� 56      $3 -pack://siteoforigin:,,,/resources/button3.png��6!   ��58      �� 59      " ��6   .�5:      ��  � ��
 �����67   �� 5;       � �� 5<      �� 5=   "   "	 ��62   .R�5>   &   �� #��z��6-   
������ $��0q�6q   ._�5?   *   �� $��Center=�6;   $��Center=�6X   5@   '   5A   #   5C      
 5D      P� 5E       �@J�IsMouseOver . . �5F   "   ��  � ��
 ���� 6?   5G      5I      5K      �� 5L      $
��Left=�6   $	��201��6/   $��
838,10,0,0q�6<   $	��Top=�6P   $	��346��6h   $5��/pack://siteoforigin:,,,/resources/TMF Logo3.png��6t   $
��Fill=�6�    5M        5N       J� OpacityMask 5P      �� 5Q      $5 /pack://siteoforigin:,,,/resources/TMF Logo3.png��6!   5S      �� 5T      $
��Left=�6   $��853,580,0,0q�63   $
��Wrap=�6H   $ ��You don't have an account?��6\   $	��Top=�6~   $��34��6�   $	��314��6�   $��24(�6�   $��	Tw Cen MT)�6�    �� TextAlignment$ Center=�6�   
������� 5U        5V      5X      �� 5Y      $
��Left=�6   $��95��6/   $��233,352,0,0q�6;   $	��Top=�6P   $	��328��6h   $1��+pack://siteoforigin:,,,/resources/login.png��6t    5Z        5[      5]      �� 5^      $��Login:��6   $��40(�6&   $��115,474,935,247q�64    J� RenderTransformOrigin$ 
0.93,0.482&�6M   
�������$��	Tw Cen MT)�6�    5_        5`      5a   &   5b      5c      5d      