using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using VoeAirlinesBlazor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<VoeAirlinesBlazor.Pages.Services.AppData>();
builder.Services.AddScoped
(
    s =>
    {
        return new HttpClient { BaseAddress = new Uri(@"http://jonatasx-001-site1.ftempurl.com/login") };
    }
);

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();