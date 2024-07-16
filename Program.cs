using Lucky.WebAPI.Extensions;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuring logger
builder.Services.ConfigureLogger();

// configure global exception handler
builder.Services.ConfigureExceptionHandler();

// configure database context
builder.Services.ConfigureDbContext(builder.Configuration);

// configure Identity
builder.Services.ConfigureIdentity();

// configure jwt
builder.Services.ConfigureJwt(builder.Configuration);

// configure CORS (Cross Origin Resource Sharing)
builder.Services.ConfigureCors();

// configure service manager
builder.Services.ConfigureServiceManager();

// configure repository manager
builder.Services.ConfigureRepositoryManager();

// configure mapper
builder.Services.ConfigureMapper();


var app = builder.Build();

app.UseExceptionHandler(opt => { });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
