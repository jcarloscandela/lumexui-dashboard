using Blazor.Sonner.Extensions;
using LumexDashboard.Shared.Services;
using LumexUI.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<LumexDashboard.Wasm.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddLumexServices();
builder.Services.AddSonner();
builder.Services.AddScoped<AppStateService>();

await builder.Build().RunAsync();
