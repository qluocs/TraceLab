   M S B A M L   `   `   `  ����J  FTraceLab.UI.WPF, Version=0.5.2.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TraceLab.UI.WPF.ConvertersTraceLab.UI.WPF.Converters  5      U QGraphSharp.Controls, Version=1.0.4639.21038, Culture=neutral, PublicKeyToken=nullV>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.ControlsGraphSharp.Controls 5      O KWPFExtensions, Version=1.0.4583.32057, Culture=neutral, PublicKeyToken=nulljEclr-namespace:WPFExtensions.AttachedBehaviours;assembly=WPFExtensions WPFExtensions.AttachedBehaviours 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source'   !GraphSharp.Controls.VertexControl �� 
TargetType �� Property �� Value �� 
TargetType   NodeControlSelector �� RelativeSource �� AncestorType �� 	Converter.   (TraceLab.UI.WPF.Converters.BoolConverter	   True
   False �� Mode/  )GraphSharp.Controls.GraphElementBehaviour4  .WPFExtensions.AttachedBehaviours.DragBehaviour%  GraphSharp.Controls.GraphCanvas  DefaultNodeBackground  DefaultNodeForeground  DefaultNodeBorderBrush �� Triggers �� Binding �� IsAsync �� Value N� EnterActions g� Duration  HighlightedBorderColor	 �� To �� TargetProperty  HighlightedBackgroundColor  HighlightedForegroundColor N� ExitActions  DefaultBorderColor  DefaultBackgroundColor 	 DefaultForegroundColor�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      8d2http://schemas.microsoft.com/expression/blend/2008  5      7
Converters(clr-namespace:TraceLab.UI.WPF.Converters  5      VGraphSharp_Controls>clr-namespace:GraphSharp.Controls;assembly=GraphSharp.Controls  5      j WPFExtensions_AttachedBehavioursEclr-namespace:WPFExtensions.AttachedBehaviours;assembly=WPFExtensions  5        5      �� 5   
   $U Opack://application:,,,/TraceLab.UI.WPF;component/Views/Nodes/NodeResources.xaml?�6   %  '         7   7  7  7  7  7  7  7  7  7 	 �� 5%      "   6   .�5&   
   ��  � �� 5'      �� 5(      "   6"   .R�5)      �� 8��  ��6'   �� *.+ �� *FindAncestor+"   5*   7   5+      5-      �� 5.   
    �@K�ZIndex 6)   �� *Vertex.IsInfoPaneExpanded+   $	 3��$
 1��$ OneWay=� �� *Self+�� 5/   
    �@ HighlightTrigger 6W   �� *IsMouseOver+ �� *Self+�� 50   
    �@ IsDragEnabled .  6Y   �� 51   
   	 �@ X 6M   �� *	CenterX+$ TwoWay=� �� *Self+�� 52   
   	 �@ Y 6M   �� *	CenterY+$ TwoWay=� �� *Self+�� 54   
   	 �@ X 6>   �� *	CenterX+$ TwoWay=� �� *Self+�� 55   
   	 �@ Y 6>   �� *	CenterY+$ TwoWay=� �� *Self+�� 57   
    �@��Left 6(   �� *
TopLeftX+$ OneWay=� �� *Self+�� 58   
    �@��Top 6'   �� *
TopLeftY+$ OneWay=� �� *Self+�� 59   
    �@  CenterX 6$   �� *Vertex.Data.X+$ TwoWay=� �� *Self+�� 5:   
    �@  CenterY 6$   �� *Vertex.Data.Y+$ TwoWay=� �� *Self+�� 5<   
    � ��$ 2,2,2,2q�6,   �� 5=   
    � ��$ 5,1,2,1q�6$   �� 5>   
    � ��8  6'   �� 5?   
    � ��8  6'   �� 5@   
    � ��8  6(    5A   
   �� 5B       6   �� *Vertex.IsExecuting+ .  �� *Self+ True6u    5C      �� 5D      .��5E      �� .��5F      �� $ 0:0:0.1D�5G   )   8  $ BorderBrush.Color�5H   )   �� 5I      $ 0:0:0.1D�5J   )   8  $ Background.Color�5K   )   �� 5L      $ 0:0:0.1D�5M   )   8  $ Foreground.Color�5N   )   5O      5P       5R      �� 5S      .��5T      �� .��5U      �� $ 0:0:0.1D�5V   )   8  $ BorderBrush.Color�5W   )   �� 5X      $ 0:0:0.1D�5Y   )   8  $ Background.Color�5Z   )   �� 5[      $ 0:0:0.1D�5\   )   8 	 $ Foreground.Color�5]   )   5^      5_      5a      5c      5e      