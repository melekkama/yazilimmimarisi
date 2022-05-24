using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class PlaneHotelFactory:TravelFactory
    {
        public override Accomodation CreateAccomodation()
        {
            return new Hotel();
        }

        public override Transportation CreateTransportation()
        {
            return new Plane();
        }
    }
}
