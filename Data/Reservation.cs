using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPrettyNails.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Services { get; set; }


        public string UserId { get; set; }
        public virtual User Users { get; set; }


        public DateTime ReservatedOn { get; set; } 
        
    }
}
