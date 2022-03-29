using CosmosDbPocInfra.Configuration;
using CosmosDbPocInfra.Interfaces;
using CosmosDbPocInfra.Interfaces.CosmosDb;
using CosmosDbPocInfra.Repositorys;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
