using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order_MS.Data;
using Order_MS.DTO.Orderdot;
using Order_MS.DTO.Ratingdot;
using Order_MS.Models;

namespace Order_MS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        public readonly OrderDbContextClass orderDbContextClass;
        IMapper mapper;
        public RatingController(OrderDbContextClass orderdb, IMapper mb)
        {
            orderDbContextClass = orderdb;
            mapper = mb;
        }
        [HttpGet]
        public async Task<ActionResult> GetOrder()
        {
            return Ok(await orderDbContextClass.rating.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<Rating>> PostOrder([FromBody] ratingdot rating)
        {
            var order = mapper.Map<Rating>(rating);
            await orderDbContextClass.rating.AddAsync(order);
            await orderDbContextClass.SaveChangesAsync();
            return Ok(order);
        }
    }
}
