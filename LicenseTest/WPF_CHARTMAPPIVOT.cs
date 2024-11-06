#if WPF_CHARTMAPPIVOT
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Map;
using DevExpress.Xpf.PivotGrid;

public class Dummy7()
{
    void Test()
    {

        var chart = new ChartControl(); var series = new AreaSeries2D(); chart.Diagram.Series.Add(series);
        var map = new MapControl(); var layer = new ImageLayer(); map.Layers.Add(layer);
        var pivot = new PivotGridControl(); pivot.Fields.Add(new PivotGridField());

    }
}
#endif