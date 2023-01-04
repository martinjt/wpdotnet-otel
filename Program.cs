using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWordPress(o => {});

// Add services to the container.

builder.Services.AddOpenTelemetryTracing(o => {
    o.AddHoneycomb(builder.Configuration)
     .AddSource("MySqlConnector")
     .AddAspNetCoreInstrumentation();
});

var app = builder.Build();

app.UseWordPress();

app.Run();
