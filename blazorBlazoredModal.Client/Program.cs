using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.Modal;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();
