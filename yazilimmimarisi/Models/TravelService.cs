using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimmimarisi
{
    public class TravelService
    {
        private readonly Firm THY = new Firm()
        {
            Name = "THY",
            Address = new Address() { City = "Ankara" }
        };
        private readonly Firm KOC = new Firm()
        {
            Name = "KOÇ",
            Address = new Address() { City = "Istanbul" }
        };
        public List<Transportation> SearchTransportations(TravelInfo info) => new List<Transportation>()
            {
                new Plane()
                {
                    Capacity=100,
                    Price=400,
                    Firm = THY,
                    Travel= new TravelInfo()
                    {
                        Addresses=info.Addresses,
                        Dates=new Dates()
                        {
                            StartTime=info.Dates.StartTime,
                            EndTime=info.Dates.StartTime.AddHours(2)
                        }
                    }
                },
                new Bus()
                {
                    Capacity=30,
                    Price=250,
                    Firm = KOC,
                    Travel= new TravelInfo()
                    {
                        Addresses=info.Addresses,
                        Dates=new Dates()
                        {
                            StartTime=info.Dates.StartTime,
                            EndTime=info.Dates.StartTime.AddHours(10)
                        }
                    }
                }
            };
        public List<Accomodation> SearchAccomodation(Dates dates, Address accomodationAddress)
        {
            var dayCount = dates.EndTime - dates.StartTime;
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
