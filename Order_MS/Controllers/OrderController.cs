using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order_MS.Data;
using Order_MS.DTO.Orderdot;
using Order_MS.Models;

namespace Order_MS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly OrderDbContextClass orderDbContextClass;
        IMapper mapper;
        public OrderController(OrderDbContextClass orderdb,IMapper mb)
        {
            orderDbContextClass = orderdb;
            mapper = mb;
        }
        [HttpGet]
        public async Task<ActionResult> GetOrder()
        {
            return Ok(await orderDbContextClass.orderLists.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<OrderList>> PostOrder([FromBody] orderdot order01 )
        {
            var order = mapper.Map<OrderList>(order01);
            await orderDbContextClass.orderLists.AddAsync(order);
            await orderDbContextClass.SaveChangesAsync();
            return Ok(order);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<OrderList>> PutOrder([FromBody] orderdot order01, int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var order = mapper.Map<OrderList>(order01);
            orderDbContextClass.orderLists.Update(order);
            await orderDbContextClass.SaveChangesAsync();
            return Ok(order);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<OrderList>> DeleteOrder(int id)
        {
            var result = orderDbContextClass.orderLists.Find(id);
            orderDbContextClass.orderLists.Remove(result);
            await orderDbContextClass.SaveChangesAsync();
            return Ok(result);
        }
    }
}
