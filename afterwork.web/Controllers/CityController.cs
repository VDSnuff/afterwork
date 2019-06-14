using afterwork.data;
using afterwork.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace afterwork.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        //private readonly IRepository<City> _repository;
        //private readonly ILogger<CityController> _logger;

        //public CityController(IRepository<City> repository, ILogger<CityController> logger)
        //{
        //    _repository = repository;
        //    _logger = logger;
        //}

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<City>> Get()
        //{
        //    try
        //    {
        // ///       return Ok(_repository.GetAll());
        //    }
        //    catch(Exception ex)
        //    {
        //        //_logger.LogError($"Failed to get Cities: {ex}");
        //        //return BadRequest("Failed to get Cities");
        //    }
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<Event> Get(int id)
        //{
        //    var response = _repository.GetById(id);
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
