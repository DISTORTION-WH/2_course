   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Choose   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Choose��5	       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! local:CustomCommand.InStock��5      6Z     5   
   -   5        $" local:CustomCommand.OutStock��5      6\     5   
   -   5        $# local:CustomCommand.ShowPrice��5      6Z    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Dictionary1.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��76* �6   �� 5      $	��60* �6   �� 5      $	��34* �6   �� 5      $	��38* �6   �� 5       $	��37* �6   �� 5!      $	��35* �6   �� 5"      $	��38* �6   �� 5#      $	��51* �6   �� 5$      $	��81* �6    � ColumnDefinitions 5&   
   �� 5'      $��3* �6   �� 5(      $��5* �6   .+�5*   
   �� $��0��6   $��0��6     
  Choose#���   6-   ���	#FFF44AC7
�������$��25(�6z   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5+   
   $��0��6   $��2��6     
 Amount#���  6-   
���   �$��16(�6y   $
��Bold"�6�   ��6P   Z� 6�   � 5,   
   $��0��6   $��3��6$   $��Center=�61   .+�5-      ��  �� Orientation$ 
Horizontal=�6   $��Center=�63   $��18��6N   .+�5.      �� -   5        	 ��Name$	 InStock��5.   l     In#���  6   ���	#FF33E6D8$��2,2,2,2q�6R   6}   �� 5/      -   5        $	 OutStock��5/        Out#���  6   ���	#FF33E6D8$��2,2,2,2q�6S   $��10,0,0,0q�6m   6�   50      51      �� 52   
   $��0��6   $��5��6     	 Price#���  6-   
���   �$��16(�6x   $
��Bold"�6�   ��6O   Z� 6�   � 53   
   $��0��6   $��6��6$   $
��Left=�61   .+�54      �� $ 
Horizontal=�6   $��0��62   $��6��6B   .+�55      ��   from#���  6   $
��Left=�69   �� 56      -   5        
 ��Name$
 fromNum��56   c   $��60��6   $��30��6%   ���	#FF33E6D8$��2,2,2,2q�6I   6c   �� 57        to#���  6   $
��Left=�67   �� 58      -   5        $
 toNum��58   c   $��60��6   $��30��6%   ���	#FF33E6D8$��2,2,2,2q�6I   6c   59      5:      �� 5;   
   -   5         ��Name$ Showw��5;   !   $��0��6   $��7��60   ���	#FF524FF0$��	30,5,30,5q�6T     Show#���  6g   
�������$��18(�6�   $
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5<   
   -	   5          Name$ dataGrid��5<      $��1��6%      AutoGenerateColumns$ False��65   $��0��6Q   $��12��6^      Columns 5=      0  *System.Windows.Controls.DataGridTextColumn  5>        	ShortName,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *	ShortName+6h     5?       	 Desc# � 	 6%   $ * 6e    6E   �� *Description+6e     5@      # �  6%   $ * 6`    6F   �� *Price+6`     5A      # �  6%   $ * 6d    6G   �� *
Quantity+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5B       
 Img# � 
 6)   $ * 6H      CellTemplate 5C      �� 5D      .R�5E      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5F      5H      5J      5K      5L      