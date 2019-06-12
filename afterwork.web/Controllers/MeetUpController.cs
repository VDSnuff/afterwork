using afterwork.data;
using afterwork.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace afterwork.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetUpController : ControllerBase
    {

        private readonly IRepository<MeetUp> _repository;
        private readonly ILogger<MeetUpController> _logger;

        public MeetUpController(IRepository<MeetUp> repository, ILogger<MeetUpController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MeetUp>> Get()
        {
            try
            {
                return Ok(_repository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Events: {ex}");
                return BadRequest("Failed to get Events");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MeetUp> Get(int id)
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
