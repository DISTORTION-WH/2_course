   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.Filtr   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Filtr��5	       J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! local:CustomCommand.Letters��5      6Z     5   
   -   5        $! local:CustomCommand.Numbers��5      6Z   .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5      $
��200* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $
��239* �6    � ColumnDefinitions 5   
   �� 5      $
��273* �6   �� 5      $
��527* �6   .+�5   
   �� $��0��6   $��0��6      Sort#���   6-   $��20(�6N   $
��Bold"�6\   $��Center=�6n   ���	#FFF820ED
�������6�   �� 5   
   -   5         ��Name$ Letters��5      $��2��6   $��0��6/     Let#���  6?   $��16(�6_   $��Italic$�6m   $��0,0,0,5q�6�   ���	#FFFBF0866�   �� 5    
   -   5        $ Numbers��5       $��3��6   $��0��6/     Num#���  6?   $��16(�6_   $��Italic$�6m   $��0,5,0,0q�6�   ���	#FFFBF0866�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ dataGrid��5!      $��1��6%      AutoGenerateColumns$ False��65   $��0��6Q   $��7��6^      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#        	ShortName,  &System.Windows.Controls.DataGridColumn	   Header#	 [ 6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6g   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *	ShortName+6g     5$        Desc#	 [ 6%   $
 * 6d    6D   �� *Description+6d     5%       	 Price#	 [ 6%   $
 * 6_    6E   �� *Price+6_     5&       
 Amount#	 [ 6%   $
 * 6c    6F   �� *
Quantity+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5'        Img#	 [ 6)   $
 * 6G      CellTemplate 5(      �� 5)      .R�5*      �� $��90��6$   $��90��6/   ��6;   �� *	ImagePath+5+      5-      5/      50      51      