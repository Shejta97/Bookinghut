using System;
using System.Collections.Generic;
using System.Text;

namespace Bookinghut.Model
{
    public class MEvent
    {
        public int ID { get; set; }

        public int CurentEventID { get; set; }
        public string Name { get; set; }

        public int VenueID { get; set; }
        public DateTime Timing { get; set; }
        public float Price { get; set; }
        public int NumberOfTickets { get; set; }
    }
}
