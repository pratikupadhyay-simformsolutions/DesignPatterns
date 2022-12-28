using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Saga.StockService.Data;
using Saga.StockService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saga.StockService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IStockService _stockService;

        public ProductsController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductStocks()
        {
            var result = await _stockService.GetAll();
            return Ok(result);
        }
    }
}
