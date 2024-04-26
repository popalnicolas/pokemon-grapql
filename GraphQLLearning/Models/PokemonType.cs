using System.ComponentModel.DataAnnotations.Schema;
using GraphQLLearning.Constants;
using HotChocolate.Authorization;

namespace GraphQLLearning.Models;

[Table("pokemon_type")]
public class PokemonType
{
    [Column("pokemon_type_id")]
    [GraphQLName("id")]
    [Authorize(Policy = Policy.PokemonReadWriteAllPolicy)]
    public int PokemonTypeId { get; set; }
    
    [Column("pokemon_type_name")]
    [GraphQLName("name")]
    public string PokemonTypeName { get; set; }
    
    [Column("pokemon")]
    [GraphQLIgnore]
    public List<Pokemon> Pokemons { get; set; }
}