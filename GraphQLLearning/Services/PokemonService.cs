using GraphQLLearning.Models;
using GraphQLLearning.Repositories;

namespace GraphQLLearning.Services;

public class PokemonService(PokemonRepository pokemonRepository)
{
    public async Task<List<Pokemon>> GetPokemons()
    {
        return await pokemonRepository.GetPokemons();
    }
    
    public async Task<Pokemon> GetPokemonById(int pokemonId)
    {
        return await pokemonRepository.GetPokemonById(pokemonId);
    }
}