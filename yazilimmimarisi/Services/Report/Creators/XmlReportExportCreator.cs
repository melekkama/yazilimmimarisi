using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi.Services.Report.Creators
{
    internal class XmlReportExportCreator : ReportExportCreator
    {
        public override IReportExport ReportExportFactory(Reservation reservation)
        {
            return new XmlTool(reservation);
        }
    }
}
