   M S B A M L   `   `   `  ????D  @gmc_v_2_0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:gmc_v_2_0.Viewsgmc_v_2_0.Views  5   	   %    gmc_v_2_0.Views.RecipeNewWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   /localclr-namespace:gmc_v_2_0.Views     5   	   -   5        
?????? $??Microsoft YaHei)?5   "   $??
ExtraLight"?6?     ? 
ResizeMode$  NoResize=?6W    ? WindowStyle$
 None=?5	   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?66    ? Title$ RecipeNewWindow??5
   	    ? SizeToContent$ WidthAndHeight=?6!    ? 	Resources 5       ?? 
TargetType   CloseButtonTemplate  iconfont ?? Triggers	 P? Property
 P? Value ?? 
TargetName ?? Property ?? Value  OperationButtonStyle ?? 
TargetType??%J  &	        7  &	 7    ?? 5   
   " ??6   .R?5      ? $
??back??6,   
?????? .+?5      ?? $	????6   8??  $??Center=?5      $??Center=?67   $??16(?5      5      5       5      P? 5      	 ?@J?IsMouseOver
 . . ?5      ?? $
 back??6@    ? ?? ?#DDD6T   5      5      ?? 5   
   " ??6-   .?5      ??  ? ??$ 50??6&   63   ?? 5       ? ??$ 30??6'   64   ?? 5       ? ??$ 
10,0,10,10q?6'   6<   ?? 5        ? ??$ 12(?6)   66   ?? 5!       ? ??$
 Bold"?6+   6:   5"      5#      .??5$      ? -   5        
?????? $??5q?5$   $   .+?5%   
   ?? ???#F7F9FA$	??0,6q?6&   $??Right=?63   ???#66CCFF$??1q?5&   '    ?? CornerRadius$ 5??6;   ._?5'      ?  ? RowDefinitions 5(      ?? 5)      6&   ?? 5*      6&   ?? 5+      6&   .+?5-      ? .+?5.      ?? $??Right=?6   $??X??69   $??40??6E   $??30??6P   #??[  5/      ??50      ?? *CloseCommand+??51      ?? *.+ ?? RelativeSource ??  ?? AncestorType$ WindowL?52      53      ? 54      $??1??6   .+?55      ?? -   5         ??Name$ NewRecipeName??55      $	??180??65   $??35??6A   $??Center=?6M   $??Center=?56      $??16(?69   $??Center=?6G   $??Center=?57      $??
20,20,20,0q?6@   .??6T    58      ??%c   '??       ?? 59      " ??6$   .?5:   "   ??  ?@??CornerRadius$ 5??6A   6M   5;      5<      .??6-   5=      5>      ? 5?      $??2??6   $??Bottom=?6$   $??10,10,10,10q?6?   .+?5@      ? $??Center=?6    .+?5A      ?? $??Create??6!   #??[ 62   $??0,0,20,0q?5B   I   ??6!   ?? *CreateRecipeCommand+??5C   !   ??  ?? Path$ .? ?? $ WindowL? 5D      ??%c   '??       ?? 5E   "   " ??6(   .?5F   &   ??  ?@??CornerRadius$ 5??6E   6Q   5G   #   5H      5I      ?? 5J      $??Cancel??6!   #??[ 62   $??20,0,0,0q?5K   B   ??6!   ?? *CloseCommand+??5L   !   ?? $ .? ?? $ WindowL? 5M      ??%c   '??       ?? 5N   "   " ??6(   .?5O   &   ??  ?@??CornerRadius$ 5??6E   6Q   5P   #   5Q      5R      5S      5T      5U      5V      5W      5X      