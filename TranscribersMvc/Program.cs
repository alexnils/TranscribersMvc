using TranscribersMvc.Models;

namespace TranscribersMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Support for controllers and views
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();

            var app = builder.Build();

            app.UseStaticFiles();

            // Support for mapping HTTP requests to the controllers
            app.UseRouting();

            // Support for route attributes on the action methods
            app.UseEndpoints(o => o.MapControllers());

            


            app.Run();

        }
    }
}