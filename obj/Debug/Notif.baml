   M S B A M L   `   `   `  ����C  ?SaveEyes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SaveEyesSaveEyes  5   	       SaveEyes.Notif   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SaveEyes     5   	     � Title$  Notification Popup��5   	   $	��300��6$    � SizeToContent$ Height=�60    � WindowStyle$
 None=�5	       � AllowsTransparency . 
������ .��5      �  J� RenderTransformOrigin$	 0,1&�6   .+�5   
   �� $��1q�6   
�������
���   � �� CornerRadius$ 10��6L   ._�5      �� $��20q�6   .+�5      �� $
��Wrap=�6   $��5q�60   �� 5      .�6   Posture Matters!6#   �� 6)   �� 66   Look away from the screen!5      �� 5      -   5        $��Dismiss��5      $��Center=�6+   6H   5      5       � Triggers 5   
   :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� .��5      �� .��5      U�  �� TargetProperty$9 3(UIElement.RenderTransform).(ScaleTransform.ScaleY)�68   .\�5      �� 	 O� KeyTime$	 0:0:0��63   
 O� Value$
 0Q�6C   �� 5       $	 0:0:0.5��63   $
 1Q�6E   5!      U� 5"      $ (UIElement.Opacity)�68   .\�5#      �� $	 0:0:2��63   $
 1Q�6C   �� 5$      $	 0:0:4��63   $
 0Q�6C   5%      5&      5'      5(      z�5+   
   �� 5,       �� ScaleY$ 1Q�6   5/      50      