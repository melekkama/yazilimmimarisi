using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
  public  class TravelService
    {
        readonly Firm THY = new Firm()
        {
            Name = "THY",
            Address = new Address() { City = "Ankara" }
        };
        readonly Firm KOC = new Firm()
        {
            Name = "KOÇ",
            Address = new Address() { City = "Istanbul" }
        };
        public List<Transportation> SearchTransportations(TravelInfo info)
        {
            return new List<Transportation>()
            {
                new Plane()
                {
                    Capacity=100,
                    Price=400,
                    Firm = THY,
                    Travel= info
                },
                new Bus()
                {
                    Capacity=30,
                    Price=250,
                    Firm = KOC,
                    Travel= info
                }
            };
        }
        public List<Accomodation> SearchAccomodation(Dates dates, Address accomodationAddress)
        {
            var dayCount= dates.EndTime - dates.StartTime;
            return new List<Accomodation>()
            {
                new Tent()
                {
                    Firm=new Firm()
                    {
                        Name="KAMA",
                        Address=accomodationAddress,
                    },
                    Capacity=2,
                    Price=Convert.ToDecimal(150*dayCount.TotalDays),
                    IsStorage=false,
                    IsWindow=true
                },
                new Hotel()
                {
                    BedType=BedType.Double,
                    Capacity=2,
                    Firm=new Firm()
                    {
                        Name="PERAPALAS",
                        Address=accomodationAddress,
                    },
                    Price=Convert.ToDecimal(300*dayCount.TotalDays)
                }
            };
        }
    }
}
