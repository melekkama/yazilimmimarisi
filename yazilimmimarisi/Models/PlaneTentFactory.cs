using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class PlaneTentFactory:TravelFactory
    {
        public override Accomodation CreateAccomodation() => new Tent();

        public override Transportation CreateTransportation() => new Plane();
    }
}
