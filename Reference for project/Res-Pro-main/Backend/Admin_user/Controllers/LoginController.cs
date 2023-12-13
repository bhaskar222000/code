using Admin_user_MS.Data;
using Admin_user_MS.DTO.Registration;
using Admin_user_MS.Models;
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_user_MS.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly AdminDbContextClass adminDbContextClass;
        IMapper _mapper;

        public LoginController(AdminDbContextClass _db,IMapper mapper)
        {
            adminDbContextClass = _db;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<ActionResult> GetAdminUsers()
        {
            return Ok(await adminDbContextClass.ADMIN_USER.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<AdminUser>> Postadm([FromBody] Registrationdto regdot)
        {
            var adm = _mapper.Map<AdminUser>(regdot);
           await adminDbContextClass.AddAsync(adm);
          await  adminDbContextClass.SaveChangesAsync();
            return Ok(adm);
        }
         
        
        [HttpPut("{id:int}")]
        public async Task<ActionResult<AdminUser>> put([FromBody] Registrationdto regdot, int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var Admin = _mapper.Map<AdminUser>(regdot);
              adminDbContextClass.ADMIN_USER.Update(Admin);
             await adminDbContextClass.SaveChangesAsync();  
            return Ok(Admin);
        }
        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var result = adminDbContextClass.ADMIN_USER.Find(id);
            adminDbContextClass.ADMIN_USER.Remove(result);
           await adminDbContextClass.SaveChangesAsync();
            return Ok(result);
        }
    }
}
