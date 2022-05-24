using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
   static class Database
    {
        public static List<User> Users { get; set; }
        public static List<Reservation> Reservations { get; set; }
        public static List<Transportation> Transportations { get; set; }
        public static List<Accomodation> Accomodations { get; set; }
    }
}
