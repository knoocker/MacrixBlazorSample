using MacrixBlazorSample.Services;
using System.Globalization;
using System.Net;
using static System.Net.WebRequestMethods;


namespace MacrixBlazorSample
{
    public class Startup
    {
  //      private readonly IWebHostEnvironment env;


        public IConfiguration Configuration { get; }

        public Startup()//IWebHostEnvironment env)
        {
           // string environment = env.EnvironmentName;

            //Configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .AddJsonFile($"appsettings.{environment}.json")
            //    .Build();
           // this.env = env;
        }


        public void ConfigureServices(IServiceCollection services)
        {

            var apiAddress = @"https://localhost:7134/api/";// Configuration["ApiAddress"];

            services.AddHttpClient<IPersonsService, PersonsService>(
    client => client.BaseAddress = new Uri(apiAddress));

        }

    }
}
