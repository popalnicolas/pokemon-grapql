using GraphQLLearning;
using GraphQLLearning.DataContext;
using GraphQLLearning.Repositories;
using GraphQLLearning.Services;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<PokemonRepository>();

builder.Services.AddScoped<PokemonService>();

builder.Services.AddDbContext<PokemonContext>(options =>
{
    options.UseSqlServer("Server=127.0.0.1;Database=pokemons;User Id=SA;Password=yourStrong(!)Password;TrustServerCertificate=True");
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"))
    .EnableTokenAcquisitionToCallDownstreamApi()
    .AddInMemoryTokenCaches();
builder.Services.AddAuthorization();

builder.Services
    .AddGraphQLServer().AddAuthorization().AddQueryType<Query>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();
