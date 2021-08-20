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
        public string ContatcNo { get; set; }
        public string Cuenta { get; set; }
        public string Cedula { get; set; }
        public string DesCription { get; set; }
        public decimal TotalPuntos { get; set; }

    }
}
