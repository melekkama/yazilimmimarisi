using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class BusHotelFactory : TravelFactory
    {
        public override Accomodation CreateAccomodation() => new Hotel();

        public override Transportation CreateTransportation() => new Bus();
    }
}
