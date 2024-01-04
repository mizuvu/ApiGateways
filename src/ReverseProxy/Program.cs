var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add the reverse proxy capability to the server
builder.Services.AddReverseProxy()
    // Initialize the reverse proxy from the "ReverseProxy" section of configuration
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// Register the reverse proxy routes
app.MapReverseProxy();

app.Run();
