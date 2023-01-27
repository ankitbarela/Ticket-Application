using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketApi.Repository
{
    public class CreateJWT
    {
        public string GenerateJWT(Model.User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes("this is my  top secrate"));
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name , user.Name),
                new Claim(ClaimTypes.NameIdentifier , user.UserId.ToString())
            };

            var signingCredentials = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescripter = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescripter);
            return tokenHandler.WriteToken(token);
        }
    }
}
