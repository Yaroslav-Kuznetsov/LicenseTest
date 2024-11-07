#if PDF
using DevExpress.Pdf;
using DevExpress.UnitConversion;
using System.IO;

public class Dummy3()
{
    void Test()
    {

        var processor = new PdfDocumentProcessor();
        processor.LoadDocument("");

        var signer = new PdfDocumentSigner("");
        signer.SaveDocument(new MemoryStream());

        var converter = new PdfDocumentConverter("");
        converter.SaveDocument("");

    }
}
#endif