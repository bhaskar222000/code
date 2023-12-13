using Menu_MS.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu_MS.Data
{
    public class ProductDBContextClass: DbContext
    {
        public ProductDBContextClass(DbContextOptions<ProductDBContextClass>option):base(option)
        {

        }
        public DbSet<FoodList01> foodLists { get; set; }
    }
}
