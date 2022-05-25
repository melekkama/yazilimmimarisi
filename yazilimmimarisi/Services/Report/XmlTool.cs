using System;
using System.IO;
using System.Xml.Serialization;

namespace yazilimmimarisi.Services.Report
{
    public class XmlTool : IReportExport
    {
        private Reservation _reservation;

        public XmlTool(Reservation reservation)
        {
            _reservation = reservation;
        }

        public void Export()
        {
            XmlSerializer MySerializer = new XmlSerializer(typeof(Reservation), new Type[] { typeof(Transportation), typeof(Accomodation) });
            TextWriter TW = new StringWriter();
            MySerializer.Serialize(TW, _reservation);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktop, "report.xml");
            File.WriteAllText(reportPath, TW.ToString());
        }
    }
}
