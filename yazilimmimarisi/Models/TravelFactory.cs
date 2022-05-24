using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
   abstract class TravelFactory
    {
        public abstract Transportation CreateTransportation();
        public abstract Accomodation CreateAccomodation();
    }
}
