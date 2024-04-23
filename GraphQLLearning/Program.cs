using GraphQLLearning;
using GraphQLLearning.DataContext;
using GraphQLLearning.Repositories;
using GraphQLLearning.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<PokemonRepository>();

builder.Services.AddScoped<PokemonService>();

builder.Services.AddDbContext<PokemonContext>(options =>
{
    options.UseSqlServer("Server=127.0.0.1;Database=pokemons;User Id=SA;Password=yourStrong(!)Password;TrustServerCertificate=True");
});

builder.Services
    .AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapGraphQL();

app.Run();
