using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using computer_build_assistant_admin_app.Data;
using Neo4j.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
var uri = builder.Configuration["NeO4jConnectionSettings:Server"];
var user = builder.Configuration["NeO4jConnectionSettings:UserName"];
var pass = builder.Configuration["NeO4jConnectionSettings:Password"];
builder.Services.AddSingleton(GraphDatabase.Driver(uri, AuthTokens.Basic(user, pass)));

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
