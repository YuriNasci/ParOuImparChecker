var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]);

builder.Services.AddHealthChecks();
builder.Services
    .AddHealthChecksUI(setupSettings: setup =>
    {
        setup.AddHealthCheckEndpoint("Swagger Api", "/api/verificar-paridade?numeroEntrada=4&parOuImpar=par");
    });

builder.Services.AddHealthChecksUI().AddInMemoryStorage();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app
    .UseRouting()
    .UseEndpoints(config => config.MapHealthChecksUI());

app.Run();


