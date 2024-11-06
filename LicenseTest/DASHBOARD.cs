#if DASHBOARD
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWin;
using DevExpress.DashboardWpf;
using System.IO;
public class Dummy6()
{


    void Test()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        DashboardConfigurator dashboardConfigurator = new DashboardConfigurator();
        Dashboard dashboard = new Dashboard();
        DashboardExporter dashboardExporter = new DashboardExporter();
        dashboardExporter.ExportToPdf(dashboard, new MemoryStream());

        var dashboardViewer = new DashboardViewer();
        var dashboardDesigner1 = new DashboardDesigner();
        var dashboardViewerWpdf = new DashboardControl();
        var dashboardItem = new CardDashboardItem();
        app.MapDashboardRoute("api/dashboard", "DefaultDashboard");
    }
    public class MyDashboardController : DashboardController
    {
        public MyDashboardController(DashboardConfigurator configurator, Microsoft.AspNetCore.DataProtection.IDataProtectionProvider dataProtectionProvider = null) : base(configurator, dataProtectionProvider)
        {
        }
    }

}
#endif
