   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   3clr-namespace:WpfApp1.controlsWpfApp1.controls  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5
mycontrolsclr-namespace:WpfApp1.controls     5   	     � Title$  OOP4-5��5   	   $	��450��6   $	��800��6%    � Cursor$1 +E:\4 сем\WPF\6\app_6\WpfApp1\pusheen.cur��5	   	    � Icon$. (E:\4 сем\WPF\6\app_6\WpfApp1\icon.png��5
   	      
Background#���   5   	    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$% local:CustomCommand.SaveToTable��5      6b     5   
   -   5        $ local:CustomCommand.Load��5      6V    � 	Resources 5         WpfApp1.CursorConverter  CursorConverter��%   &	         5   
   6    5      ��5      �� 5   
    �� Color$ White��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��287* �6   �� 5      $
��513* �6    � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5       $	��30* �6   �� 5!      $	��30* �6   �� 5"      $	��30* �6   �� 5#      $	��30* �6   �� 5$      $	��30* �6   �� 5%      $	��30* �6   �� 5&      $	��30* �6   �� 5'      $	��30* �6   �� 5(      $	��30* �6   �� 5)      $	��30* �6   �� 5*      $	��30* �6   �� 5+      $	��69* �6   .+�5-   
   o� $��0��6   $��2��6     menu#���  60   .@�5.      m�   File#���  6   .@�5/      m� -   5        	 m�Name$	 
AddProduct��5/   :     Add#���  6     menuitem#���  6g   m� 50      -   5        $	 Catalog��50   >     Catalog#���  6   
 m� Command$

 Open��6}   #���  6�    m� CommandTarget 6O   ��  �� ElementName$ Catalog��6�   51      m� 52        Edit#���  6   .@�53      m� -   5        $	 Sorted��53   ;     Sort#���  6   #���  6`   m� 54      -   5        $	 Search��54   =    
	 Search#��� 	 6   #���  6b   m� 55      -   5        $	 Chosen��55   <    	
 Filtr#��� 
 6   #���  6a   56      m� 57        Lang#���  6   .@�58      m� -   5        $	 Ru��58   9     Ru#���  6   #���  6V   m� 59      -	   5        $	 En��59   9     En#���  6   #���  6V   5:      m� 5;       	 Color#���  6   .@�5<      m� -
   5        $
	 dark��5<   8     d#���  6   #���  6F   6i   m� 5=      -   5        $	 light��5=   8     l#���  6   #���  6G   6j   5>      5?      �� 5A   
   $��1��6   $��0��6   #��� ��6-    	 label#���  6N   �� 5B   
     Desc#���  6   $��3��61   $��0��6>   #���  6N   �� 5C   
    	 Price#���  6   $��5��62   $��0��6?   #���  6O   �� 5D   
    
 Amount#���  6   $��7��63   $��0��6@   #���  6P   �� 5E   
     Img#���  6   $��9��60   $��0��6=   #���  6M   �� 5F   
   -   5         ��Name$ shortNameTextBox��5F      $��2��6,   $��0��69   
������$��2,2,2,2q�6b   �� 5G   
   -   5        $ descriptionTextBox��5G      $��4��6.   $��0��6;   
������$��2,2,2,2q�6d   �� 5H   
   -   5        $ priceTextBox��5H      $��6��6(   $��0��65   
������$��2,2,2,2q�6^   �� 5I   
   $��8��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5J      �� -   5         ��Name$ inStock��5J      $��0��6(     In#���  68     
StockWhite#���  6W   $��5q�6|   
������$��2,2,2,2q�6�    d� 	IsChecked$ FalseY�6�   $ Arrow��6�   �� 5K      -   5        $ outStock��5K      $��1��6)   $��5q�69     Out#���  6D   #���  6d   
������$��2,2,2,2q�6�   5L      �� 5M   
   -   5          Load#���  5M      $��10��6G   �� 5N   
   -   5         ��Name$ saveToTable��5N        Save#���  6&   $��12��6a   $��20q�6o   ���#8b00ff$��16(�6�   
�������$
��Bold"�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5O   
   -   5          Name$ dataGrid��5O   A     CustomDataGridStyle#���  6   $��1��6S      AutoGenerateColumns$
 True��6c   $��1��6~   $��12��6�      Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q        	ShortName,  &System.Windows.Controls.DataGridColumn   Header# �  6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *	ShortName+6h     5R      # �  6%   $ * 6e    6E   �� *Description+6e     5S      # �  6%   $ * 6`    6F   �� *Price+6`     5T      # �  6%   $ * 6d    6G   �� *
Quantity+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5U      # �  6)   $ * 6H      CellTemplate 5V      �� 5W      .R�5X      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5Y      5[      5]       � 5^   
   -   5          �Name$ MyFrame��5^      $��2��6!   $��13��65   $��1��6G   5_      5a      5b      