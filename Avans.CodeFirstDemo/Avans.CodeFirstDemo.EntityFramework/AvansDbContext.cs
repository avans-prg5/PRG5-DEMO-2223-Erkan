using Avans.CodeFirstDemo.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Avans.CodeFirstDemo.EntityFramework
{
    public partial class AvansDbContext : DbContext
    {
        public AvansDbContext(DbContextOptions<AvansDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NB221249;Initial Catalog=CodeFirstDemo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            // Configuration voor de Entities.
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
