using Diving.API.Models;
using Diving.Business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Diving.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUserService service;
        private IConfiguration configuration;

        public AccountController(IUserService service, IConfiguration configuration)
        {
            this.service = service;
            this.configuration = configuration;

        }

        [HttpGet] //get
        [Authorize(Roles = "admin")]
        public IActionResult Get()
        {
            var result = service.GetAllAccounts();
            return Ok(result);


        }
        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            var user = service.GetUser(userLoginModel.UserName, userLoginModel.Password);

            if (user == null)
            {
                return BadRequest(new { message = "Hatalı kullanıcı adı veya şifre" });
            }
            string issiuer = "cagatay200694";
            string audience = "cagatay200694";
            var key = configuration.GetSection("Bearer")["SecurityKey"]; // startup üzerinden okuduk

            // var key = "diversdoitdeeper";
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credantial = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(ClaimTypes.Role,user.Role)

            };
            var token = new JwtSecurityToken(
                issuer: issiuer,
                audience: audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credantial


                );

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            //TODO 1: JWT
        }

    }
}
