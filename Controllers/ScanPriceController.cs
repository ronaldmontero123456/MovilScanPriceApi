using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovilScanPriceApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MovilScanPriceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScanPriceController : ControllerBase
    {
        private readonly ProductsContext _productsContext;


        public ScanPriceController(ProductsContext productsContext)
        {
            _productsContext = productsContext;
        }

        //public IActionResult Index()
        //{
        //    return Ok();
        //}

        //GET: api/Products/BarCode
        [HttpGet]
        [Route("GetProductsByBarCode")]
        public async Task<ActionResult<VW_PRODUCTOSLECTOR>> GetProductsByBarCode(string barcode)
        {
            var product = await _productsContext.VW_PRODUCTOSLECTOR.Where(p => p.Barcode == barcode).FirstOrDefaultAsync();

            if (product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }

        //GET: api/Products/BarCode
        [HttpGet]
        [Route("GetTarjetaByBarCode")]
        public async Task<ActionResult<VW_BIENESTARLECTOR>> GetTarjetaByBarCode(string tarjcode)
        {
            var product = await _productsContext.VW_BIENESTARLECTOR.Where(p => p.Cedula == tarjcode || p.CarnetNo == $"4{tarjcode}").FirstOrDefaultAsync();

            if (product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }

    }
}
