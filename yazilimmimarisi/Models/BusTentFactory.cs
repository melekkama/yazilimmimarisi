using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class BusTentFactory : TravelFactory
    {
        public override Accomodation CreateAccomodation() => new Tent();

        public override Transportation CreateTransportation() => new Bus();
    }
}
