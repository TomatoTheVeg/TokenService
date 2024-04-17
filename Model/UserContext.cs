using Microsoft.EntityFrameworkCore;

namespace TokenManagement.Model
{
    public class UserContext: DbContext
    {
        DbSet<User> Users { get; init; }

        public UserContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database = TokenUserDb");
        }
    }
}
