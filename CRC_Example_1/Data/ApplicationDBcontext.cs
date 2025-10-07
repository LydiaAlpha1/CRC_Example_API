using CRC_Example_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRC_Example_1.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
