global using Blazor.Shared;
global using Microsoft.EntityFrameworkCore;
global using Blazor.Server.Data;
global using Blazor.Server.Services.BookServices;
using Microsoft.AspNetCore.ResponseCompression;
using Blazor.Server.Services.CategoryService;
using Blazor.Server.Hubs;
using Microsoft.AspNetCore.Builder;
using Blazor.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IReposetory<BookSegesstion>, BookSgtReposetory>();
builder.Services.AddSignalR();

var app = builder.Build();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();



app.MapHub<BookSgtHub>("/hubs/BookSgtHub");

app.MapFallbackToFile("index.html");

app.Run();
