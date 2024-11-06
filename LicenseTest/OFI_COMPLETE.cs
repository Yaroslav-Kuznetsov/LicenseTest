#if OFI_COMPLETE
using DevExpress.Drawing;
using DevExpress.Export.Xl;
using DevExpress.Spreadsheet;
using DevExpress.BarCodes;
using DevExpress.Compression;
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

        ZipArchive archive = new ZipArchive();
        archive.Save("");

        BarCode barCode = new BarCode();
        barCode.Save("", DXImageFormat.Png);
        barCode.ExportToPdf("");
    }
}
#endif