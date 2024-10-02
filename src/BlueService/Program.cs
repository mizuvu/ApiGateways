var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var name = "Blue";

app.MapGet("/", () =>
{
    return $"{name}";
});

app.MapGet("/hello", () =>
{
    return $"Hello from {name}";
});

app.MapPost("/hello", () =>
{
    return $"Hello POST from {name}";
});


app.MapGet("/goodbye", () =>
{
    return $"Bye bye from {name}";
});

app.Run();
