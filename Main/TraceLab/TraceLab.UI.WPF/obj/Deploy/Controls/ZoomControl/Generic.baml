   M S B A M L   `   `   `  ���� J  FTraceLab.UI.WPF, Version=0.5.2.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:TraceLab.UI.WPF.Controls.ZoomControl$TraceLab.UI.WPF.Controls.ZoomControl  O KWPFExtensions, Version=1.0.4583.32057, Culture=neutral, PublicKeyToken=nullV;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensionsWPFExtensions.Controls Z=clr-namespace:WPFExtensions.Converters;assembly=WPFExtensionsWPFExtensions.Converters G(clr-namespace:TraceLab.UI.WPF.ConvertersTraceLab.UI.WPF.Converters  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0895   /WPFExtensions.Converters.DoubleToLog10Converter   log10Converter9  3WPFExtensions.Converters.EqualityToBooleanConverter  equalityConverter6   0TraceLab.UI.WPF.Controls.ZoomControl.ZoomControl  �� 
TargetType �� Property �� Value �� 
TargetType1  +WPFExtensions.Controls.ZoomContentPresenter  Name �� Padding �� CornerRadius �� Left
 �� Top	 ^� InitialShowDelay
 �� Orientation � 	Resources ��Name �� Triggers P� Property P� Value �� 
TargetName �� Ticks �� AutoToolTipPlacement �� AutoToolTipPrecision �� TickPlacement �� TickFrequency � LargeChange � SmallChange �� Orientation � Minimum �� 	Converter � Maximum � Value �� RelativeSource �� Path �� Mode  �� 	Converter! �� StringFormat" � ColumnDefinitions# � RowDefinitions$ 	� 	GroupName% d� 	IsChecked-  'WPFExtensions.Controls.ZoomControlModes&   Original' �� ConverterParameter(   Custom) �� FallbackValue*   Fill4  .TraceLab.UI.WPF.Converters.NegateBoolConverter+ ��Name, �� ElementName3   -TraceLab.UI.WPF.Converters.BoolToVisConverter-   ZoomBoxBorderBrush.   ZoomBoxBorderThickness/   ZoomBoxOpacity0 J� Opacity1   ZoomBoxBackground2 �� 
StartPoint3 �� EndPoint4 � Color5 � Offset6 �� Triggers�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     ;zoom2clr-namespace:TraceLab.UI.WPF.Controls.ZoomControl  HControls;clr-namespace:WPFExtensions.Controls;assembly=WPFExtensions  YWPFExtensionsConverters=clr-namespace:WPFExtensions.Converters;assembly=WPFExtensions  7
Converters(clr-namespace:TraceLab.UI.WPF.Converters  %  &	        &	      '  
     7   7   7   7  7       �� "   .���  � �� �� "  .R�� .+��� #��z��#��z��#��z��#}�z}�._�  $ PART_Presenter��}�.  �� .+��� $ 5q�$ 5�����	#88C0C0C0$ 20��$ 20��$	 0��._��� $
 Vertical=� ���� '	�       "  	�.���  � �� �� " 	�.R��� $ border��
���   �
�������$��1q�$ 5��$��20��$��20��$��2q�$��Center=�$��Center=�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ border�� � ��
 �����P�  �@d�	IsChecked$
 TrueY�. ��� $ border�� � ��
 ������� $ border�� � ��$
 Bold"��� '��       "  ��.���  � �� �� " ��.R��� $ border��
���   �
�������$��1q�$ 5��$��20��$��20��$��2q�$��Center=�$��Center=�._��� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ border�� � ��
 �����P�  �@d�	IsChecked$
 TrueY�. ��� $ border�� � ��
 ������� $ border�� � ��$
 Bold"�.+��� $	��150��$��Center=�$- '0.1, 0.25, 0.5, 0.75, 1.0, 1.25, 1.5, 2R�$ BottomRight=�$ 1��$ BottomRight=�$ 1Q�$ 1Q�$	 0.1Q�$ Vertical=� �� *	MinZoom+8    �� *	MaxZoom+8   ��  �� *TemplatedParent+$
 Zoom�$ TwoWay=�8   �� $��Center=�$
��Bold"�����  �� *TemplatedParent+$
 Zoom�$! {0:F2}x��� " �� �� # �� �� �� �� �� .+�	� $��0��$��0��$	��1:1��$$ rbgZoomMode��% ��  �� *TemplatedParent+$
 Mode�8   #' Z& #) Z( 	� $��0��$��1��$
��Fill��$$ rbgZoomMode��% ��  �� *TemplatedParent+$
 Mode�8   #' Z* #) Z( �� $��1��$��2��	� $��FixedPanMode��$��2��$��0��$$ panningMode��% ��  �� *TemplatedParent+$ FixedPanModeSelected�.���� $;��5/TraceLab.UI.WPF;component/Resources/openhandicon.png��$��14��$��14��	� $��
NormalMode��$��2��$��1��$$ panningMode��% ��  �� *TemplatedParent+$ FixedPanModeSelected�    .���� $?��9/TraceLab.UI.WPF;component/Resources/arrowcursor_icon.png��$��14��$��14���� $��3��$��2���� $+ 
HelpButton��$��4��$��2��.���� $8��2/TraceLab.UI.WPF;component/Resources/help_icon.png��$��14��$��14���� $ 5�����	#66D4D4D4$ 20��$	 285��y��� $, 
HelpButton��$ 	IsChecked�    ._��� $
 Vertical=�$��5q�.+��� Zoom In / Out: �� $
��Bold"�.�CTRL + Wheel�� 	ZoomBox: �� $
��Bold"�.�
ALT + Drag�� Pan: �� $
��Bold"�.�Right Mouse + Drag or �� $
��Bold"�.�SHIFT + Drag�� #��z- #��z. #0 z/ #��z1  ��  �� *TemplatedParent+$ 	ZoomBox.X� ��  �� *TemplatedParent+$ 	ZoomBox.Y�����  �� *TemplatedParent+$ ZoomBox.Width�����  �� *TemplatedParent+$ ZoomBox.Height���  � ��
 �������  �@ ZoomBoxBackground �� $2 0.0, 0.0&�$3 1.0, 1.0&�.��� $4 Silver��$	5 0.0Q�� $4 DarkGray��$	5 1.0Q���  �@ ZoomBoxBorderBrush
 �   ���  �@ ZoomBoxBorderThickness$ 1q���  � }� . 6 P�  �@ ModifierMode$	 Pan=�. ���  �@�Cursor$7 1/TraceLab.UI.WPF;component/Resources/openhand.cur��P�  �@ ModifierMode$ ZoomBox=�. ���  �@�Cursor$
 Hand��