namespace User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddHttpClient();
            var app = builder.Build();

            app.UseRouting();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
