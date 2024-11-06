#if OFI_BASIC
using DevExpress.XtraRichEdit;

public class Dummy2()
{
    void Test()
    {
        var documentServer = new RichEditDocumentServer();
        documentServer.CreateNewDocument();
        documentServer.SaveDocument("", DevExpress.XtraRichEdit.DocumentFormat.OpenXml);
        documentServer.ExportToPdf("");

    }
}
#endif