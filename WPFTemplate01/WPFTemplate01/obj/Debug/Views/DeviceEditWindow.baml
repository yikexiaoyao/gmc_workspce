   M S B A M L   `   `   `  ????H  DWPFTemplate01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFTemplate01.ViewsWPFTemplate01.Views  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 69   *    $WPFTemplate01.Views.DeviceEditWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFTemplate01.Views     5   	   6sys&clr-namespace:System;assembly=mscorlib     69     ? UseLayoutRounding  . $??Microsoft YaHei)?5   	   $??
ExtraLight"?6&   ???#333 ? WindowStyle$
 None=?5	   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterOwner=?67   
??????  ? Title$ 设备信息维护??5
   	   $	??550??6   $	??800??6%    ? 	Resources 5       ?? MergedDictionaries ?? Source ?? 
TargetType   Key	 ?? Property
 ?? Value ?? 
TargetType  iconfont ?? Triggers P? Property P? Value ?? 
TargetName ?? Triggers ?? RelativeSource ?? Mode ?? CornerRadius ?? Type?? 5   
    5      ?? 5      $U Opack://application:,,,/WPFTemplate01;component/Assets/Styles/ComboBoxStyle.xaml??6%   ?? 5      $[ Upack://application:,,,/WPFTemplate01;component/Assets/Styles/LeftTabControlStyle.xaml??6%   ?? 5      ?? 5      " ??6   ControlButtonStyle  .?5      ?? 	 ? ??$
 12(?65   ?? 5      	 ? ??
 5      ?? 5   "   " ??62   .R?5   &   ? $
??back??6[   
?????? $??30??6D   $??45??6P   .+?5   *   ?? $??hover??61   #??z??6>   $y?	Collapsed=?6h   ?? 5   *   $	??txt??5   `   #??z??5   4   #??[ 6U   $??Center=?5   (   $??Center=?6C   
???????5   (   5   '    5   &   P? 5   *    ?@J?IsMouseOver . . ?5   .   ?? $ hover??6[   	 ? y?$
 Visible=?6K   6[   5   +   5!   #   5#       5$      P? 5%       ?@J?IsMouseOver . . ?5&   "   ?? 	 ? ??
 6?   ?? *Tag+ ?? $
 Self=?5'      5)      ?? 5+      " ??6&   AddButtonTemplate  .R?5,      ?? #??z??6!   $ 3??6K   ._?5-      ?? $
??back??6%   ._?5.   "   ?? $??Center=?63   $??Center=?6N   #??z??5/   #   
???????6G   50      51       52      P? 53       ?@J?IsMouseOver . . ?54   "   ?? $
 back??6Q   	 ? ??
 ?	#2200000055      57      ?? 59      " ??6   	datas  .s?5:      ??1??6(   ??5;      2??6(   ??5<      3??6(   ??5=      4??6(   ??5>      5??6(   ??5?      6??6(   ??5@      7??6(   5A      5B      %
   '??       5D      .??5F      ?? $??5q?6   ???	#FFF6F7FC J? Effect 5G   
   3  -System.Windows.Media.Effects.DropShadowEffect  5H         
BlurRadius$ 8Q?6      Opacity$	 0.2Q?6.      	Direction$ 0Q?6<      Color$
 Gray??6J      ShadowDepth$ 0Q?6W   ._?5J   
   ? -   5         ? RowDefinitions 5K      ?? 5L      $??80 ?6    ?? 5S      .+?5V      ?? ???	#FF3269DE6   ?? 5W      $??Center=?6   $
??Left=?64   .+?5X      ?? $??设备信息编辑??6   
???????$??Center=?6=   $
??15,0q?6X   ?? 5Y      
???????$??Center=?6E   $??	15,20,0,5q?6`   $??18(?5Z      ??5Y      ?? *Name+5Z      5[      ?? 5]      -   5        $	????5]        ControlButtonStyle#??[ 6(   ???	#11000000
 ? Tag$
 #333??6k   $??33??6v   $	??Top=?6?   $??Right=?5^      61   ?? 5`      $??1??6   $??0q?6&   $
??0,20q?6:   .@?5a      ?? $??通信配置??6   .??5b      ?  5c      ?? 5d      $??40 ?6,   ?? 5e      $??40 ?6,   ?? 5f      $??40 ?6,   ?? 5g      $??40 ?6,   ?? 5h      $??40 ?6,   ?? 5i      $??40 ?6,   ?? 5j      $??40 ?6,   ?? 5k      ?? 5l      $??50 ?6,   .+?5n      ??  ?? Orientation$ 
Horizontal=?6%   $
??30,0q?6>   $??Center=?6L   .+?5o      ?? $??通信方式??6(   $
??20,0q?64   	? 5p      -   5        $??串口??5p   *    d? 	IsChecked$
 TrueY?67   6H   	? 5q      -   5        $??网口??5q   *   $
??15,0q?67   6E   5r      ?? 5s      $ 
Horizontal=?6%   $??1??6>   $
??30,0q?6K   $??Center=?6Y   .+?5t      ?? $??通信参数??6(   $
??20,0q?64   $??Center=?6B   ?? 5u      -   5         ??Name$	 cb1??5u   D     ?? SelectedIndex$  0??6'   $??80??69   .@?5v   "   ?? $
??COM1??6/   ?? 5w   "   $
??COM2??6/   5x      ?? 5y      -   5        $	 cb2??5y   Q   $  1??6'   $??80??69   $	??7,0q?6D   .@?5z   "   ?? $
??4800??6/   ?? 5{   "   $
??9600??6/   ?? 5|   "   $??19200??6/   5}      ?? 5~      -   5        $	 cb3??5~   D   $  1??6'   $??50??69   .@?5   "   ?? $??7??6/   ?? 5?   "   $??8??6/   5?      ?? 5?      -   5        $	 cb4??5?   Q   $  0??6'   $??70??69   $	??7,0q?6D   .@?5?   "   ?? $
??None??6/   ?? 5?   "   $	??Odd??6/   ?? 5?   "   $
??Even??6/   5?      ?? 5?      -	   5        $	 cb5??5?   D   $  0??6'   $??70??69   .@?5?   "   ?? $	??One??6/   ?? 5?   "   $	??Two??6/   5?      ?? 5?      -
   5        ! ??Name$	! tb1??5?   g   $??192.168.2.1??6&   $??Center=?69   $	??100??6[   $y?	Collapsed=?5?      $??26??61   ?? 5?      -   5        $	! tb2??5?   k   $	??102??6&   $??Center=?61   $??50??6S   $	??7,0q?6^   $y?	Collapsed=?5?      5?      ?? 5?      $ 
Horizontal=?6%   $??2??6>   $
??30,0q?6K   $??Center=?6Y   .+?5?      ?? $??通信协议??6(   $
??20,0q?64   $??Center=?6B   ?? 5?      $  0??6'   $	??167??69   .@?5?   "   ?? $??	ModbusRTU??6/   ?? 5?   "   $??ModbusASCII??6/   ?? 5?   "   $??	ModbusTCP??6/   ?? 5?   "   $??S7-200SMART??6/   ?? 5?   "   $??S7-1500??6/   5?      5?      ?? 5?      $ 
Horizontal=?6%   $??3??6>   $
??30,0q?6K   $??Center=?6Y   .+?5?      ?? $??设备站号??6(   $
??20,0q?64   $??Center=?6B   ?? 5?      $??01??6&   $??23??60   $??Center=?6<   $	??167??6^   5?      ?? 5?      $ 
Horizontal=?6%   $??4??6>   $
??30,0q?6K   $??Center=?6Y   .+?5?      ?? $??机  架  号??6(   $
??19,0q?67   $??Center=?6E   ?? 5?      $??00??6&   $??23??60   $??Center=?6<   $	??167??6^   5?      ?? 5?      $ 
Horizontal=?6%   $??5??6>   $
??30,0q?6K   $??Center=?6Y   .+?5?      ?? $??插  槽  号??6(   $
??19,0q?67   $??Center=?6E   ?? 5?      $??01??6&   $??23??60   $??Center=?6<   $	??167??6^   5?      ?? 5?      $ 
Horizontal=?6%   $??6??6>   $
??30,0q?6K   $??Center=?6Y   .+?5?      ?? $??刷新频率??6(   $
??20,0q?64   $??Center=?6B   ?? 5?      $  2??6'   $	??167??69   .@?5?   "   ?? $
??10ms??6/   ?? 5?   "   $
??50ms??6/   ?? 5?   "   $??500ms??6/   ?? 5?   "   $??1000ms??6/   ?? 5?   "   $??2000ms??6/   5?      5?      ?? 5?      $ 
Horizontal=?6%   $??8??6>   $??Center=?6K   $
??Left=?6f   $
??50,0q?6?   .+?5?      ?? $??保存??6%     AddButtonTemplate#??[ 62   $??75??6`   $??28??6k   $	??5,0q?6w   ???	#FF3269DE5?      ?? 5?      $??退出??6%   #??[ 62   $??55??6`   $??28??6k   ???#999$y?	Collapsed=?5?   +   5?      5?      5?      ?? 5?      $??监控点位??6   .??5?      ? $??7??6    5?      ?? 5?      $??30 ?6,   ?? 5?      ?? 5?      $??50 ?6,   .+?5?      ? ???#EEE$
??10,0q?61   " ? ColumnDefinitions" 5?      ?? 5?   "   $??45 ?63   ?? 5?   "   ?? 5?   "   $??80 ?63   ?? 5?   "   $??60 ?63   ?? 5?   "   $??60 ?63   ?? 5?   "   $	??100 ?63   .+?5?      ?? $??序号??6(   $??Center=?62   $??Center=?6M   ?? 5?      $??监控标签??6(   $??Center=?64   $
??Left=?6O   $??1??6j   ?? 5?      $??寄存器地址??6(   $??Center=?65   $??Center=?6P   $??2??6m   ?? 5?      $??单位??6(   $??Center=?62   $??Center=?6M   $??3??6j   ?? 5?      $??数据类型??6(   $??Center=?64   $??Center=?6O   $??4??6l   ?? 5?      $??操作??6(   $??Center=?62   $??Center=?6M   $??5??6j   5?      ?? 5?      $??1??6'   $
??10,0q?6j   ??64   ??  	 datas# ?? Source## [ ??5?      ?? 5?   "   .R?5?   &   ? 
?????? $??30??6D   " 5?   *   ?? 5?   .   $??45 ?6?   ?? 5?   .   ?? 5?   .   $??80 ?6?   ?? 5?   .   $??60 ?6?   ?? 5?   .   $??60 ?6?   ?? 5?   .   $	??100 ?6?   .+?5?   *   ?? $??Center=?6E   $??Center=?6`   ??64   ?? 6`   ?? 5?   *   $??电源电压??64   $??1??6@   $??Center=?6P   ?? 5?   *   $??VW100??64   $??2??6A   $??Center=?6Q   $??Center=?6l   ?? 5?   *   $??kv??64   $??3??6>   $??Center=?6N   $??Center=?6i   ?? 5?   *   $??ushort??64   $??4??6B   $??Center=?6R   $??Center=?6m   ?? 5?   *   $??5??64   $??Center=?6D   $??Center=?6_   ?? 5?   &   .?60   编辑64    ?? 5?   &   .?60   删除64   5?   +   5?   '   5?   #   5?      ?? 5?      $??添加点位配置??6!   $??8??62   $??Center=?6?   $
??Left=?6Z   $
??10,0q?6u   $??28??5?      $	??120??6!   ???	#FF3269DE#??[ 5?      5?      5?      5?      5?      5?      5?      