using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    class Reservation
    {
        public User User { get; set; }
        public Accomodation Accomodation { get; set; }
        public Transportations Transportations { get; set; }
        public TravelInfo TravelInfo { get; set; }
    }
}
