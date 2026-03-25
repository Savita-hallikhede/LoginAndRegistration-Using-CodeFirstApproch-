using code_second_approch.Models;
using Microsoft.EntityFrameworkCore;

namespace code_second_approch.Appdata
{
    public class mainCode : DbContext
    {
        public mainCode(DbContextOptions<mainCode> _dbContextOptions) : base(_dbContextOptions)
        {

        }
        public DbSet<code_second_approch.Models.register>  registers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            register reg = new register()
            {
                ID = 1,
                Name = "Admin",
                Email = "somya36@gmail.com",
                Password = "Admin@123",
                ConfirmPassword = "Admin@123",
                Phone = 1234567890
            };
            modelBuilder.Entity<register>().HasData(reg);

        }
    }
}
