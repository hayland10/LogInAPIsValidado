using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


//htpclinet 
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/") });



var app = builder.Build();


app.UseStaticFiles();


app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
