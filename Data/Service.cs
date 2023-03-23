using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPrettyNails.Data
{
    
    public class Service
    {
        public int Id { get; set; }


        public string ServiceName { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }


        public TypeService ServiceType { get; set; }
        public DateTime DateCreated { get; set; }


        public  ICollection<Reservation> Reservations { get; set; }
    }
}
