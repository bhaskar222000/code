using AutoMapper;
using Menu_MS.Data;
using Menu_MS.DTO.FoodList;
using Menu_MS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Menu_MS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public readonly ProductDBContextClass productDbContextClass;
        IMapper mapper;
        public MenuController(ProductDBContextClass productdb, IMapper mp)
        {
            productDbContextClass = productdb;

            mapper = mp;
        }
        [HttpGet]
        public async Task<ActionResult> GetMenu()
        {
            return Ok(await productDbContextClass.foodLists.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<FoodList01>> PostMenu([FromBody] Fooddot fooddot)
        {
            var food = mapper.Map<FoodList01>(fooddot);
            await productDbContextClass.AddAsync(food);
            await productDbContextClass.SaveChangesAsync();
            return Ok(food);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<FoodList01>> PutMenu([FromBody] Fooddot fooddt, int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var food = mapper.Map<FoodList01>(fooddt);
            productDbContextClass.Update(food);
            await productDbContextClass.SaveChangesAsync();
            return Ok(food);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<FoodList01>> DeleteMenu(int id)
        {
            var result = productDbContextClass.foodLists.Find(id);
            productDbContextClass.foodLists.Remove(result);
            await productDbContextClass.SaveChangesAsync();
            return Ok(result);
        }
    }
}
