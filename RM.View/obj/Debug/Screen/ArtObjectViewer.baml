   M S B A M L   `   `   `  ����  RM.View$    RM.View.Screen.ArtObjectViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $" ../Resource/Style/Style.xaml?�6%   %    5      .��5      � .+�5   
   �� 
������ $��Disabled=�5      ��5      �� *ListOfArtObjects+��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ 	#FF1E2A2F��6#    � Offset$ 1Q�65   5      ��5      �� 5      .R�5      � $
��Left=�6   $	��200��66   $	��230��6B   .+�5      ��    TileButtonStyle#��[  6!   ��5   !   ��  �� RelativeSource ��  �� AncestorType$ ItemsControlL�	 �� Path$#	 DataContext.GetDetailsCommand���5   !   �� *objectNumber+.��5      �� $��Stretch=�6D   $	��Top=�5    $   $��UniformToFill=�6<   $	��200��6T   $	��230��6`   ��5   $   �� *webImage.url+5    `   5!      �� 5"      $��Bottom=�6%   
���   �
 J� Opacity$

 0.70Q�6S   $	��230��6b   .+�5#      �� 
�������$��60��6R   $��	15,0,15,0q�6^   $
��Bold"�5$   (   $��WrapWithOverflow=�6:   ��5#   (   �� *title+5$   :   5%      5&      5'      ��5)      �� 5*      .R�5+      �  K� IsItemsHost .  � Orientation$ 
Horizontal=�63   5,      5.      5/      50      