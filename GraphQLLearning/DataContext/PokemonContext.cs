using GraphQLLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLLearning.DataContext;

public class PokemonContext(DbContextOptions<PokemonContext> options): DbContext(options)
{
    public DbSet<Pokemon> Pokemons { get; set; } = null!;
    public DbSet<PokemonType> PokemonTypes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pokemon>(p =>
        {
            p.HasMany<PokemonType>(pk => pk.PokemonTypes).WithMany(pt => pt.Pokemons)
                .UsingEntity("pokemons_pokemon_types",
                    pk => pk.HasOne(typeof(PokemonType)).WithMany().HasForeignKey("pokemon_type_id"),
                    pt => pt.HasOne(typeof(Pokemon)).WithMany().HasForeignKey("pokemon_id"));
        });
    }
}