using afterwork.data;
using afterwork.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace afterwork.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly IRepository<City> _repository;
        public CityController(IRepository<City> repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public JsonResult<IEnumerable<City>> Get()
        {
            var response = _repository.GetAll();
            return Json(response);
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<Event> Get(int id)
        //{
        //    var eventObj = _repository.GetById(id);
        //    return eventObj;
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
