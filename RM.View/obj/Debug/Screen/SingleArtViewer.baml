   M S B A M L   `   `   `  ����  RM.View$    RM.View.Screen.SingleArtViewer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  AddEmployee��5   	    � AllowsTransparency . 
������  � WindowState$ 	Maximized=�6P    � WindowStyle$
 None=�5   	    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $" ../Resource/Style/Style.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $��9* �6   $	��448��6*   �� 5      $	��.5* �6    � RowDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $��9* �6   �� 5      $	��.5* �6   .+�5   
   �� ���#050506	 J� Opacity$	 .6Q�6&   $��3��63   $��3��6G   �� 5   
   
 �� CornerRadius$
 2��6   $��1��6"   $��1��6/   
�������$��Center=�6R   ._�5      �  5      �� 5       $��* �6'   �� 5!      $��* �6'   �� 5"      $
��auto �6'   .+�5$      �� $��Stretch=�62   $	��Top=�6P   $
��Fill=�5%      ��5$      �� *ArtUrl+5%      �� 5'      $��1��6   .+�5(      9� $��Stretch=�6   $��Stretch=�5)       9� 
IsExpanded . ��5*      �� 5+      $��32(�5,   !   $��SemiBold"�5-   !   $��Description��5.   !   .��50      �� $��10q�6A   $��WrapWithOverflow=�51   $   $��20(�6D   ��50   $   �� *Description+51   D   53      9� 54      $��Stretch=�6   $��Stretch=�55      ��56      �� 57      $��32(�58   !   $��SemiBold"�59   !   $��Principal Or FirstMaker��5:   !   .��5<      �� $��10q�6;   $��WrapWithOverflow=�5=   $   $��20(�6D   ��5<   $   �� *Maker+5=   D   5>      9� 5?      $��Stretch=�6   $��Stretch=�5@      ��5A      �� 5B      $��32(�5C   !   $��SemiBold"�5D   !   $��Miscellaneous Details��5E   !   5G      5H      �� 5J      $
��asgf��6   $��Right=�6(      CloseButton#��[  6e   $	��Top=�5K      $��2��61   $��5q�6A   ��5J   D   �� *CloseCommand+5K   A   5L      5M      5N      5O      