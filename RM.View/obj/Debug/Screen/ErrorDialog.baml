   M S B A M L   `   `   `  ����  RM.View     RM.View.Screen.ErrorDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � Title$  ErrorMessageScreen��5       � AllowsTransparency . 
������  � WindowStyle$
 None=�6m    � WindowState$ 	Maximized=�6�    � 
ResizeMode$ NoResize=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $" ../Resource/Style/Style.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��32.5* �6   �� 5      $	��35* �6   $	��448��6+   �� 5      $��32.5* �6   	 � RowDefinitions	 5   
   �� 5      $��12.5* �6   �� 5      $	��75* �6   �� 5      $��12.5* �6   .+�5   
   �� $��0��6   
������ 
 J� Opacity$
 .6Q�67   $��3��6D   $��3��6X   � 5   
   $��1��6   $��1��6   $��Center=�6,   
�������	 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5!      �� $��	24 20 0 0q�6   $��0��6'   ��64   �� *msg+]� 5"      $��1��6   $
��0,24q�6%   .+�5#      (� $��24 0 0 0q�6   $��38��6,   $��38��67    (� Stretch$ Uniform=�6C   .��5$      F� $��Center=�6   $��Center=�66    �� Stretch$
 Fill=�6S   
���  ���������[ �|r � z �|r � z ��- р�[ ��- р�[ �|r ���[ �ا � z �ا � z @T� р�[ @T� р�[ �ا ����  ȯ �p� ��� �@=x @� �0x @� �0�u P4  �p ��j �0�d     �_ ��  �\ �N	 ��\ �N	 �� ��� ���  ȯ �@�  �� �[�  � �    p� �� @]� @]� �@]� @]� Ӱ�� @]� ��� p� ���  � Ӏ�� �[� @� �� ���  ȯ ����  ȯ 	5&      5'      �� 5(      $��16 0 0 0q�6   ��6.   �� *	Message+5)      �� 5*      $��2��6   $��OK��6"   $��5q�6/   $��Right=�6:    �� IsCancel .    Button-Style#��[  6f   
���  ��6�   5,      5-      5.      