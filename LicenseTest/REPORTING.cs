#if REPORTING

using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore;
using DevExpress.XtraReports.UI;

public class Dummy5()
{
    void Test()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();


        builder.Services.AddDevExpressControls();
        builder.Services.AddDevExpressBlazor();
        builder.Services.AddDevExpressServerSideBlazorReportViewer();
        var uri = WebDocumentViewerController.DefaultUri;
        XtraReport report = new XtraReport();
        report.ExportToPdf("");


    }
}
#endif