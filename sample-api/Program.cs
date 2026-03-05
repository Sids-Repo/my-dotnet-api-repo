var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello from .NET API running on AWS!");

app.MapGet("/health", () => "Healthy");

app.Run();
