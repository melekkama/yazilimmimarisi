namespace yazilimmimarisi.Services.Report.Creators
{
    public class HtmlReportExportCreator : ReportExportCreator
    {
        public override IReportExport ReportExportFactory(Reservation reservation)
        {
            return new HtmlTool(reservation);
        }
    }
}
