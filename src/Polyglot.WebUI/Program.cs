using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Polyglot.Application;
using Polyglot.WebUI;
using Polyglot.WebUI.StateContainers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IVocabularyService, VocabularyService>();
builder.Services.AddScoped<PracticeSetupContainer>();

var app = builder.Build();

var service = app.Services.GetRequiredService<IVocabularyService>();

await service.InitializeAsync(default);

await app.RunAsync();
