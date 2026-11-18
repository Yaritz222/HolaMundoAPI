var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api/hola", () =>
{
    return Results.Ok(new
    {
        mensaje = "Hola Mundo",
        lenguaje = "C#",
        framework = "ASP.NET Core Web API"
    });
});

app.Run();