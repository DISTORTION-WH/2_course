   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      3clr-namespace:WpfApp1.controlsWpfApp1.controls  5          WpfApp1.Search   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      5
mycontrolsclr-namespace:WpfApp1.controls     5        N� Title$  Search��5	         backPage#���   5
       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$" local:CustomCommand.toSearch��5      6`   .��5      �  � RowDefinitions 5   
   �� 5      $	��57* �6   �� 5      $
��107* �6   �� 5      $	��36* �6   �� 5      $	��36* �6   �� 5      $	��36* �6   �� 5      $	��93* �6   �� 5      $	��85* �6    � ColumnDefinitions 5   
   �� 5      $
��271* �6   �� 5      $
��529* �6   .+�5    
   �� $��0��6   $��0��6     
 Search#���  6-   $��25(�6P   $
��Bold"�6^   $��Center=�6p   $��Center=�6�   ���#8b00ff
�������6�   �� 5!   
    	 label#���  6   $��0��60   $��2��6@    
 EnterN#���  6M   $��Stretch=�6p   $��16(�6�   $
��Bold"�6�   $��Stretch=�6�   $	��Top=�6�   $��31��6�   �� 5"   
   -   5         ��Name$ textik��5"   "   $��0��6   $��3��62   ���	#FF46E3D1$��2,2,2,2q�6W   $��0,5,0,0q�6q   #   WpfApp1.controls.UserControl1  5#   
   #   WpfApp1.controls.UserControl1   Click$ UserControl1_Click��6R   $��0��6"   $��5��62   $��	20,0,20,0q�6?   6R   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dataGrid��5$   A     CustomDataGridStyle#���  6   $��1��6S      AutoGenerateColumns$ False��6c   $��0��6   $��7��6�   	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&        	ShortName,  &System.Windows.Controls.DataGridColumn
   Header#
 [ 6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	ShortName+6g     5'        Desc#
 [ 6%   $ * 6d    6D   �� *Description+6d     5(       	 Price#
 [ 6%   $ * 6_    6E   �� *Price+6_     5)       
 Amount#
 [ 6%   $ * 6c    6F   �� *
Quantity+6c   4	  .System.Windows.Controls.DataGridTemplateColumn	  5*       	 Img#
 [	 6)   $ * 6G    	  CellTemplate 5+      �� 5,      .R�5-      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5.      50      52      53      54      