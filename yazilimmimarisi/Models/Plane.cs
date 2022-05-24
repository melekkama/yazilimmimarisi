using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    enum Class
    {
        Economy,
        Business,
    }
    class Plane : Transportation
    {
        public string SeatNumber { get; set; }
        public Class Class { get; set; }
      
    }
}
