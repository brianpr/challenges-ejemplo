using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class Context: DbContext
    {
        public DbSet<Challenge> Challenges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=challenges;Integrated Security=SSPI;Trusted_Connection=True;Encrypt=False;");
        }
    }
}