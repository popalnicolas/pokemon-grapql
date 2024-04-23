using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLLearning.Models;

[Table("pokemon_type")]
public class PokemonType
{
    [Column("pokemon_type_id")]
    public int PokemonTypeId { get; set; }
    
    [Column("pokemon_type_name")]
    public string PokemonTypeName { get; set; }
    
    [Column("pokemon")]
    public List<Pokemon> Pokemons { get; set; }
}