   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  OOP4-5��5   	   $	��450��6   $	��800��6%    � Cursor$: 4E:\4 сем\формы\4\WpfApp1\WpfApp1\pusheen.cur��5	   	    � Icon$7 1E:\4 сем\формы\4\WpfApp1\WpfApp1\icon.png��5
   	    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$% local:CustomCommand.SaveToTable��5      6b     5   
   -   5        $ local:CustomCommand.Load��5      6V    � 	Resources 5         WpfApp1.CursorConverter   CursorConverter��%   &	          5   
   6    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��287* �6   �� 5      $
��513* �6    � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5       $	��30* �6   �� 5!      $	��30* �6   �� 5"      $	��30* �6   �� 5#      $	��30* �6   �� 5$      $	��30* �6   �� 5%      $	��30* �6   �� 5&      $	��30* �6   �� 5'      $	��69* �6   .+�5)   
   o� $��0��6   $��2��6   .@�5*      m�   File#���  6   .@�5+      m� -   5         m�Name$ 
AddProduct��5+   :     Add#���  6   6N   m� 5,      -   5        $ Catalog��5,   >     Catalog#���  6   	 m� Command$
	 Open��6}   
 m� CommandTarget
 6O   ��  �� ElementName$ Catalog��6}   5-      m� 5.        Edit#���  6   .@�5/      m� -   5        $ Sorted��5/   ;     Sort#���  6   6K   m� 50      -   5        $ Search��50   =    
 Search#���  6   6M   m� 51      -   5        $ Chosen��51   <    	 Filtr#���  6   6L   52      m� 53        Lang#���  6   .@�54      m� -   5        $ Ru��54   9    	 Ru#��� 	 6   6E   m� 55      -	   5        $ En��55   9    
 En#��� 
 6   6E   56      57      �� 59   
   $��1��6   $��0��6   #��� ��6-   �� 5;   
     Desc#���  6   $��3��61   $��0��6>   �� 5<   
    	 Price#���  6   $��5��62   $��0��6?   �� 5=   
    
 Amount#���  6   $��7��63   $��0��6@   �� 5>   
     Img#���  6   $��9��60   $��0��6=   �� 5?   
   -
   5         ��Name$ shortNameTextBox��5?      $��2��6,   $��0��69   
������$��2,2,2,2q�6b   �� 5@   
   -   5        $ descriptionTextBox��5@      $��4��6.   $��0��6;   
������$��2,2,2,2q�6d   �� 5A   
   -   5        $ priceTextBox��5A      $��6��6(   $��0��65   
������$��2,2,2,2q�6^   �� 5B   
   $��8��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5C      �� -   5         ��Name$ inStock��5C      $��0��6(     In#���  68   $��5q�6W   
������$��2,2,2,2q�6{    d� 	IsChecked$ FalseY�6�   $ Arrow��6�   �� 5D      -   5        $ outStock��5D      $��1��6)   $��5q�69     Out#���  6D   
������$��2,2,2,2q�6}   5E      �� 5F   
   -   5          Load#���  5F      $��10��6G   �� 5G   
   -   5         ��Name$ saveToTable��5G        Save#���  6&   $��12��6a   $��20q�6o   ���	#FFD81AE5$��16(�6�   
�������$
��Bold"�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ dataGrid��5H      $��1��6%      AutoGenerateColumns$
 True��65   $��1��6P   $��12��6]      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J        	ShortName,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *	ShortName+6h     5K      # �  6%   $ * 6e    6E   �� *Description+6e     5L      # �  6%   $ * 6`    6F   �� *Price+6`     5M      # �  6%   $ * 6d    6G   �� *
Quantity+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5N      # �  6)   $ * 6H      CellTemplate 5O      �� 5P      .R�5Q      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5R      5T      5V       � 5W   
   -   5          �Name$ MyFrame��5W      $��2��6!   $��13��65   $��1��6G   5X      5Z      5[      