using GraphQLLearning.DataContext;
using GraphQLLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLLearning.Repositories;

public class PokemonRepository(PokemonContext context)
{
    public async Task<List<Pokemon>> GetPokemons()
    {
        return await context.Pokemons.Include(p => p.PokemonTypes).ToListAsync();
    }

    public async Task<Pokemon> GetPokemonById(int pokemonId)
    {
        return await context.Pokemons.Include(p => p.PokemonTypes).FirstOrDefaultAsync(p => p.PokemonId == pokemonId);
    }
}