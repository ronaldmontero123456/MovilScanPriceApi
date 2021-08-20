using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovilScanPriceApi.Models
{
    public class VW_BIENESTARLECTOR
    {
        [Key]
        public string ContactNo { get; set; }
        public string Cuenta { get; set; }
        public string Cedula { get; set; }
        public string Description { get; set; }
        public decimal TotalPuntos { get; set; }

    }
}
