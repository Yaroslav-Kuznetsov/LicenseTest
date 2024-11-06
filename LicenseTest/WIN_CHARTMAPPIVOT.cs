#if WIN_CHARTMAPPIVOT
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraMap;

public class Dummy4()
{
    void Test()
    {

        var chart = new ChartControl(); var series = new Series("Series 1", ViewType.Bar);
        var map = new MapControl(); var layer = new ImageLayer(); map.Layers.Add(layer);
        var pivot = new PivotGridControl(); pivot.Fields.Add(new PivotGridField());

    }
}

#endif