using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    public class BusHotelFactory : TravelFactory
    {
        public override Accomodation CreateAccomodation() => 
            base.TravelService
            .SearchAccomodation(base.TravelInfo.Dates, base.TravelInfo.Addresses.DestinationAddress)
            .FirstOrDefault(x => x is Hotel);

        public override Transportation CreateTransportation() => 
            base.TravelService
            .SearchTransportations(base.TravelInfo)
            .FirstOrDefault(x => x is Bus);
    }
}
