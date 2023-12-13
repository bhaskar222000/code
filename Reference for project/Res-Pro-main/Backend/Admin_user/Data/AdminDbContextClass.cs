using Admin_user_MS.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin_user_MS.Data
{
    public class AdminDbContextClass :DbContext 
    {
        public AdminDbContextClass(DbContextOptions<AdminDbContextClass>option):base(option)
        {
            
        }
        public DbSet<AdminUser> ADMIN_USER { get; set; }
    }
}
