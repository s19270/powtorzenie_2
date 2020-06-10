using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using powtorzenie_2.Models;

namespace powtorzenie_2.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersDbContext _context;
        public OrdersController (OrdersDbContext ocon)
        {
            _context = ocon;
        }
        [HttpGet("{id}")]
        public IActionResult GetZamowienie(string id)
        {
            var k = _context.Klient.Where(kl => kl.IdKlient == int.Parse(id)).FirstOrDefault();
            if (k == null) return NotFound("Brak klienta o danym id");
            return Ok(_context.Zamowienie.Where(kl => kl.IdKlient == int.Parse(id)).ToList());
        }
        [HttpPost]
        public IActionResult NoweZamowienie(NoweZamowienie nz)
        {
            //var k = _context.Klient.Where(kl => kl.IdKlient == int.Parse(id)).FirstOrDefault();
            //if (k == null) return NotFound("Brak klienta o danym id");
            return Ok(nz.wyroby);
        }
    }
}