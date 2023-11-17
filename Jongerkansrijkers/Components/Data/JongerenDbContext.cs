using Jongerkansrijkers.Components.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Jongerkansrijkers.Components.Data
{
    public class JongerenDbContext(DbContextOptions<JongerenDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Instutuut> Instutuuts { get; set; }
        public DbSet<Jongeren> Jongeren {  get; set; }

        public DbSet<Activiteit> Activiteiten { get; set; }

    }

   
}
