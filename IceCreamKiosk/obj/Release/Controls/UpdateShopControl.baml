   M S B A M L   `   `   `  ����   IceCreamKiosk.    (IceCreamKiosk.Controls.UpdateShopControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     � DataContext  ��    Locator �� Source# [   �� Path$ 
UpdateShop� � 	Resources &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�   '        �� "  .���  �@ RowHeaderWidth$ 0Q��� % �@ HorizontalScrollBarVisibility$ Disabled=���  � �� �� "  .R��� 
���  ��$ 5��.���� 
������ 	 J� Opacity$		 0.9Q�.+��� $��UpdateShop Details��
 �� Padding$
 5 0 0 0q�$��5q�$��40��
�������
�������$��ExtraExpanded&�$
��Wrap=�$
��Bold"�$��24(�� $
��20 5q�
������� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� �� �� .+��� $	��0 5q�$y�	Collapsed=�{�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Id�� % !MaterialDesignFloatingHintTextBox#��[ ���� $ Id��� $��30(�$
��auto��   
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��$��5q�
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�$��5q�$
 Name��#��[ $
��Bold"����� $
 Name�.������  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$
 0.52Q�� $ 	LightGray��.���� $��1�� �� Orientation$ 
Horizontal=�.+��� $	��170��$��1q�
�������
 �����$ 5��$��5q�$ Address��#��[ $
��Bold"����� *	Address+.������ $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ Black��$
 0.52Q�� $ 	LightGray��.���� $	��145��$��1q�
 �����$ 5��
�������$��5q�$ Phone Number��#��[ $
��Bold"����� *PhoneNumber+.������ $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ Black��$
 0.52Q�� $ 	LightGray��.���� $��1��$��1��$ 
Horizontal=�.+��� $	��140��
 �����$ 5��$��1 q�
�������$��5q�$ Web Site Link��#��[ $��2��$
��Bold"����� *WebSiteLink+.������ $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ Black��$
 0.52Q�� $ 	LightGray��.���� $	��180��
 �����$ 5��$��1q�
�������$��5q�$ Social Media Link��#��[ $
��Bold"����� *SocialMediaLink+.������ $ 0.5,1&�$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ Black��$
 0.52Q�� $ 	LightGray��.���� $��2��$ 
Horizontal=�
������ $��Center=�.+���  " MaterialDesignFlatDarkBgButton#��[ 
������ 
������ $��2q�$��0q�$��40��$��40��$
��Left=����� *GetImageFromFile+���� *
ImageUri+.��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ UploadOutline=�
������ $��35��
���   �$��35��
������ �� $��	1 0 1 -10q�
������ $��Center=�.+��� $��70��$
��auto��$��0q����� $ Image� �� TargetNullValue ��3/pack://application:,,,/Assets/no-image-icon.png���� -    ��Name$ ImageUri��$y�	Collapsed=�$ 	Image Uri��#��[ ���� *
ImageUri+�� #��[ $y�	Collapsed=�$��0q�$��25��$��Right=����� *GetImageFromUri+���� *
ImageUri+.��  $ DownloadOutline=��� -    ��Name$ ErrorTextBlock��$
��Left=�$
��Wrap=�
���  ������ *ErrorMassage+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�y��� *ErrorMassageVisability+$ TwoWay=�$ PropertyChanged=��� $��UpdateShop Ice Creams��$
 20 0 0 0q�$��5 0 5 0 q�$��40��
�������
�������$��ExtraExpanded&�$
��Wrap=�$
��Bold"�$��24(��� $��Center=�
������ .+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  $�� 0q�C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D	  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension	  *SlideInFromLeft+ 	  Duration$ 0:0:1.2X�.���� $	��400��.��  
������ $��0q�   CanUserSortColumns .     CanUserAddRows  .  !   AutoGenerateColumns! .  "   RowBackground
" �����#   AlternatingRowBackground# �#fdd835-
  'MaterialDesignThemes.Wpf.DataGridAssist$ 
  CellPadding$$ 	10 10 2 0q�% 
  ColumnHeaderPadding$% 4 2 2 2q�&   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$& *   MaterialDesignDataGrid#��[ ���� *	IceCreams+' �� SelectedItem' �� *SelectedIceCream+(   	CellStyle( �� *  $System.Windows.Controls.DataGridCell"  ) �� Triggers) P� * P� Property* �@ 
IsSelected+ P� Value+ . . ���  � �� �� , �� Color$, Transparent����  � ��# � ����  � �� �� $, Transparent��-   RowStyle- �� )  #System.Windows.Controls.DataGridRow"  .���  � ��$
  4 6q���  �@J�BitmapEffect F� . F� ShadowDepth$	. 0.2Q�/   Columns/ 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn0   Header$
0 Name��1   Width$	1 100 1  +System.Windows.Controls.DataGridBoundColumn2   Binding2 �� *Name+3   ElementStyle3 �� " ��.���  � ��$ 5q���  �@��Padding$ 5 10 0 0q�4  .System.Windows.Controls.DataGridTemplateColumn  $1 60 $0 Image��4   CellTemplate4 �� .R��� $ 
Horizontal=�.+��� #��[ 
������ 
������ $��2q�$��0q�$��40��$��40������ 5 �� RelativeSource5 �� 6 �� AncestorType"6 >�$* $DataContext.GetIceCreamImageFromFile����� .��  $ UploadOutline=�
������ $��35��$��35��
��������� $��40��$��0������ *Image+$ TwoWay=�$ PropertyChanged=�  $0   Description��$	1 380 2 �� *Description+3 �� " ��.���  � ��$ 5q���  �@��Padding$ 5 10 0 0q�=  7MaterialDesignThemes.Wpf.MaterialDataGridComboBoxColumn  7   
Visibility$7 Hidden=�$1 0 $
0 Rate��4  .System.Windows.Controls.DataGridComboBoxColumn8   SelectedValueBinding8 �� *Rate+9   ItemsSourceBinding9 �� 5 �� *FindAncestor+"6  $ DataContext.Rates�  $1 45 $0  ��4 �� .R���  # MaterialDesignFlatLightBgButton#��[ 
������ 
������ $��2q�$��0q�$��40��$��40������ 5 �� "6  $' !DataContext.DeleteIceCreamCommand����� .��  $ DeleteCircleOutline=�
������ $��35��$��35��
���������  . *MaterialDesignFloatingActionMiniDarkButton#��[ ���#1de9b6���#1de9b6$��
0 -20 0 10q�$��Center=�: � ToolTip$: Add New Ice cream������ *AddIceCreamCommand+.��  $
 Plus=��� -   ; ��Name$; 	AddButton��$��0 -5 0 5q�
�������$��ExtraExpanded&�$
��Bold"�$��24(�
�������$��40��$	��300�� # MaterialDesignRaisedLightButton#��[ 3  -MaterialDesignThemes.Wpf.ButtonProgressAssist<   Value$< -1Q�=   IsIndeterminate= . ���� *ShopButtonText+>   IsIndicatorVisible> �� *	Running+$ TwoWay=�$ PropertyChanged=����� *ShopCommand+