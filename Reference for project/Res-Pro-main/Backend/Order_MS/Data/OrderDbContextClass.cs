using Microsoft.EntityFrameworkCore;
using Order_MS.Models;

namespace Order_MS.Data
{
    public class OrderDbContextClass: DbContext
    {
        public OrderDbContextClass(DbContextOptions<OrderDbContextClass> option) : base(option) 
        {
        }
        public DbSet<OrderList> orderLists { get; set; }
        public DbSet<Rating> rating { get; set; }
    }
}
