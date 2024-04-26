using GraphQLLearning.Constants;

namespace GraphQLLearning.Middleware;

public static class AuthorizationServiceBuilder
{
    public static void AddAuthorizationPolicies(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy(Policy.PokemonReadWriteAllPolicy, policyBuilder =>
            {
                policyBuilder.RequireAssertion(context => context.User.IsInRole(Role.MobileAppReadWriteAll));
            });
        });
    }
}