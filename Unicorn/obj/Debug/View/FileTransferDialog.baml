   M S B A M L   `   `   `  ����  Unicorn%    Unicorn.View.FileTransferDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  FileTransferDialog��5   	   $	��500��5   	   $	��210��5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5
   	    � 	Resources 5       �� Source�� 5   
   $ ../Styles/Style.xaml?�6   %    .��5      �� $��3q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6      Opacity$	 0.8Q�5      	   ShadowDepth$	 0Q�5      
   Color$
 #00a3e1��5      ._�5   
   � 
������� � ColumnDefinitions 5      �� 5      �� 5      $��7* �6#   �� 5       � RowDefinitions 5      �� 5      $��25 �6    �� 5      .+�5       �� $��3��6   $��3q�6-   .+�5!      �  5"      �� 5#      �� 5$      $��7* �6+   �� 5%      .+�5'      �� -   5         ��Name$ Header��5'       $��1��5(          HeaderStyle#��[  5)       $!��Передача файла��5*        �� TextAlignment$ Center=�5+       �� 5,      $��2��6!   $��Right=�5-   !    �� Orientation$ 
Horizontal=�5.   !   .+�5/      �� -   5          HeaderButtonStyle#��[ 5/   <   .��50      �� $��../Resources/close.png��6$   51      52      55      56      �� 57      $��1��6   $��1��6&   .+�58      ��   
LabelStyle#��[ 6   .��6<   $"Название файла: 1.rar6S   �� 59      #��[ 6   .��6<   " Размер файла: 12.7 mb6S   �� 5:      #��[ 6   .��6<   Получено: 1.3 mb6N   � 5;      $��10��6   ���#00bfff � Value$ 10Q�5=      �� 5>      $��Center=�6   #��[ 65   .��6Y   10 %6_   5?      �� 5@      -   5        $��1��5@      $��1��5A      $	��100��5B      $��32��5C      $��5q�5D      $��Bottom=�5E      ���#969696  
ButtonBase#��[ 5H      .��69   Отмена5J      5K      5L      5N      