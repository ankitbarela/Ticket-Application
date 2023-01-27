using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MovieTicketApi.Model;
using MovieTicketApi.Repository;
using MovieTicketApi.Repository.User;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieTicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public LoginController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = userRepository.GetAll();
            return users;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = userRepository.GetById(id);
            return user;
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            var user = userRepository.Authenticate(login.UserName, login.Password);

            if(user == null)
            {
                return Unauthorized();
            }
            var loginResponse = new LoginResponse();
            loginResponse.UserName = login.UserName;
            var createJWT = new CreateJWT();
            loginResponse.Token = createJWT.GenerateJWT(user);
            return Ok(loginResponse);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
