   M S B A M L   `   `   `  ����L  HNotificationBotV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NotificationBotV1NotificationBotV1  5   	   "    NotificationBotV1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NotificationBotV1     5   	     � Title$  
MainWindow��5	   	   $	��550��6   $	��900��6)    � WindowStartupLocation$ CenterScreen=�65   $��Disabled=�6Z   $	��550��6�   $	��900��6�    � WindowStyle$
 None=�6�   ���	#FFB27575���	#FFBD7979.��5      � ���	#FFC9C9C9.+�5   
   �� -   5        $	��TB1��5      $��
0,158,0,91q�6    �� TextWrapping$
 Wrap=�61   $G��AЗагружается последнее объявление...��6E   $$��Tw Cen MT Condensed Extra Bold)�6p   $��24(�6�   ���	#FF375FD8$ �� HorizontalScrollBarVisibility$
 Auto=�6�   " �� VerticalScrollBarVisibility$ Disabled=�6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6     TextHintingMode$ Animated=�67  ���	#FF0F0403���	#FFC9C9C96�  �� 5   
   -   5        $��ButRead��5   &   $��Прочитано!��6   $��315,456,0,0q�65   $	��251��6J   $��67��6V   ���	#FF17170E$	��Top=�6�   $
��Left=�6�   $$��Tw Cen MT Condensed Extra Bold)�6�   $��24(�6�   ���	#FFF50707���	#FFE0E006 � Cursor$
 Hand��6+  �� 5   
   -   5        	 ��Name$		 TB2��5   D   $
��Left=�6   ���	#FFC9C9C9$��60��6Q   $��
112,12,0,0q�6]   $
 Wrap=�6q   $��     ��6�   $	��Top=�6�   $	��294��6�   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $��tb_name��5   d   $
��Left=�6   ���	#FFC9C9C9$��60��6D   $��
112,72,0,0q�6P   $
 Wrap=�6s   $��     ��6�   $	��Top=�6�   $	��294��6�   $��Times New Roman)�6�   $��20(�6�   
 �� SelectionBrush
 �	#FFEFF2F5$
��Bold"�6�   �� 5   
   -   5        $��Lb_time��5   f   $��Время:��6   $
��Left=�6!   $��7,12,0,0q�6<   $	��Top=�6N    J� RenderTransformOrigin$ 0.5,0.5&�6u   $��56��6�   $��81��6�   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $��lb_name��5   P   $��От кого:��6   $
��Left=�6#   $��7,72,0,0q�6>   $	��Top=�6_   $��Times New Roman)�6w   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ Next_but��5      $�� ��6#   $
��Left=�6.   $��
761,10,0,0q�6I   $	��Top=�6]   $	��109��6u   $��58��6�   $
 Hand��6�    � UseLayoutRounding .  $��Center=�6�   ���	#FF707070 J� OpacityMask 5      �� 5       �� ImageSource$ icon_button.png��6   ��5      �� 5      $ icon_button.png��6    j� TileMode$
 Tile=�6;   5      �� 5   
   -   5        $ Prev_but��5      $�� ��6#   $
��Left=�6.   $��
760,83,0,0q�6I   $	��Top=�6]   $	��109��6u   $��56��6�   $
 Hand��6�    .  $ 0.5,0.5&�6�    5      �� 5      $ icon_button.png��6   z�5      V� 5       .~�5!      �� �� 5"      �� 5#       �� Angle$ 180.325Q�6&   T� 5$      5%      ��5'      �� 5(      $ icon_button.png��6   $
 Tile=�6;   5*      5-      5.      