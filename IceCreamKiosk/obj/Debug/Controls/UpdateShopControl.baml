   M S B A M L   `   `   `  ����  IceCreamKiosk.    (IceCreamKiosk.Controls.UpdateShopControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        � DataContext  5	      ��    Locator �� Source# [   �� Path$ 
UpdateShop� � 	Resources 5
      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%'  '        �� 5   
   "  6   .�5      ��  �@ RowHeaderWidth$ 0Q�6/   �� 5      % �@ HorizontalScrollBarVisibility$ Disabled=�6>   �� 5       � �� 5      �� 5      "  6&   .R�5      �� 
���  ��$ 5��62   5      5      5      5      5      .��5      �� 
������ 	 J� Opacity$		 0.9Q�6*   .+�5   
   �� $��UpdateShop Details��6   
 �� Padding$
 5 0 0 0q�6.   $��5q�6@   $��40��6K   
�������
�������$��ExtraExpanded&�6|   $
��Wrap=�6�   $
��Bold"�6�   $��24(�6�   6�   � 5!      $
��20 5q�6   
������� � ColumnDefinitions 5"      �� 5#      $��* �6'   �� 5$      $��* �6'    � RowDefinitions 5&      �� 5'      �� 5(      �� 5)      .+�5-      �� $	��0 5q�63   $y�	Collapsed=�6@   {�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Id��6i    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� $ Id�6�   �� 5/      $��30(�65   $
��auto��6C      
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��6~   $��5q�6�   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6�   $��5q�6  $
 Name��6  #��[ 69  $
��Bold"�6t  ��6   �� $
 Name�.��6�  ��50      �� 51       �� EndPoint$ 0.5,1&�6.    � MappingMode$ RelativeToBoundingBox=�6?    �� 
StartPoint$ 0.5,0&�6c   .��52      �  � Color$ Black��6+    � Offset$
 0.52Q�69   � 53      $ 	LightGray��6+   54      .��55   *   57      �� 58      $��1��6    �� Orientation$ 
Horizontal=�6*   .+�59      �� $	��170��67   $��1q�6C   
�������
 �����$ 5��6�   $��5q�6�   $ Address��6�   #��[ 6�   $
��Bold"�68  ��6   �� *	Address+.��6J  ��5:      �� 5;      $ 0.5,1&�62   $ RelativeToBoundingBox=�6C   $ 0.5,0&�6g   .��5<   "   � $ Black��6/   $
 0.52Q�6=   � 5=   "   $ 	LightGray��6/   5>      .��5?   .   5@      �� 5A      $	��145��6<   $��1q�6H   
 �����$ 5��6�   
�������$��5q�6�   $ Phone Number��6�   #��[ 6  $
��Bold"�6A  ��6   �� *PhoneNumber+.��6T  ��5B      �� 5C      $ 0.5,1&�62   $ RelativeToBoundingBox=�6C   $ 0.5,0&�6g   .��5D   "   � $ Black��6/   $
 0.52Q�6=   � 5E   "   $ 	LightGray��6/   5F      .��5G   .   5H      5I      �� 5J      $��1��6   $��1��6+   $ 
Horizontal=�6;   .+�5K      �� $	��140��6   
 �����$ 5��6t   $��1 q�6�   
�������$��5q�6�   $ Web Site Link��6�   #��[ 6  $��2��6B  $
��Bold"�6V  ��6*   �� *WebSiteLink+.��6i  ��5L      �� 5M      $ 0.5,1&�62   $ RelativeToBoundingBox=�6C   $ 0.5,0&�6g   .��5N   "   � $ Black��6/   $
 0.52Q�6=   � 5O   "   $ 	LightGray��6/   5P      .��5Q   .   5R      �� 5S      $	��180��6   
 �����$ 5��6x   $��1q�6�   
�������$��5q�6�   $ Social Media Link��6�   #��[ 6  $
��Bold"�6J  ��6*   �� *SocialMediaLink+.��6\  ��5T      �� 5U      $ 0.5,1&�62   $ RelativeToBoundingBox=�6C   $ 0.5,0&�6g   .��5V   "   � $ Black��6/   $
 0.52Q�6=   � 5W   "   $ 	LightGray��6/   5X      .��5Y   .   5Z      5[      �� 5\      $��2��6   $ 
Horizontal=�6-   
������ $��Center=�6_   .+�5]      ��  " MaterialDesignFlatDarkBgButton#��[ 6   
������ 
������ $��2q�6�   $��0q�6�   $��40��6�   $��40��6�   $
��Left=�6  ��6�   �� *GetImageFromFile+��6�   �� *
ImageUri+.��5^      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ UploadOutline=�62   
������ $��35��6`   
���   �$��35��6~   
������ 6�   5_      �� 5`      $��	1 0 1 -10q�6!   
������ $��Center=�6M   .+�5a      �� $��70��6"   $
��auto��6.   $��0q�6;   ��5b      �� 5c   "   $ Image�6*    �� TargetNullValue 5d   &   ��5e   *   3/pack://application:,,,/Assets/no-image-icon.png��6g   5g   #   5i      �� 5j      -   5         ��Name$ ImageUri��5j   "   $y�	Collapsed=�64   $ 	Image Uri��6f   #��[ 6�   ��6L   �� *
ImageUri+6�   5l      �� 5n      #��[ 6   $y�	Collapsed=�6V   $��0q�6m   $��25��6z   $��Right=�6�   ��6�   �� *GetImageFromUri+��6�   �� *
ImageUri+.��5o        $ DownloadOutline=�62   5p      5q      5r      �� 5s   
   -   5         ��Name$ ErrorTextBlock��5s      $
��Left=�6,   $
��Wrap=�6G   
���  ����6[   �� *ErrorMassage+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�y�5t      �� *ErrorMassageVisability+$ TwoWay=�$ PropertyChanged=�6x   �� 5u      $��UpdateShop Ice Creams��6   $
 20 0 0 0q�65   $��5 0 5 0 q�6H   $��40��6Z   
�������
�������$��ExtraExpanded&�6�   $
��Wrap=�6�   $
��Bold"�6�   $��24(�6�   6�   �� 5v   
   $��Center=�6   
������ .+�5w      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  $�� 0q�62   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6?   D	  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension	  *SlideInFromLeft+ 	  Duration$ 0:0:1.2X�.��5x      �� $	��400��6   .��5y        
������ $��0q�6:      CanUserSortColumns .     CanUserAddRows  .  !   AutoGenerateColumns! .  "   RowBackground
" �����#   AlternatingRowBackground# �#fdd835-
  'MaterialDesignThemes.Wpf.DataGridAssist$ 
  CellPadding$$ 	10 10 2 0q�5|   d   % 
  ColumnHeaderPadding$% 4 2 2 2q�5}      &   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$& * 6I     MaterialDesignDataGrid#��[ 5~      ��5y   F   �� *	IceCreams+' �� SelectedItem' 5z      �� *SelectedIceCream+(   	CellStyle( 5      �� 5�      *  $System.Windows.Controls.DataGridCell"  6$   ) �� Triggers) 5�   "   P� 5�   &   * P� Property* �@ 
IsSelected+ P� Value+ . . �5�   *   ��  � �� 5�   .   �� 5�   2   , �� Color$, Transparent��6B   5�   +   �� 5�   *    � ��# � ��5�      �� 5�   *    � �� 5�   .   �� 5�   2   $, Transparent��6B   5�   +   5�   '   5�      -   RowStyle- 5�      �� 5�      )  #System.Windows.Controls.DataGridRow"  6$   .�5�   "   ��  � ��$
  4 6q�6;   �� 5�   "    �@J�BitmapEffect 5�   &   F� 5�   *   . F� ShadowDepth$	. 0.2Q�6A   5�   #   5�      /   Columns/ 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn0   Header$
0 Name��6K   1   Width$	1 100 6Y   1  +System.Windows.Controls.DataGridBoundColumn2   Binding2 62   �� *Name+3   ElementStyle3 5�   "   �� 5�   &   " ��6,   .�5�   *   ��  � ��$ 5q�6C   �� 5�   *    �@��Padding$ 5 10 0 0q�6D   5�   '   5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $1 60 65   $0 Image��6@   4   CellTemplate4 5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� #��[ 65   
������ 
������ $��2q�6�   $��0q�6�   $��40��6�   $��40��6�   ��5�   )   �� 5 �� RelativeSource5 �� 6 �� AncestorType"6 >�$* $DataContext.GetIceCreamImageFromFile���6�   �� .��5�   2     $ UploadOutline=�6J   
������ $��35��6x   $��35��6�   
�������6�   5�   /   �� 5�   .   $��40��6   $��0��6�   ��64   �� *Image+$ TwoWay=�$ PropertyChanged=�6�   5�   +   5�   '   5�        5�      $0   Description��6S   $	1 380 6k   2 62   �� *Description+3 5�   "   �� 5�   &   " ��6,   .�5�   *   ��  � ��$ 5q�6C   �� 5�   *    �@��Padding$ 5 10 0 0q�6D   5�   '   5�      =  7MaterialDesignThemes.Wpf.MaterialDataGridComboBoxColumn  5�      7   
Visibility$7 Hidden=�6L   $1 0 6`   $
0 Rate��6j   4  .System.Windows.Controls.DataGridComboBoxColumn8   SelectedValueBinding8 6x   �� *Rate+9   ItemsSourceBinding9 5�      �� 5 �� *FindAncestor+"6  $ DataContext.Rates�  5�      $1 45 65   $0  ��6@   4 5�   "   �� 5�   &   .R�5�   *   ��  # MaterialDesignFlatLightBgButton#��[ 61   
������ 
������ $��2q�6�   $��0q�6�   $��40��6�   $��40��6�   ��6�   �� 5 �� "6  $' !DataContext.DeleteIceCreamCommand���5�   X   �� .��5�   .     $ DeleteCircleOutline=�6F   
������ $��35��6z   $��35��6�   
�������6�   5�   +   5�   '   5�      5�      5�      5�      �� 5�       . *MaterialDesignFloatingActionMiniDarkButton#��[ 6   ���#1de9b6���#1de9b6$��
0 -20 0 10q�6�   $��Center=�6�   : � ToolTip$: Add New Ice cream��6�   ��6�   �� *AddIceCreamCommand+.��5�        $
 Plus=�6*   5�      5�      �� 5�   
   -   5        ; ��Name$; 	AddButton��5�      $��0 -5 0 5q�6$   
�������$��ExtraExpanded&�6l   $
��Bold"�6�   $��24(�6�   
�������$��40��6�   $	��300��6�    # MaterialDesignRaisedLightButton#��[ 5�      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist<   Value$< -1Q�5�      =   IsIndeterminate= . ��5�   6   �� *ShopButtonText+>   IsIndicatorVisible> 5�      �� *	Running+$ TwoWay=�$ PropertyChanged=���5�      �� *ShopCommand+5�      5�      5�      