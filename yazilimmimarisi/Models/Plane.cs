using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    public enum Class
    {
        Economy,
        Business,
    }
  public  class Plane : Transportation
    {
        public string SeatNumber { get; set; }
        public Class Class { get; set; }
      
    }
}
