using System;
using System.IO;

namespace yazilimmimarisi.Services.Report
{
    public class HtmlTool : IReportExport
    {
        private Reservation _reservation;

        public HtmlTool(Reservation reservation)
        {
            _reservation = reservation;
        }

        private string GetHtml() => File.ReadAllText("./Resources/Template.html");
        private string GetReportPath()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktop, "report.html");
            return reportPath;
        }

        public void Export()
        {
            var path = GetReportPath();
            var html = GetHtml();
            var departureType = _reservation.Transportations.Departure is Bus ? "Otobüs" : "Uçak";
            var returnType = _reservation.Transportations.Return is Bus ? "Otobüs" : "Uçak";
            var accomodationType = _reservation.Accomodation is Hotel ? "Otel" : "Çadır";
            html = html
                .Replace("{User.FirstName}", _reservation.User.FirstName)
                .Replace("{User.LastName}", _reservation.User.LastName)
                .Replace("{User.Email}", _reservation.User.Email)
                .Replace("{User.IdentityNumber}", _reservation.User.IdentityNumber)
                .Replace("{User.PhoneNumber}", _reservation.User.PhoneNumber)


                .Replace("{Transportations.Departure.Type}", departureType)
                .Replace("{Transportations.Departure.Price}", _reservation.Transportations.Departure.Price.ToString())
                .Replace("{Transportations.Departure.Capacity}", _reservation.Transportations.Departure.Capacity.ToString())
                .Replace("{Transportations.Departure.Firm.Name}", _reservation.Transportations.Departure.Firm.Name.ToString())
                .Replace("{Transportations.Departure.Firm.Address}", _reservation.Transportations.Departure.Firm.Address.ToString())

                .Replace("{Transportations.Return.Type}", returnType)
                .Replace("{Transportations.Return.Price}", _reservation.Transportations.Return.Price.ToString())
                .Replace("{Transportations.Return.Capacity}", _reservation.Transportations.Return.Capacity.ToString())
                .Replace("{Transportations.Return.Firm.Name}", _reservation.Transportations.Return.Firm.Name.ToString())
                .Replace("{Transportations.Return.Firm.Address}", _reservation.Transportations.Return.Firm.Address.ToString())

                .Replace("{Accomodation.Type}", accomodationType)
                .Replace("{Accomodation.Capacity}", _reservation.Accomodation.Capacity.ToString())
                .Replace("{Accomodation.Price}", _reservation.Accomodation.Price.ToString())
                .Replace("{Accomodation.Firm.Name}", _reservation.Accomodation.Firm.Name.ToString())
                .Replace("{Accomodation.Firm.Address}", _reservation.Accomodation.Firm.Address.ToString())


                .Replace("{TravelInfo.Dates.StartTime}", _reservation.TravelInfo.Dates.StartTime.ToLongDateString())
                .Replace("{TravelInfo.Dates.EndTime}", _reservation.TravelInfo.Dates.EndTime.ToLongDateString());

            File.WriteAllText(path, html);
        }
    }
}
