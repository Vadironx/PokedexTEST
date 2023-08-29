using Microsoft.EntityFrameworkCore;

using Pokedex.Models;

namespace Pokedex.Util

{
    public class PokedexDbContext : DbContext
    {
        public DbSet<Pokemon> Name { get; set; }
        public DbSet<PokemonType> Type { get; set; }

        public PokedexDbContext(DbContextOptions<PokedexDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DESKTOP-VJDC2IQ");
        //    }
        //}
    }

}
