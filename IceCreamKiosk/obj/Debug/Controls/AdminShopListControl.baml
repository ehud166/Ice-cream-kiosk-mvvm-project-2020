   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:IceCreamKiosk.ControlsIceCreamKiosk.Controls  5      C&clr-namespace:IceCreamKiosk.PropertiesIceCreamKiosk.Properties  5      1    +IceCreamKiosk.Controls.AdminShopListControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:IceCreamKiosk.Controls     5      =
properties&clr-namespace:IceCreamKiosk.Properties     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � DataContext  5
      ��    Locator �� Source# [   �� Path$ AdminShopList� � 	Resources 5        ImagesButtonTemplate��%o   &	       �� 5   
   .R�5      �� $��75��62   $
��auto��6>   ��6   �� $ Image�6>   5      5      .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  $�� 0q�6*   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 67   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromTop+   Duration$ 0:0:1.2X�.��5   
   � 
������ .+�5   
   �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	ShopsGrid��5      -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 5q�6+   $��15q�6Z   
���OO/�   	RowHeight$ 95Q�6�   |�.  	   RowBackground
	 �����
   AlternatingRowBackground
 �#fdd835$ �� IsSynchronizedWithCurrentItem$
 TrueY�6�      CanUserSortColumns .    
IsReadOnly .    SelectionUnit$ FullRow=�5   ?      CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 5   +      AutoGenerateColumns .  
������    HeadersVisibility$
 None=�6�   $��Center=�6�      SelectionMode$ Single=�6�      CanUserResizeRows .  $
��Bold"�6   J� Opacity$
 0.85Q�6  ��5   �   �� *Shops+ �� SelectedItem 5   [   �� *SelectedShop+   	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5      P� 5       P� Property �@ 
IsSelected P� Value . . �5   "   ��  �� Property � �� �� Value 5   &   �� 5   *    �� Color$ Transparent��6:   5!   #   �� 5$   "    � ��# � ��5%      �� 5'   "    � �� 5(   &   �� 5)   *   $ Transparent��6:   5+   #   5,      5.         RowStyle 51      �� 52      )  #System.Windows.Controls.DataGridRow"  6   .�53      ��  � ��$  9q�63   �� 54       �@J�BitmapEffect 55      F� 56   "     F� ShadowDepth$  3Q�69   59      �� 5:       � �� 5;      �� 5<   "   ! �� 
TargetType"!  62   .R�5=   &   �� " ��Name$" 
DGR_Border��6-   #��z��6A   #��z��5>   )   #��z��5?   )   # J� SnapsToDevicePixels# . $ �� CornerRadius$$ 10��5A   )   ._�5B   *   ?	  9System.Windows.Controls.Primitives.SelectiveScrollingGrid	  % � ColumnDefinitions% 5C   .   �� 5D   2   $
��Auto �6C   �� 5E   2   $��* �6C   & � RowDefinitions& 5G   .   �� 5H   2   $��* �6@   �� 5I   2   $
��Auto �6@   .+�5K   .   ?
  9System.Windows.Controls.Primitives.DataGridCellsPresenter
  $��1��6E   '   
ItemsPanel#��z' 6U   ## z# 6   A  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter  5L   .   $��1��6G   $��1��6W   (   DetailsVisibility#y�z( 6{  $) 	  SelectiveScrollingOrientation) 6d   �� *AreRowDetailsFrozen+;  5System.Windows.Controls.SelectiveScrollingOrientation*   Vertical+ �� ConverterParameter#+ Z* #,   RowDetailsScrollingConverter- �� 	Converter#- Z, . �� RelativeSource. �� / �� AncestorType"/  6{  :  4System.Windows.Controls.Primitives.DataGridRowHeader  5M   .   $��2��6@   $) Vertical=�6Q   y�6�   �� *HeadersVisibility+7  1System.Windows.Controls.DataGridHeadersVisibility
0   Row#+ Z0 !1   HeadersVisibilityConverter#- Z1 . �� "/  5N   +   5O   '   5P   #   5R      5T      2 J� InputBindings2 5W      d� 5X      3 d� MouseAction$3 LeftDoubleClicke�6#   4 �� Command4 6A   �� $ EditShopCommand�5 �� CommandParameter5 5Y      �� 6 �� ElementName$6 	ShopsGrid��$ SelectedItem�7   Columns7 5[      0  *System.Windows.Controls.DataGridTextColumn  5]      ,  &System.Windows.Controls.DataGridColumn8   MinWidth$	8 170Q�6)   9   Header$
9 Name��6:   : �� TextAlignment$: Justify=�6c   $��30(�6�   ;   
FontFamily$; Aharoni)�6�   <   
FontWeight$
< Bold"�6�   =   CanUserResize= .  1  +System.Windows.Controls.DataGridBoundColumn>   Binding> 6H   �� *Name+?   ElementStyle? 5^      �� 5_      " ��6$   .�5`   "   ��  � ��$ 5q�6;   �� 5a   "    �@��Padding$ 	10 25 0 0q�6<   5b      5d      4  .System.Windows.Controls.DataGridTemplateColumn  5e      $9 Photo��6-   @   CellTemplate#@ [ 6=     5f      $	8 180Q�6)   $9 Address��6:   $
: Left=�6g   $��20(�6�   > 6K   �� *	Address+? 5g      �� 5h      " ��6$   .�5i   "   ��  � ��$ 5q�6;   �� 5j   "    �@��Padding$ 	10 25 0 0q�6<   5k      5m        5n      $9 Phone��6*   $
: Left=�6Y   $��20(�6x   > 69   �� *PhoneNumber+? 5o      �� 5p      " ��6$   .�5q   "   ��  � ��$ 5q�6;   �� 5r   "    �@��Padding$ 
10 25 10 0q�6<   5s      5u        5v      $9 Web Site��6+   $: Center=�6]   A   
Visibility$A Hidden=�6~   > 6=   �� *WebSiteLink+6~     5w      $9 Social��6*   $: Center=�6^   $A Hidden=�6   > 6:   �� *SocialMediaLink+6     5x      B   Width$B 50 6-   $9  ��68   @ 5y      �� 5z      .R�5{   "   ��  # MaterialDesignFlatLightBgButton#��[ 6)   
������ 
������ $��0q�6�   $��30��6�   $��30��6�   ��6�   �� . �� "/  $# DataContext.DeleteShopCommand���5|   T   �� .��5}   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]C   Kind$C DeleteCircleOutline=�6>   $��25��6Y   $��25��6e   5~   #   5      5�      5�      �� 5�       . *MaterialDesignFloatingActionMiniDarkButton#��[ 6   ���#1de9b6���#1de9b6$��center=�5�   "   $	��Top=�6?   $��	0,-40,0,0q�6W   D � ToolTip$D Add New UpdateShop��6j   $��2��5�   !   $��55��6Q   $��55��6]   ��6.   �� *AddShopCommand+.��5�        $
C Plus=�6*   $��40��66   $��40��6B   5�      5�      � 5�   
   $��Center=�6   $��Bottom=�63    % !MaterialDesignCircularProgressBar#��[ 6N   E � Value$E 75Q�6�   $��	ExtraBold"�6�   F � IsIndeterminateF . $	��100��5�      $	��100��6&   y�5�   �   �� *	Loading+   BooleanToVisibilityConverter#- [ 5�   &   '  !MaterialDesignThemes.Wpf.Snackbar  5�   
   $��Stretch=�6@   G   IsActiveG 6"   �� *
HasError+H   Message.H 5�      .  (MaterialDesignThemes.Wpf.SnackbarMessage  ��6&   �� *ErrorMassage+5�      5�      5�      5�      