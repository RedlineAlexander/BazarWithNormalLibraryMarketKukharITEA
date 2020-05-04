using BazarWithNormalLibraryMarketKukharITEA.Entities;
using BazarWithNormalLibraryMarketKukharITEA.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Controllers
{
    [Route("api/buyers")]
    [ApiController]
    public class BuyersController : ControllerBase
    {
        readonly IService<Buyers> service;

        public BuyersController(IService<Buyers> service)
        {
            this.service = service;
        }
        [HttpGet]
        public List<Buyers> Get()
        {
            return service.GetQuery().ToList();
        }
        [HttpGet("{id}")]
        public Buyers Get(int id)
        {
            return service.FindById(id);
        }
        [HttpPost("save")]
        public List<Buyers> Post([FromBody] Buyers value)
        {
            service.Create(value);
            return service.GetAll().ToList();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
