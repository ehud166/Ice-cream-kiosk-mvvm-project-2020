   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:IceCreamKiosk.ControlsIceCreamKiosk.Controls  5      C&clr-namespace:IceCreamKiosk.ConvertersIceCreamKiosk.Converters  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5   	   7    1IceCreamKiosk.Controls.IceCreamInformationControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:IceCreamKiosk.Controls     5      =
converters&clr-namespace:IceCreamKiosk.Converters     5      `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	        � DataContext  5
      ��    Locator �� Source# [   �� Path$ IceCreamInformation�.��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost    MaterialDesignDivider#���  6$      DialogContent 5      � 5      $��Center=�6   .+�5      �� $��15q�6"   .+�5      �� $��0��6    $	��150��60   $	��150��6<   $��2q�6I   ��6T   �� *	QrImage+6q   �� 5      
�������$	��200��66   $��	75 10 0 0q�6B   $��20(�6U   $��Center=�6c   $��	Dont melt)�6�   $
��Wrap=�6�   scan to your phone5      �� 5         CloseDialogCommand#��Z 6!     MaterialDesignFlatButton#���  6c   $��4q�6�   $��Center=�6�   .��6�   accept5      5      5      .��5      �  � 	Resources 5      <   6IceCreamKiosk.Converters.SocailMediaUrlToIconConverter  SocialMediaUrlToIcon��%   &	         5      6?   5       � ColumnDefinitions 5       �� 5!      �� 5"      .+�5$      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  $�� 0q�66   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6C   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:1.2X�.��5&      �� $	��450��6!   .+�5'      �� $��	Ice cream��6'   $	��300��6:     MaterialDesignCardGroupBox#���  6H   ��5(   "   �� 5)   &   .R�5*   *   ]� ��.  .+�5+   .   ��  # MaterialDesignHeadlineTextBlock#��[ 68   $
��Left=�6q   $��0,0,10,0q�6�   $��Center=�6�   $
��Bold"�6�   ��6�   �� '  !MaterialDesignThemes.Wpf.PackIcon  5,   .   $��Right=�6F   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]	   Kind$	 IceCream=�6]   $��32��6m   $��32��6z   $��Center=�6�   5-   +   5.   '   .��50   "   �  51   &   �� 52   *   �� 53   *   $
��auto �6;   .+�55   &   ]� .+�56   *   �� $
��Wrap=�64   $	��Top=�6H      MaterialDesignTitleTextBlock#��[ 6]   $	��Top=�57   I   ��6#   �� *IceCream.Description+6I   59   '   �� 5:   &   $��1��61   .+�5;   *   �� $	��180��63   $	��180��6@   $��5 5 20 0q�6L   $��UniformToFill=�6_   
 � ToolTip
 6w   �� *IceCream.Name+��5<   .   �� 5=   2   $ IceCream.Image�6:    �� TargetNullValue 5>   6   ��5?   :   3/pack://application:,,,/Assets/no-image-icon.png��6w   5A   3   5C   +   %  MaterialDesignThemes.Wpf.Badged  5D   *   $��Center=�6@   $��0 10 0 0q�6]      BadgeColorZoneMode$ Light=�6�   	  ControlzEx.BadgedEx 	  Badge 6o   0
  *MaterialDesignThemes.Wpf.PackIconExtension
  *STAR+.��5E   .   �� $��RATE ME��65    $  MaterialDesignRaisedAccentButton#��[ 6H   
��� ���
��� �����6�   �� *RateCommand+��6�   �� *
IceCream+5F   +   5G   '   5H   #   5I      9� 5K   "   -   5         9�Name$ NutriExpender��5K   +   $��Stretch=�6B    9� 
IsExpanded .  ��5M   "   �� 5N   &    �� 
TargetType" 9�6,     MaterialDesignExpander �� BasedOn# [ 6K    �� Triggers 5O   *   �� 5P   .    �� Binding 6:   ��  �� ElementName$ ReviewExpender��$ 
IsExpanded� �� Value True6z   .a�5Q   2   ��  �� Property �@9�
IsExpanded �� Value .  6O   5R   /   5T   '   ��5V   "   ]� 5W   &   ��.  .+�5X   *   �� $��Right=�65   $��Center=�6M    %	 !MaterialDesignSubheadingTextBlock#��[	 6h   $��Nutrients per 100g��6�     5Y   *   $
��Left=�6D   $	 TagTextOutline=�6Z   $��32��6p   $��32��6}   $��Center=�6�   5Z   '   .��5\   "   �� $	��120��6/   .��5^   &   �� $	��300��61   .+�5_   *   ]� $
��0 10q�64   ��.  .+�5`   .   �� $
��Left=�68   $��Energy��6O   �� 5a   .   $��Right=�69   $
��kcal��6Q   �� 5b   .   $��Right=�68   $	��5 0q�6O   ��6\   �� *IceCream.Nutrients.Energy+5c   +   ]� 5e   *   $
��0 10q�64   ��.  .+�5f   .   �� $
��Left=�68   $��Carbohydrate��6O   �� 5g   .   $��Right=�68   $��g��6Q   �� 5h   .   $	��5 0q�68   $��Right=�6E   ��6^   �� *!IceCream.Nutrients.Carbohydrate+5i   +   ]� 5k   *   $
��0 10q�64   ��.  .+�5l   .   �� $
��Left=�68   $��TotalFat��6N   �� 5m   .   $��Right=�68   $��g��6O   �� 5n   .   $��Right=�68   $	��5 0q�6O   ��6\   �� *IceCream.Nutrients.TotalFat+5o   +   ]� 5q   *   $
��0 10q�64   ��.  .+�5r   .   �� $
��Left=�68   $��Cholesterol��6N   �� 5s   .   $��Right=�68   $��mg��6O   �� 5t   .   $��Right=�68   $	��5 0q�6O   ��6\   �� * IceCream.Nutrients.Cholesterol+5u   +   ]� 5w   *   $
��0 10q�64   ��.  .+�5x   .   �� $
��Left=�69   $��Sugars��6O   �� 5y   .   $��Right=�69   $��g��6Q   �� 5z   .   $��Right=�69   $	��5 0q�6P   ��6^   �� *IceCream.Nutrients.Sugars+5{   +   ]� 5}   *   $
��0 10q�64   ��.  .+�5~   .   �� $
��Left=�68   $��Protein��6N   �� 5   .   $��Right=�6:   $��g��6R   �� 5�   .   $��Right=�69   $	��5 0q�6P   ��6]   �� *IceCream.Nutrients.Protein+5�   +   ]� 5�   *   $
��0 10q�64   ��.  .+�5�   .   �� $
��Left=�69   $��Fiber��6O   �� 5�   .   $��Right=�69   $��g��6Q   �� 5�   .   $��Right=�69   $	��5 0q�6P   ��6]   �� *IceCream.Nutrients.Fiber+5�   +   5�   '   5�      5�   $   9� 5�      -   5        $ ReviewExpender��5�   #    . $��Stretch=�6M   ��5�   "   �� 5�   &   " 9�6,   # [ 6K    5�   *   �� 5�   .    6:   �� $ NutriExpender��$ 
IsExpanded�	 False6y   .a�5�   2   ��  �@9�
IsExpanded . 6O   5�   /   5�   '   ��5�   "   ]� 5�   &   ��.  .+�5�   *   �� $��Right=�65   $��Center=�6M   #��[	 6h   $��Reviews��6�   (  "MaterialDesignThemes.Wpf.RatingBar  5�   *   -   5          Name$ ReadOnlyRatingBar��5�   �   ���#fdd835���#fdd835   
IsReadOnly .    Value 6m   �� *IceCream.Rate+6�   �� 5�   *   $
��Left=�64   $��10 0 0 0q�6z   $��Center=�6�   ��6J   �� *IceCream.Rate+ �� StringFormat$ N2��6�   5�   '   .��5�      ]� ��.  $	��180��6>   .+�5�   "   ��  &
 "MaterialDesignIconForegroundButton#��[
 6)   $(
 "MaterialDesignIconForegroundButton��6e    J� InputBindings 5�   &   d� 5�   *    d� MouseAction$ 	LeftClicke�67    �� Command 6O   �� *DataContext.LeftButtonClick+.��5�   &     $	 ChevronLeft=�6>   5�   #   �� 5�   "   |�.  $��Visible=�6f   $��Light"�6�   $��14(�6�   ��6<   �� *IceCream.Reviews+��5�   &   �� 5�   *   " ��60   .�5�   .   ��  �@�LayoutTransform 5�   2   �� 5�   6   	transform��6E   5�   /    5�   .   :� 5�   2    :� RoutedEvent$ Loaded��6?   [�5�   6   �� 5�   :   .��5�   >   �� .��5�   B   W�   �� TargetProperty$  Opacity�6R   ! W� From$! 0X�6v   	" W� To$" 1X�6   # g� Duration$# 0:0:2D�6�   W� 5�   B   $  LayoutTransform.ScaleY�6R   $! 0X�6�   $# 0:0:.2D�6�   5�   ?   5�   ;   5�   3   5�   +   ��5�   &   �� 5�   .   .R�5�   .   #  MaterialDesignThemes.Wpf.Card  $	��160��6C   $	��330��6P   $��5q�6\   $��4q�6g   +  %MaterialDesignThemes.Wpf.ShadowAssist$   ShadowDepth$$ Depth1=�5�   :   ���	#FFC3FFC3.��5�   6   ]� ��.  .+�5�   6   �� $	��230��6A   .+�5�   :     $ ReadOnlyRatingBar��6�   $
��Left=�6S   ���#fdd835 .  6   �� *Rate+6�   �� 5�   :   $
��Wrap=�6E   $
��Left=�6Y   $
��5 10q�6p   % �� TextAlignment$% Center=�6�   ��6   �� *	Message+& �� Mode$& TwoWay=�' �� UpdateSourceTrigger$' PropertyChanged=�6�   5�   7   �� 5�   6   $��Right=�6<   $��2q�6S   $��2��6^   $��90��6�   $
��auto��6�   ��6o   �� *Image+6�   5�   7   5�   +   5�   '   5�   '   �� 5�   "   #��[
 6*   $(
 "MaterialDesignIconForegroundButton��6f    5�   &   d� 5�   *   $ 	LeftClicke�67    6O   �� *DataContext.RightButtonClick+.��5�   &     $	 ChevronRight=�6>   5�   #   5�      5�      5�      5�        5�      $��	60 0 20 0q�66   $��1��6I    6Y     *SlideInFromRight+$ 0:0:1.2X�.��5�        $	��600��6.   .��5�      �� $	��600��6#   $	��Top=�60   $��1��6H     MaterialDesignGroupBox#���  6~   ��6X   �� *IceCream.Shop.Name+��5�      �� 5�   "   .R�5�   &   ]� ��.  .+�5�   *   �� #��[ 64   $
��Left=�6m   $��0q�6�   $��Center=�6�   $
��Bold"�6�   ��6�   ��   5�   *   $��Right=�6B   $	 Store=�6Y   $��32��6f   $��32��6s   $��Center=�6   5�   '   5�   #   .��5�      � ( � RowDefinitions( 5�   "   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   .+�5�   "   �  5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� $��1��6.   $��2q�6>   $	��180��6I   ��5�   *   �� 5�   .   $ IceCream.Shop.Image�66    5�   2   ��5�   6   3/pack://application:,,,/Assets/no-image-icon.png��6t   5�   /   5�   '   �� 5�   &   $��0��61   $��5q�6A   .+�5�   *   �� $	��0 7q�65   $��Center=�6B   ) �� Orientation$) 
Horizontal=�6]   .+�5   .     $��Center=�6F   $	 PhoneClassic=�6a   �� 5  .   #��[	 69   $��5 0 5 0q�6t   ��6�   �� *IceCream.Shop.PhoneNumber+5  +   �� 5  *   $	��0 7q�65   $��Center=�6B   $) 
Horizontal=�6^   .+�5  .     $��Center=�6F   $	 HouseMapMarker=�6a   �� 5  .   -   5        * ��Name$* ShopAddress��5  8   #��[	 6M   $��5 0 5 0q�6�   ��6�   �� *IceCream.Shop.Address+5  +   �� 5  *   -   5        $	��0 7q�5  5   $��Center=�6B   $) 
Horizontal=�6^   .+�5  .   �� $��24��65   $��24��6A    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6L   $
 Website��6�   .��5	  2     $		 Web=�6J   5
  /   �� 5  .   #��[	 68   $��5 0 5 0q�6s   ��6�   �� *IceCream.Shop.WebSiteLink+5  +   �� 5  *   -   5        $	��0 7q�5  5   $��Center=�6B   $) 
Horizontal=�6^   .+�5  .   �� $��24��66   $��24��6B   #��[ 6M   $2
 ,MaterialDesignFloatingActionMiniAccentButton��6�   .��5  2     $��Center=�6J   	 6e   �� *IceCream.Shop.SocialMediaLink++ �� 	Converter#+ [ 5  /   �� 5  .   -   5        $* SocailMediaLink��5  8   #��[	 6Q   $��5 0 5 0q�6�   ��6�   �� *IceCream.Shop.SocialMediaLink+5  +   �� 5  *   $	��0 7q�66   $��Center=�6C   $) 
Horizontal=�6^   .+�5  .   �� -   5        , ��Name$, 
WazeButton��5  [   $
��30 0q�66   $��30��6D   $��30��6P   #��[ 6p   $

 WAZE��6�   .��5  2   �� $��waze.png��69   5  /   �� 5  .   $��30��65   $��30��6A   -   OpenDialogCommand#��Z- 6M   #��[ 6�   $
 RQ Map��6�   .��5  2     $��Center=�6J   $	 
QrcodeScan=�6e   5  /   5  +   5  '   5  #   � 5  "   $��1��6'   .+�5  &   '  !Microsoft.Maps.MapControl.WPF.Map  -	   5        .  Name$	. Map��5  ,   $��0 2 0 0q�69   $	��300��6J   +  %Microsoft.Maps.MapControl.WPF.MapCore/   	ZoomLevel$/ 16Q�6W   $��Stretch=�6g   $��Stretch=�6�   0   ScaleVisibility$0 	Collapsed=�5   H   1   CredentialsProvider1 6   �� *BingMapsKey+ 5!  *   +  %Microsoft.Maps.MapControl.WPF.Pushpin  LabelPushpinStyleB  <Microsoft.Maps.MapControl.WPF.Design.PositionOriginConverter��%  &	       �� 5"  .   "  64   .�5#  2   ��  �@�OverridesDefaultStyle . 6Z   �� 5$  2    �@ PositionOrigin$ Center 6S   �� 5%  2    � ��
 ���� 6O   �� 5&  2    � ��
 ���� 6P   �� 5'  2    � ��$ 0q�6T   5(  /   5*  +   2   Children.2 5+  *   3  -Microsoft.Maps.MapControl.WPF.MapItemsControl  ��6<   �� *Route+$& TwoWay=�$' PropertyChanged=�  5,  *   ��6<   �� *	Locations+��5-  .   �� 5.  2   .R�5/  6     #��[ 6�   3   Location3 6@   �� *BingLocation+��6c   �� *	Address+��50  :   �� 51  >   .R�52  B   �� .+�53  F   �� 4 �� Left$4 30��6M   
5 �� Top$	5 -20��6^   $	��100��6o   $��52��6{   
�������6 J� Opacity$6 1Q�54  E   7 J� Effect7 55  J   3  -System.Windows.Media.Effects.DropShadowEffect  56  N   8   Color$8 	LightGray��6_   ._�58  J   �� $��Center=�6U   $��Center=�6p   .+�59  N   �� $	��4 0q�6X   $��12(�6{   ��6e   �� *Name+6{   �� 5:  N   $	��4 0q�6X   $
��Wrap=�6e   $��12(�6�   ��6y   �� *	Address+6�   5;  K   5<  G   F� 5>  F   F����        р�� �H�р�� ���р�� ���р�� H�р�� H�р�� ���	$��2��6�   
���iii�6�   A� 5?  F   $5 -4��6N   $4 -4��6^   $��8��6o   $��8��6y   
��� ���
���iii�6�   5@  C   5A  ?   5C  7   5D  3   5F  +   5H  '   ]� 5I  &   ��.  $��Stretch=�6F   .+�5J  *   �� $
��Left=�65   $��0 2 0 0q�6K   ���#bbdefb$	��Top=�6q   $
��Left=�6�   $) 
Horizontal=�6�   .+�5K  .   	�    MaterialDesignTabRadioButton#��[ 6\   $��4q�6�   9 d� 	IsChecked$
9 TrueY�6�   ��6:   �� *FindWalkRoute+.��5L  2     $
	 Walk=�6K   5M  /   	� 5N  .   #��[ 6[   $��4q�6�   $9 FalseY�6�   ��6:   �� *FindCarRoute+.��5O  2     $	 CarBack=�6K   5P  /   5R  +   5S  '   5U  #   5V     5W     5X     5Y     �� 5Z     $��0��6   7  1MaterialDesignThemes.Wpf.Transitions.Transitioner:   MovePreviousCommand#��Z: 6)   $
��Left=�5[     $��Bottom=�60   $��
-200 0 0 0q�6K    + 'MaterialDesignFloatingActionLightButton#��[ 6_   .��5\       $	 StepBackward=�6.   $��24��6B   $��24��6N   5]     5_     5`     5a     5b     