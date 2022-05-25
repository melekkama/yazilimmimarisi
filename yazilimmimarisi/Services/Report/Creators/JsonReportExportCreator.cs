namespace yazilimmimarisi.Services.Report.Creators
{
    public class JsonReportExportCreator : ReportExportCreator
    {
        public override IReportExport ReportExportFactory(Reservation reservation)
        {
            return new JsonTool(reservation);
        }
    }
}
