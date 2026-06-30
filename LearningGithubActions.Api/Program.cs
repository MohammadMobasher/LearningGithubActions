using LearningGithubActions.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CalculatorService>();

var app = builder.Build();


// api1
app.MapGet("/", () => "Learning GitHub Actions Demo API");

// api2
app.MapGet("/hello", () =>
{
    return Results.Ok(new
    {
        Message = "Hello World!",
        Time = DateTime.UtcNow
    });
});

// api3
app.MapGet("/sum", (int a, int b, CalculatorService calculator) =>
{
    return Results.Ok(new
    {
        Result = calculator.Sum(a, b)
    });
});

app.Run();
