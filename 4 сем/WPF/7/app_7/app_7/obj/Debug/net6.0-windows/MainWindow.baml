   M S B A M L   `   `   `  ����@  <app_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:app_7app_7  5   	   /clr-namespace:app_7.controlsapp_7.controls  5	   	       app_7.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:app_7     5   	   3
mycontrolsclr-namespace:app_7.controls     5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��189* �6   �� 5      $
��211* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   !   app_7.controls.UserControl1  -   5          Name$ 	redSlider��5   c   $��0��6"   $��0��6/   $��	0,0,0,144q�6?   $��2��6R   6c     5   
   -   5        $ greenSlider��5   d   $��0��6"   $��0��6/   $��
0,40,0,144q�6?   $��2��6S   6d     5   
   -   5        $ 
blueSlider��5   d   $��0��6"   $��0��6/   $��
0,80,0,144q�6?   $��2��6S   6d   �� 5   
   -   5         ��Name$ Field��5   9   $��1��6   $��30,10,30,10q�6$   69   !   app_7.controls.UserControl2  5   
   -   5          Name$ userControl2��5   K   $��0��6"   $��1��62   $��40q�6?   6K   �� 5   
   $��2��6   $��0��6!   $��RoutedEvent -> Direct��61   �� 5   
   -   5        $��5,20,5,5q�5      $��2��6'   $��0��64   ��5       �� 5!       �� Color$ 	#FF4B4848��6"    �� Opacity$
 0.49Q�64   .+�5#      �� -   5         ��Name$ button1��5#      $��50��6<   $	��200��6H   $��Center=�6T   $��Center=�6o   $��0,35,0,0q�6�   .��5$      A� -   5        $��40��5$   ?   $��40��6K   ���	#FF7737D26V   5%      5&      �� 5'   
   -	   5        	 ��Name$	 
textBlock1��5'      $��1��6(   $��2��68   
 �� Padding$
 10q�6E   5(      5)      