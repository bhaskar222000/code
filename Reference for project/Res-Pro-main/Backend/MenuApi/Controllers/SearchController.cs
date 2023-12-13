using AutoMapper;
using Menu_MS.Data;
using Menu_MS.DTO.Search;
using Menu_MS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Menu_MS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        public readonly ProductDBContextClass productDbContextClass;
        IMapper mapper;
        public SearchController(ProductDBContextClass productdb,IMapper mp)
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
        public async Task<ActionResult<FoodList01>> PostMenu([FromBody] Searchdto search)
        {
            var food = mapper.Map<FoodList01>(search);
            await productDbContextClass.AddAsync(food);
            await productDbContextClass.SaveChangesAsync();
            return Ok(food);
        }
    }
}
