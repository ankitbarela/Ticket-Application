using Microsoft.AspNetCore.Mvc;
using MovieTicketApi.Repository.Screen;
using MovieTicketApi.Repository.Show;
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
    public class ShowController : ControllerBase
    {
        private readonly IShowRepository showRepository;

        public ShowController(IShowRepository showRepository)
        {
            this.showRepository = showRepository;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<Model.Show> Get()
        {
            var shows = showRepository.GetAll();
            return shows;
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public Model.Show Get(int id)
        {
            var show = showRepository.GetById(id);
            return show;
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
