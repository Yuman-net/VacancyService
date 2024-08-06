using IdentityModel;
using IdentityServer4.Models;

namespace IAutherServer
{
    public static class Configuration
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource> {
                new IdentityResources.OpenId(),
            };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>{
                new ApiResource("OrderAPI") {Scopes = new List<string>() {  "OrderAPI" }}};

        public static IEnumerable<Client> GetClients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client_id",
                    ClientSecrets = { new Secret("client_secret".ToSha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    AllowedScopes =
                    {
                        "OrderAPI",
                    },
                }
            };

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
                {
                    new ApiScope("OrderAPI")
                };
        }
    }
}
