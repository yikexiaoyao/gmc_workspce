   M S B A M L   `   `   `  ????D  @gmc_v_2_0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:gmc_v_2_0.Viewsgmc_v_2_0.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      (    "gmc_v_2_0.Views.UtilityPlotterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:gmc_v_2_0.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .??5
      ?   ? RowDefinitions  5   
   ?? 5      $??* ?6   6)   ?? 5      $??* ?6   6)   .+?5   
   ?  ? ColumnDefinitions 5      ?? 5      $??* ?6#   6/   ?? 5      $??* ?6#   6/   .+?5      ? .+?5      #  LiveCharts.Wpf.CartesianChart  &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$	 Top=?6%   ???#EEE   Series 5        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 1,2,3,4,5,6 6)      
DataLabels .    LineSmoothness$ 1Q?6P      Stroke
 ?  ??   Fill
 ?????	   PointGeometrySize$	 20Q?5   5   
   
Foreground

 ?  ??   PointForeground ?#FF6347   StrokeDashArray$ 5R?5   )   5        5      $ 2,4,6,8,10,12 6)   6B      AxisY 5#        LiveCharts.Wpf.Axis     Title$ Value??6#   63      AxisX 5(        $
 Type??6#   62   5*      5+      ? 5,      $??1??6   5-      5.      ? 50   
   $??1??6    51      ?? 52      6%   ?? 53      6%   55      56      57      