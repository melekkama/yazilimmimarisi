using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
  public abstract class TravelFactory
    {
        public TravelService TravelService { get; set; }
        public TravelInfo TravelInfo { get; set; }
        public abstract Transportation CreateTransportation();
        public abstract Accomodation CreateAccomodation();
    }
}
