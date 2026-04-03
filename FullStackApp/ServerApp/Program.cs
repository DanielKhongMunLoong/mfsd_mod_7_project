var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(); 
// 1. Add the Output Cache service
builder.Services.AddOutputCache(); 

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

// 2. Use the Output Cache middleware
app.UseOutputCache(); 

app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Rugged Laptop", Price = 1200.50, Stock = 25, Category = new { Id = 101, Name = "Electronics" } },
        new { Id = 2, Name = "Noise cancelling headphones", Price = 50.00, Stock = 100,  Category = new { Id = 102, Name = "Accessories" } },
        new { Id = 3, Name = "Monitor 27 inch", Price = 350.00, Stock = 50,  Category = new { Id = 103, Name = "Displays" } },
        new { Id = 4, Name = "High sensitivity mouse", Price = 250.00, Stock = 70,  Category = new { Id = 104, Name = "Computing peripherals"} }
    };
});

app.Run();