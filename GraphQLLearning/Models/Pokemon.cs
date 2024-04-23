using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLLearning.Models;

[Table("pokemon")]
public class Pokemon
{
    [Key]
    [Column("pokemon_id")]
    public int PokemonId { get; set; }
    
    [Column("pokemon_name")]
    public string PokemonName { get; set; }
    
    [Column("pokemon_type")]
    public List<PokemonType> PokemonTypes { get; set; }
    
    [Column("pokemon_weight")]
    public int PokemonWeight { get; set; }
    
    [Column("pokemon_height")]
    public int PokemonHeight { get; set; }
}