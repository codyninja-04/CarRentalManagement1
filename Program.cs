using CarRentalManagement.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CarRentalManagement.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<CarRentalManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentalManagementContext") ?? throw new InvalidOperationException("Connection string 'CarRentalManagementContext' not found.")));
//Add the API controller
builder.Services.AddControllers();

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Add the Default controller route
app.MapDefaultControllerRoute();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
