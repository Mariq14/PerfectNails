using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPrettyNails.Data
{
    

    public class Articul
    {
        public int Id { get; set; }


        public string ArticulName { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageURL1 { get; set; }
        public string ImageURL2 { get; set; }
        public string ImageURL3 { get; set; }

        public TypeType Type { get; set; }
        public DateTime DateCreated { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
      
    }
}
