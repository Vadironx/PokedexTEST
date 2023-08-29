using Microsoft.EntityFrameworkCore;

namespace Pokedex.Util
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
  
            services.AddDbContext<PokedexDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
