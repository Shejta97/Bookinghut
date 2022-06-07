using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bookinghut.Database
{
    public class CurrentEvent
    {
        [Key]
        public int CurentEventID {get;set;}
        public bool Status { get; set; }
        [ForeignKey("EventID")]

        public int EventID { get; set; }
        public Event Event { get; set; }
    }
}
