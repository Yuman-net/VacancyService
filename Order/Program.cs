using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Order
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            builder.Services.AddHttpClient();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, config =>
                {
                    config.Authority = "http://localhost:5207";
                    config.Audience = "OrderAPI";
                });

            var app = builder.Build();

            app.UseAuthentication();
            
            app.UseRouting();

            app.UseAuthorization();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
