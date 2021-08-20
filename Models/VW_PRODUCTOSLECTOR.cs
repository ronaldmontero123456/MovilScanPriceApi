using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovilScanPriceApi.Models
{
    public class VW_PRODUCTOSLECTOR
    {
        [Key]
        public string Codigo { get; set; }

        [StringLength(120)]
        public string Barcode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
        public decimal? Precio { get; set; }
        public string PrincipioActivo { get; set; }
    }
}
