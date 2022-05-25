namespace yazilimmimarisi.Services.Report.Creators
{
    public abstract class ReportExportCreator
    {
        public abstract IReportExport ReportExportFactory(Reservation reservation);
    }
}
