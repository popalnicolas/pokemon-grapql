using GraphQLLearning.Models;
using GraphQLLearning.Services;
using HotChocolate.Authorization;

namespace GraphQLLearning;

public class Query
{
    [Authorize]
    public async Task<List<Pokemon>> GetPokemons([Service] PokemonService pokemonService)
    {
        return await pokemonService.GetPokemons();
    }

    public async Task<Pokemon> GetPokemonById([Service] PokemonService pokemonService, int pokemonId)
    {
        return await pokemonService.GetPokemonById(pokemonId);
    }
}