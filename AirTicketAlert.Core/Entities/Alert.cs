using AirTicketAlert.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTicketAlert.Core.Entities
{
    public class Alert
    {
        public Airport Departure { get; set; }

        public Airport Destination { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public double Price { get; set; }


    }
}
