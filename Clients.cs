using System.Collections.Generic;
using IdentityServer4.Models;

internal class Clients
{
    public static IEnumerable<Client> Get()
    {
        return new List<Client> {
            new Client {
                ClientId = "oauthClient",
                ClientName = "Example client application using client credentials",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> { new Secret("password".Sha256())},
                AllowedScopes = new List<string> { "api1.read"}
            }
        };
    }
}