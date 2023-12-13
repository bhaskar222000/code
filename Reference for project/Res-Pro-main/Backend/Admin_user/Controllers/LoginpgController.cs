using Admin_user_MS.Data;
using Admin_user_MS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace Admin_user_MS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginpgController : ControllerBase
    {
       
        IConfiguration configuration;
        AdminDbContextClass database;
        AdminUser ad = new AdminUser();


        public LoginpgController( IConfiguration ic, AdminDbContextClass database)
        {
           
            configuration = ic;
            this.database = database;

        }
        [HttpPost]
        public ActionResult Login([FromBody] Loginpg lg)
        {
            if (lg != null)
            {
               
                 var user = GetUser(lg.user_name, lg.password) ;
                
                   
              if (user != null)
                {
                    var claim = new[]
              {
                        new Claim("UserName" , user.UserName ),
                         new Claim("User-email" , user.Email),
                          new Claim(ClaimTypes.Role,user.Role),
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                    var Signincerdincial = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(

                       configuration["Jwt:Issuer"],
                       configuration["Jwt:Audience"],
                       claim,
                       expires: DateTime.UtcNow.AddMinutes(10),
                       signingCredentials: Signincerdincial
                       );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));

                }
                else
                {
                    return BadRequest("No user");
                }

            }
            else
            {
                return BadRequest("No input");
            }

        }

        private AdminUser GetUser(string user_name, string password)
        {
            return database.ADMIN_USER.FirstOrDefault(opton => opton.UserName == user_name && opton.Password == password);
        }
    }
}
