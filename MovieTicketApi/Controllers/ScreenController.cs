using Microsoft.AspNetCore.Mvc;
using MovieTicketApi.Repository.Screen;
using MovieTicketApi.Repository.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieTicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenController : ControllerBase
    {
        private readonly IScreenRepository screenRepository;

        public ScreenController(IScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<Model.Screen> Get()
        {
            var screens = screenRepository.GetAll();
            return screens;
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public Model.Screen Get(int id)
        {
            var screen = screenRepository.GetById(id);
            return screen;
        }

        // POST api/<StateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
