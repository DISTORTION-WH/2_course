   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.AddTovar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  AddTovar��5	         backPage#���   5
       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$  local:CustomCommand.saveto��5      6X     5   
   -   5        $ local:CustomCommand.Load��5      6V   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��287* �6   �� 5      $
��513* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5       $	��30* �6   �� 5!      $	��69* �6   .+�5#   
   ��  	 label#���  6   $��0��60   $��0��6=   #��� ��6M   �� 5%   
   #���  6     Desc#���  60   $��2��6Q   $��0��6^   �� 5&   
   #���  6    	 Price#���  60   $��4��6R   $��0��6_   �� 5'   
   #���  6    
 Amount#���  60   $��6��6S   $��0��6`   �� 5(   
   #���  6     Img#���  60   $��8��6P   $��0��6]   �� 5)   
   -   5         ��Name$ shortNameTextBox��5)      $��1��6,   $��0��69   
������$��2,2,2,2q�6b   �� 5*   
   -   5        $ descriptionTextBox��5*      $��3��6.   $��0��6;   
������$��2,2,2,2q�6d   �� 5+   
   -   5        $ priceTextBox��5+      $��5��6(   $��0��65   
������$��2,2,2,2q�6^   � 5,   
   $��7��6   $��0��6!   .+�5-      ��  �� Orientation$ 
Horizontal=�6   .+�5.      �� -   5         ��Name$ inStock��5.      $��0��6,     
StockWhite#���  6<     In#���  6a   $��5q�6�   
������$��2,2,2,2q�6�    d� 	IsChecked$ FalseY�6�   	 � Cursor$	 Arrow��6�   �� 5/      -   5        $ outStock��5/      $��1��6-   $��5q�6=   #���  6H     Out#���  6m   
������$��2,2,2,2q�6�   50      51      �� 52   
   -   5         	 Load#��� 	 52      $��9��6G   �� 53   
   -	   5        
 ��Name$
 saveToTable��53       
 Save#��� 
 6&   $��12��6\   $��20,10,20,10q�6j   ���#8b00ff$��16(�6�   
�������$
��Bold"�6�   
���   �6�   &   System.Windows.Controls.DataGrid  54   
   -
   5          Name$ dataGrid��54        CustomDataGridStyle#���  6%   $��1��6S      AutoGenerateColumns$ False��6c   $��0��6   $��12��6�      Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56        	ShortName,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *	ShortName+6h     57      # �  6%   $ * 6e    6E   �� *Description+6e     58      # �  6%   $ * 6`    6F   �� *Price+6`     59      # �  6%   $ * 6d    6G   �� *
Quantity+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5:      # �  6)   $ * 6H      CellTemplate 5;      �� 5<      .R�5=      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5>      5@      5B      5C      5D      