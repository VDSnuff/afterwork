using afterwork.data;
using afterwork.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace afterwork.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private readonly IRepository<Event> _repository;
        public EventController(IRepository<Event> repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            var eventObj = _repository.GetById(id);
            return eventObj;
        }

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
