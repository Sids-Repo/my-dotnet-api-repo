var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Blue-Green Deployment!");

app.MapGet("/health", () => "Healthy");

app.Run();
