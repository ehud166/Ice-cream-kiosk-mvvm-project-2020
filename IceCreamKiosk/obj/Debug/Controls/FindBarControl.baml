   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:IceCreamKiosk.ControlsIceCreamKiosk.Controls  5      +    %IceCreamKiosk.Controls.FindBarControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:IceCreamKiosk.Controls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      J FMahApps.Metro, Version=1.6.0.362, Culture=neutral, PublicKeyToken=null;controls,http://metro.mahapps.com/winfx/xaml/controls  5        � DataContext  5	      ��    Locator �� Source# [   �� Path$ FindBar�.��5      �� .+�5      #  MaterialDesignThemes.Wpf.Card  $
��Left=�6   $
��10 0q�63     PrimaryHueLightBrush#���  6A    J� Opacity$	 0.9Q�5      $��Center=�6&    " PrimaryHueLightForegroundBrush#���  5      $��10q�6V   .��5      �� $��Center=�6   $��0q�6+   $
��auto��66   $
��auto��6D   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��3q�6*   .+�5      ��  * &MaterialDesignOutlinedTextFieldTextBox#��[ 64   $��Stretch=�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5   $   $	��200��68   $	��250��6G   $��16(�6V   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Ice Cream Name/Description��5      ��5      �� *IceCreamDescription+5      �� 5      $��3q�5      $��Stretch=�5      $
��auto��5      $	��5 0q�5        MaterialDesignRaisedButton#��[ 6   $��85��6O   ��5      �� *FindCommand+.��5   Z   search5      5      � 5      $��Center=�6    � RowDefinitions 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      .+�5(      9� $	��300��6   #���  6   $��2��6P   $��0q�6]     MaterialDesignExpander#��[ 5)      $��Advanced search��5*      .��5+      �� $ Vertical=�6   .+�5-   	   �� $ vertical=�6   $��71��6+   .+�5.   
   �� -   5        	 ��Name$	 EnergySlider��5.      
 �� Orientation$
 
Horizontal=�6'    �� TickFrequency$ 10Q�6@    �� IsSnapToTickEnabled .  � Minimum$ 0Q�5/       � Maximum$	 600Q�6      MaterialDesignDiscreteSlider#��[ 6+   $��51��50   -    � Value 6   �� *	MaxEnergy+6-   ]� 51   
   ��.  .+�52      �� $
��Left=�6   $��Max Enargy(Kcal)��60   �� 53      $��Right=�6   ��6,   �� $ Value� �� ElementName$ EnergySlider��54      55   
   �� 57   	   $��71��6   .+�58   
   �� -   5        $	 CarboSlider��58      $��51��6&   $
 
Horizontal=�62   $ 10Q�6K    . $ 0Q�59      $	 550Q�6   #��[ 6+    5:      �� *MaxCarbohydrate+]� 5;   
   ��.  .+�5<      �� $
��Left=�6   $��Max Carbohydrate (g)��6+   �� 5=      $��Right=�6   ��6,   �� $ Value�$ CarboSlider��5>      5?   
   �� 5A   	   $��71��6   .+�5B   
   �� -   5        $	 	FatSlider��5B      $��51��6$    � Cursor$
 Wait��60   $
 
Horizontal=�6>   $ 5Q�6W    . $ 0Q�5C   ,   $	 100Q�68   #��[ 5D       6G   �� *MaxTotalFat+]� 5E   
   ��.  .+�5F      �� $
��Left=�6   $��Max Total Fat (g)��6+   �� 5G      $��Right=�6   ��6,   �� $ Value�$ 	FatSlider��5H      5I   
   �� 5K   	   $��71��6   .+�5L   
   �� -   5        $	 SugarSlider��5L      $��51��6&   $
 
Horizontal=�62   $ 10Q�6K    . $ 0Q�5M      $	 550Q�6   #��[ 6+    5N      �� *	MaxSugars+]� 5O   
   ��.  .+�5P      �� $
��Left=�6   $��Max Sugars (g)��6+   �� 5Q      $��Right=�6   ��6,   �� $ Value�$ SugarSlider��5R      5S   
   �� 5T   	   $��71��6   .+�5U   
   �� -   5        $	 CholesSlider��5U      $��51��6'   $
 
Horizontal=�63   $ 5Q�6L    . $ 0Q�5V      $	 100Q�6   #��[ 6+    5W      �� *MaxCholesterol+]� 5X   
   ��.  .+�5Y      �� $
��Left=�6   $��Max Cholesterol (mg)��6+   �� 5Z      $��Right=�6   ��6,   �� $ Value�$ CholesSlider��5[      5\   
   �� 5_   	   $��71��6   .+�5`   
   �� -   5        $	 FiberSlider��5`      $��51��6&   $
 
Horizontal=�62   $ 10Q�6K    . $ 0Q�5a      $	 100Q�6   #��[ 6+    5b      �� *
MaxFiber+]� 5c   
   ��.  .+�5d      �� $
��Left=�6   $��Max Fiber (g)��6+   �� 5e      $��Right=�6   ��6,   �� $ Value�$ FiberSlider��5f      5g   
   �� 5h   	   $��71��6   .+�5i   
   �� -   5        $	 ProteinSlider��5i      $��51��6(   $
 
Horizontal=�64   $ 10Q�6M    . $ 0Q�5j   ,   $	 500Q�68   #��[ 5k       6G   �� *
MaxProtein+]� 5l   
   ��.  .+�5m      �� $
��Left=�6   $��Max Protein (g)��6+   �� 5n      $��Right=�6   ��6,   �� $ Value�$ ProteinSlider��5o      5p   
   5q   	   5r      5s      5t      5u      5w      5x      