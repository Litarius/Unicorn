   M S B A M L   `   `   `  ����  Unicorn    Unicorn.View.StartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  StartWindow��5   	   $	��300��5   	   $	��300��5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � DataContext 5
   	   ��    Locator �� Source# [   �� Path$ StartViewModel� � 	Resources 5       �� Source�� 5   
   $ ../Styles/Style.xaml?�6   %    .��5      �� $��3q�6   	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 20Q�6      Opacity$	 0.8Q�5         ShadowDepth$ 0Q�5         Color$ #00a3e1��5      ._�5   
   � 
������� � ColumnDefinitions 5      �� 5      �� 5      $��7* �6#   �� 5       � RowDefinitions 5      �� 5       $��25 �6    �� 5!      .+�5#      �� -   5        $��3��5#      $��3q�5$      .+�5&      �  5'      �� 5(      �� 5)      $��7* �6+   �� 5*      .+�5,      �� $��1��6      HeaderStyle#��[ 5-       $��Чат��5.        �� TextAlignment$ Center=�5/       �� 50      -   5        $��2��50      $��0 0 3 0q�51      $��Right=�52        HeaderButtonStyle#��[ 54      .��55      �� $��../Resources/close.png��6    56      57      58      �� 5<      $��1��6   $��1��6&   .+�5=      	�  	� 	GroupName$ roomType��6     RadioButtonStyle#��[ 5?       d� 	IsChecked 5>      �� *
IsClient+.��5?   H   ,*Подключиться к комнате5A      	� 5B      $ roomType��6   #��[ 5D       5C      �� *
IsServer+.��5D   H   Создать комнату5F      �� 5G      $��0 10 0 0q�6   y�6/   �� *
IsClient+   BooleanToVisibilityConverter �� 	Converter# [ .+�5H      ��   
LabelStyle#��[ 6   .��6@   !Имя пользователя6R   �� 5I        TextBoxStyle#��[ 6   ��6D   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5J      #��[ 6   .��6@   IP сервера6L   %  Xceed.Wpf.Toolkit.MaskedTextBox  5K         Mask$ 000.000.000.000��6)   #��[ 5L   )   ��5M   )   �� *ServerAdress+$ PropertyChanged=�5O      �� 5P      $��0 10 0 0q�6   y�6/   �� *
IsServer+# [ .+�5Q      �� #��[ 6   .��6@   !Имя пользователя6R   �� 5R      #��[ 6   ��6D   �� *
UserName+$ PropertyChanged=�5S      �� 5T      $��35��6   $
��0 15q�5U      $��0q�5V        
ButtonBase#��[ 5Y      ��5W      �� *StartCommand+{�5X      �� *
CanStart+.��5Y   =   
Далее5[      5\      5]      5^      5a      