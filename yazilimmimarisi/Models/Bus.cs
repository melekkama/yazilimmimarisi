using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    [Serializable]
    public class Bus : Transportation
    {
        public int SeatNumber { get; set; }
    }
}
