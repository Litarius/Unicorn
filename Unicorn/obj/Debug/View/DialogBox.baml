   M S B A M L   `   `   `  ����  Unicorn    Unicorn.View.DialogBox   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	DialogBox��5   	   $	��400��5   	   $	��200��5   	    � AllowsTransparency . 
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
������� � ColumnDefinitions 5      �� 5      �� 5      $��7* �6#   �� 5       � RowDefinitions 5      �� 5      $��25 �6    �� 5      .+�5       �� -   5        $��3��5       $��3q�5!      .+�5#      �  5$      �� 5%      �� 5&      $��7* �6+   �� 5'      .+�5)      �� -   5         ��Name$ Header��5)       $��1��5*          HeaderStyle#��[  5+       $��Чат��5,        �� TextAlignment$ Center=�5-       �� 5.      $��2��6!   $��Right=�5/   !    �� Orientation$ 
Horizontal=�50   !   .+�51      �� -   5          HeaderButtonStyle#��[ 51   <   .��52      �� $��../Resources/close.png��6$   53      54      57      58      �� 59      -   5        $ Message��59      $��1��5:      $��1��5;      $��Segoe UI Light)�5<      $��16(�5=      $
��Wrap=�5>      �� 5?      -   5        $��1��5?      $��1��5@      $	��100��5A      $��32��5B      $��5q�5C      $��Bottom=�5D        
ButtonBase#��[ 5F      .��69   OK5H      5I      5J      5L      