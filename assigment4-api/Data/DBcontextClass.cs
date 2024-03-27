using assigment4_api.entities;
using Microsoft.EntityFrameworkCore;
//Logan Kranis
namespace assigment4_api.Data
{
    public class DBcontextClass : DbContext
    {
        public DBcontextClass(DbContextOptions<DBcontextClass> options) : base (options)
        { }
        public DbSet<Farm> Farm { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farm>().ToTable((nameof(Farm)));
            modelBuilder.Entity<Farm>().HasKey(x => x.FARM_ID);
            modelBuilder.Entity<Farm>().Property(x => x.FARM_ID).ValueGeneratedOnAdd();
        }



    }
}
