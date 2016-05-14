using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Models.Restaurant
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddresss { get; set; }

        public string TelephoneNumber { get; set; }

        public int NumberOfPeople { get; set; }

        public DateTime ReservationDate { get; set; }
        
        public ReservationStatus ReservationStatus {get; set;}

        public string ReservationComment { get; set; }
        
    }
}
