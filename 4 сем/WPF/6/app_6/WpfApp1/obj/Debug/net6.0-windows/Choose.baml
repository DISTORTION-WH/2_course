   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Choose   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Choose��5	         backPage#���   5
       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! local:CustomCommand.InStock��5      6Z     5   
   -   5        $" local:CustomCommand.OutStock��5      6\     5   
   -   5        $# local:CustomCommand.ShowPrice��5      6Z    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Dictionary1.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $	��76* �6   �� 5      $	��60* �6   �� 5      $	��34* �6   �� 5       $	��38* �6   �� 5!      $	��37* �6   �� 5"      $	��35* �6   �� 5#      $	��38* �6   �� 5$      $	��51* �6   �� 5%      $	��81* �6    � ColumnDefinitions 5'   
   �� 5(      $��3* �6   �� 5)      $��5* �6   .+�5+   
   �� $��0��6   $��0��6     
 Choose#���  6-   ���#8b00ff
�������$��25(�6x   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5,   
    	 label#���  6   $��0��60   $��2��6@    
 Amount#���  6M   $��16(�6�   $
��Bold"�6�   ��6p   Z� 6�   � 5-   
   $��0��6   $��3��6$   $��Center=�61   .+�5.      ��  �� Orientation$ 
Horizontal=�6   $��Center=�63   $��18��6N   .+�5/      �� -   5        	 ��Name$	 InStock��5/   �     
StockWhite#���  6     In#���  6@   ���	#FF33E6D8$��2,2,2,2q�6w   6�   �� 50      -   5        $	 OutStock��50   �   #���  6     Out#���  6@   ���	#FF33E6D8$��2,2,2,2q�6x   $��10,0,0,0q�6�   6�   51      52      �� 53   
   #���  6   $��0��60   $��5��6@    	 Price#���  6M   $��16(�6�   $
��Bold"�6�   ��6o   Z� 6�   � 54   
   $��0��6   $��6��6$   $
��Left=�61   .+�55      �� $ 
Horizontal=�6   $��0��62   $��6��6B   .+�56      �� #���  6     from#���  68   $
��Left=�6Y   �� 57      -   5        
 ��Name$
 fromNum��57   c   $��60��6   $��30��6%   ���	#FF33E6D8$��2,2,2,2q�6I   6c   �� 58      #���  6    	 to#��� 	 68   $
��Left=�6W   �� 59      -   5        $
 toNum��59   c   $��60��6   $��30��6%   ���	#FF33E6D8$��2,2,2,2q�6I   6c   5:      5;      �� 5<   
   -   5         ��Name$ Showw��5<   S    
 RoundedButtonTemplate#��[
 6   $��0��6C   $��7��6b   ���	#FF524FF0$��	30,5,30,5q�6�     Show#���  6�   
�������$��18(�6�   $
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5=   
   -	   5          Name$ dataGrid��5=   A     CustomDataGridStyle#���  6   $��1��6S      AutoGenerateColumns$ False��6c   $��0��6   $��12��6�      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?        	ShortName,  &System.Windows.Controls.DataGridColumn   Header# [ 6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	ShortName+6g     5@        Desc# [ 6%   $ * 6d    6D   �� *Description+6d     5A      # [ 6%   $ * 6_    6E   �� *Price+6_     5B      # [ 6%   $ * 6c    6F   �� *
Quantity+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5C        Img# [ 6)   $ * 6G      CellTemplate 5D      �� 5E      .R�5F      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5G      5I      5K      5L      5M      