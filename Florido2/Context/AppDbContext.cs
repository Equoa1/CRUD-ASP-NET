using Florido2.Models;
using Microsoft.EntityFrameworkCore;

namespace Florido2.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
