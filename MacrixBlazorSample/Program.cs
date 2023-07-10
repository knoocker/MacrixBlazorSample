using MacrixBlazorSample;
using MacrixBlazorSample.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var apiAddress = @"https://localhost:7134/api/";// Configuration["ApiAddress"];

builder.Services.AddHttpClient<IPersonsService, PersonsService>(
client => client.BaseAddress = new Uri(apiAddress));




await builder.Build().RunAsync();
