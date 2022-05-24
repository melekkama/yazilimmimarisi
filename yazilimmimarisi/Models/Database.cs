using System.Collections.Generic;

namespace yazilimmimarisi
{
  public  static class Database
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public static List<Transportation> Transportations { get; set; } = new List<Transportation>();
        public static List<Accomodation> Accomodations { get; set; } = new List<Accomodation>();
    }
}
