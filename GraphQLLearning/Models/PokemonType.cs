using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLLearning.Models;

[Table("pokemon_type")]
public class PokemonType
{
    [Column("pokemon_type_id")]
    [GraphQLName("id")]
    public int PokemonTypeId { get; set; }
    
    [Column("pokemon_type_name")]
    [GraphQLName("name")]
    public string PokemonTypeName { get; set; }
    
    [Column("pokemon")]
    [GraphQLName("pokemon")]
    public List<Pokemon> Pokemons { get; set; }
}