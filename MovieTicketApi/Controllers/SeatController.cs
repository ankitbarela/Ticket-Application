using Microsoft.AspNetCore.Mvc;
using MovieTicketApi.Repository.Screen;
using MovieTicketApi.Repository.Seat;
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
    public class SeatController : ControllerBase
    {
        private readonly ISeatRepository seatRepository;

        public SeatController(ISeatRepository seatRepository)
        {
            this.seatRepository = seatRepository;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<Model.Seat> Get()
        {
            var seats = seatRepository.GetAll();
            return seats;
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public Model.Seat Get(int id)
        {
            var seat = seatRepository.GetById(id);
            return seat;
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
