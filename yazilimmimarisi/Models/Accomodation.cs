using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace yazilimmimarisi
{

    [XmlInclude(typeof(Tent))]
    [XmlInclude(typeof(Hotel))]
    public abstract class Accomodation
    {
        public Firm Firm { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
    }
}
