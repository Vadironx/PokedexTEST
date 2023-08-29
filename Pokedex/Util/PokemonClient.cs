using Pokedex.Models;
using System.Text.Json;


//using Microsoft.EntityFrameworkCore;


namespace Pokedex.Util
{
    public class PokemonClient
    {
        public HttpClient Client { get; set; }
        //private readonly PokedexDbContext _context;
        public PokemonClient(HttpClient client/*, PokedexDbContext context*/)
        {
            this.Client = client;
            //_context = context;
        }


        public async Task<Pokemon> GetPokemon(string id)
        { 
            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Pokemon>(content);
            }

        //public async Task SavePokemonToDatabase(string id)
        //{
        //    var pokemonFromAPI = await GetPokemon(id);

        //    var pokemonToAdd = new Pokemon
        //    {
        //        id = pokemonFromAPI.id,
        //        name = pokemonFromAPI.name,
        //        types = pokemonFromAPI.types.Select(types => new PokemonType { type = types.type }).ToList()
        //    };

        //    _context.Name.Add(pokemonToAdd);
        //    await _context.SaveChangesAsync();
        //}


    }
}
