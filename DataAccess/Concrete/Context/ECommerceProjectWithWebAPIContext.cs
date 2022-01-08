using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Context
{
    public class ECommerceProjectWithWebAPIContext: DbContext
    {
        public ECommerceProjectWithWebAPIContext(DbContextOptions<ECommerceProjectWithWebAPIContext> options):base(options)
        {

        }
        public ECommerceProjectWithWebAPIContext()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ECommerceProjectWithWebAPIDb; Integrated Security = True;";
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
        public virtual DbSet<User> Users { get; set; }
    }
}
