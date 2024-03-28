using assigment4_api.entities;
using Microsoft.EntityFrameworkCore;
//Logan Kranis
namespace assigment4_api.Data
{
    public class DBcontextClass : DbContext
    {
        public DBcontextClass(DbContextOptions<DBcontextClass> options) : base(options)
        { }
        public DbSet<Farm> Farm { get; set; }
        public DbSet<Weather> Weather { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farm>().ToTable((nameof(Farm)));
            modelBuilder.Entity<Farm>().HasKey(x => x.Id);
            modelBuilder.Entity<Farm>().Property(x => x.Id).ValueGeneratedOnAdd();


            modelBuilder.Entity<Weather>().ToTable(nameof(Weather));
            modelBuilder.Entity<Weather>().HasKey(x => x.Id);
            modelBuilder.Entity<Weather>().Property(x => x.Id).ValueGeneratedOnAdd();



        }
    }
}
