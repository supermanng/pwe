using Application.Common.Extensions;
using Infrastructure.DependencyManager;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;


builder.Services.InjectService(config);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthenticationPlatform(config);
//builder.Services.AddSwaggerGen();
builder.Services.AddSwagger();
builder.Host.UseSerilog();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .CreateLogger();


builder.Services.AddControllers().AddNewtonsoftJson()
      .AddJsonOptions(opts =>
      {
          var enumConverter = new JsonStringEnumConverter();
          opts.JsonSerializerOptions.Converters.Add(enumConverter);
      });

var app = builder.Build();
app.ConfigureExceptionHandler();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseCors(x => x
            .SetIsOriginAllowed(origin => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());

app.Run();
