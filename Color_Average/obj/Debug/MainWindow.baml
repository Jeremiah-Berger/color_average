   M S B A M L   `   `   `  ����H  DColor_Average, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Color_AverageColor_Average  5   	       Color_Average.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Color_Average     5   	   -   5          � 
ResizeMode$  	CanResize=�5   	   $
��1075��5	   	    � Title$ Photo Color Average��5
   	   .��5      �� 
 �� Top$ 0��6    �� Left$ 0��6   .+�5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $
��Auto �6   �� 5      $	��400 �6    � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $
��Auto �6   6,   .+�5      �� -   5        $��ImportButton��5   �   $��Import��6   $��Center=�6'   $��28(�6D   $	��Top=�6R   $��75��6j   $	��125��6v   $��0��6�   $��1��6�   $��-150,20,0,0q�6�   �� 5   
   -   5        $��PixelatorButton��5   �   $��
Pixel-ator��6   $��Center=�6'   $��28(�6D   $	��Top=�6R   $��75��6j   $	��125��6v   $��0��6�   $��1��6�   $��
150,20,0,0q�6�   �� 5   
   -   5        $��Image��5   %   $��10,10,10,10q�6   $	��400��62   $��1��6@   $��0��6M   6_   �� 5   
   -   5        $��ToPixelImage��5   %   $��10,10,10,10q�6   $	��400��69   $��1��6G   $��1��6T   6f   �� 5   
   -   5        $��ColorDisplay��5   *   $��10,10,10,10q�6   $	��400��6>   $��1��6L   $��2��6Y   6k   �� 5   
   -   5        $��RGBText��5   P   $��2��6   $��20(�6"   $��	0,470,0,0q�60   $��1��6C   $��Center=�6_    �� 
IsReadOnly . 
�������$��0q�6�   �� 5    
   -   5        $��HexText��5    P   $��2��6   $��20(�6"   $��	0,500,0,0q�60   $��1��6C   $��Center=�6_    . 
�������$��0q�6�   �� 5#   
   -	   5        $��XLabel��5#      $��X��6   6,   �� 5$   
   -
   5        $��YLabel��5$      $��Y��6   $��0,20,0,0q�6*   6>   �� 5%   
   -   5        $��
PixelColor��5%   %   $��
PixelColor��6   $��0,40,0,0q�67   6K   5&      5'      5(      