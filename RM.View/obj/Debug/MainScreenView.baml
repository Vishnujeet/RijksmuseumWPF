   M S B A M L   `   `   `  ����B  >RM.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RM.ViewRM.View  5   	   /clr-namespace:RM.View.ScreenRM.View.Screen  5   	       RM.View.MainScreenView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RM.View     5   	   /screenclr-namespace:RM.View.Screen     5   	     � Title$  MainScreenView��5	   	   $
��1500��6    $	��800��6-    � WindowState$ 	Maximized=�6:   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6   � 5      $ 	#FF1E2A2F��6    � Offset$ 1Q�6-   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� 
�������$��30(�6'   $
��Bold"�65   $��Center=�6G   $��10q�6d   $��RijksMuseum Demo Sample��6p   6�   $   RM.View.Screen.ArtObjectViewer  5   
   $��1��6!   $��Stretch=�6Y   
������  � DataContext 6.   �� *ArtObjectViewModel+6~   5      5      