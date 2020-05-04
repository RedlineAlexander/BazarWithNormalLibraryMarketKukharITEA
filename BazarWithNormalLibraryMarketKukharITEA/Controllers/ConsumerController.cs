using BazarWithNormalLibraryMarketKukharITEA.Entities;
using BazarWithNormalLibraryMarketKukharITEA.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarWithNormalLibraryMarketKukharITEA.Controllers
{

    [Route("api/consumers")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {

        readonly IService<Consumers> service;

        public ConsumerController(IService<Consumers> service)
        {
            this.service = service;
        }
        [HttpGet]
        public List<Consumers> Get()
        {
            return service.GetQuery().ToList();
        }
        [HttpGet("{id}")]
        public Consumers Get(int id)
        {
            return service.FindById(id);
        }
        [HttpPost("save")]
        public List<Consumers> Post([FromBody] Consumers value)
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
