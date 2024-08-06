using Microsoft.Extensions.DependencyInjection;

namespace IAutherServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddIdentityServer()
                .AddInMemoryClients(Configuration.GetClients)
                .AddInMemoryApiResources(Configuration.GetApiResources())
                .AddInMemoryIdentityResources(Configuration.GetIdentityResources())
                .AddDeveloperSigningCredential()
                .AddInMemoryApiScopes(Configuration.GetApiScopes());

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseIdentityServer();
            app.MapDefaultControllerRoute();
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
