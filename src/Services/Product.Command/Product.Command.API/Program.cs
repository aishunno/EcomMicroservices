using Carter;
using Framework.Core.Exceptions.Handlers;
using Product.Command.Application;
using Product.Command.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();

builder.Services.AddExceptionHandler<CustomExceptionHandler>();

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapCarter();

app.UseExceptionHandler(options => { });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
