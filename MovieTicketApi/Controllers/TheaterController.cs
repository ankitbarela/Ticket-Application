using Microsoft.AspNetCore.Mvc;
using MovieTicketApi.Repository.State;
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
    public class TheaterController : ControllerBase
    {
        private readonly ITheaterRepository theaterRepository;

        public TheaterController(ITheaterRepository theaterRepository)
        {
            this.theaterRepository = theaterRepository;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<Model.Theater> Get()
        {
            var theaters = theaterRepository.GetAll();
            return theaters;
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public Model.Theater Get(int id)
        {
            var theater = theaterRepository.GetById(id);
            return theater;
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
