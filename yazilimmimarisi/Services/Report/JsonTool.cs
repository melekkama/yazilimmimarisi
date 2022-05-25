using Newtonsoft.Json;

using System;
using System.IO;

namespace yazilimmimarisi.Services.Report
{
    public class JsonTool : IReportExport
    {
        private readonly Reservation _reservation;

        public JsonTool(Reservation reservation)
        {
            _reservation = reservation;
        }
        public void Export()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktop, "report.json");
            var json = JsonConvert.SerializeObject(_reservation, Formatting.Indented);
            File.WriteAllText(reportPath, json);
        }
    }
}
