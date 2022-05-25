using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    public class TravelInfo
    {
        public Dates Dates { get; set; }
        public Addresses Addresses { get; set; }

        public TravelInfo Reverse()
        {
            return new TravelInfo()
            {
                Addresses = new Addresses()
                {
                    DepartureAddress = this.Addresses.DestinationAddress,
                    DestinationAddress = this.Addresses.DepartureAddress
                },
                Dates = new Dates()
                {
                    StartTime = this.Dates.EndTime,
                    EndTime = this.Dates.StartTime.AddHours(10),
                }
            };
        }
    }
}
