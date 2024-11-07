#if OFI_COMPLETE
using DevExpress.Drawing;
using DevExpress.Export.Xl;
using DevExpress.Spreadsheet;
using DevExpress.BarCodes;
using DevExpress.Compression;
using DevExpress.UnitConversion;
using System.IO;

public class Dummy()
{
    void Test()
    {
        IXlExporter exporter = XlExport.CreateExporter(XlDocumentFormat.Xlsx);
        IXlDocument document = exporter.CreateDocument(new MemoryStream());
        IXlSheet sheet = document.CreateSheet();
        Workbook workbook = new Workbook();
        workbook.LoadDocument("");
        Worksheet worksheet = workbook.Worksheets[0];

        ZipArchive archive = new ZipArchive();
        archive.Save("");

        BarCode barCode = new BarCode();
        barCode.Save("", DXImageFormat.Png);
        barCode.ExportToPdf("");

        double result = Units.Area.Convert(100.0f, Area.Hectare, Area.SquareMeter);
    }
}
#endif