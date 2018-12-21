using DateMaster.API.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace DateMaster.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}