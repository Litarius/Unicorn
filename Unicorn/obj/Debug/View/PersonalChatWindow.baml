   M S B A M L   `   `   `  ����  Unicorn%    Unicorn.View.PersonalChatWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  PersonalChatWindow��5   	   $	��400��5   	   $	��300��5   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5	   	    � 	Resources 5
       �� Source�� 5   
   $ ../Styles/Style.xaml?�6   %    .��5      �� $��3q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6      Opacity$	 0.8Q�5         ShadowDepth$ 0Q�5      	   Color$	 #00a3e1��5      ._�5   
   � 
�������
 � ColumnDefinitions
 5      �� 5      �� 5      $��3* �6#   �� 5       � RowDefinitions 5      �� 5      $��25 �6    �� 5      .+�5      �� $��3��6   .+�5       � 
 5!      �� 5"      �� 5#      $��7* �6+   �� 5$      .+�5&      �� $��1��6    $��50��5'          HeaderStyle#��[  5(       $��Чат��5)        �� TextAlignment$ Center=�5*       �� 5+      $��2��6!   $��Right=�5,   !    �� Orientation$ 
Horizontal=�5-   !   .+�5.      �� $��Right=�6!     HeaderButtonStyle#��[ 6=   .��5/      �� $��../Resources/maximize.png��6$   50      �� 51      #��[ 6!   .��52      �� $��../Resources/close.png��6$   53      54      56      57      �� 58      $��1��6   $��0��59      $��3��5:      .+�5;      �� $	��229��6   $��5q�5<        TextBoxStyle#��[ 5=      �� 5>      $ 
Horizontal=�6   .+�5?      �� $	��309��6   $	��5 0q�5@      #��[ 5A      �� 5B      $	��5 0q�6     
ButtonBase#��[ 6*   .��6N   Отправить6Y   5C      5E      5G      5I      5K      