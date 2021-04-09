using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Staffinfo.Entities
{
    public class DBContext : DbContext
    {
        private IConfigurationRoot _config;
        public DBContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffSalary> Salary { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
           //connection string get by appsetting.json
        }
    }
} 