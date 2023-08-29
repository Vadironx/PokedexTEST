using Microsoft.AspNetCore.Builder;

namespace Pokedex
{
    public class Startup
    {
        public void Configure(IServiceCollection services)
        {



            services.AddDbContext<PokedexDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
