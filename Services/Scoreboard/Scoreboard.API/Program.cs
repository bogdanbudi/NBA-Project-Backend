using Scoreboard.Application;
using Scoreboard.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddInfrastructureServices(configuration);


//services cors
builder.Services.AddCors(p => p.AddPolicy("angularUI", builder =>
{
    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();
//IConfiguration configuration = app.Configuration;

//builder.Services.AddInfrastructureServices(configuration);



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app cors
app.UseCors("angularUI");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
