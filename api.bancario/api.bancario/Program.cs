using api.bancario.Validaciones;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Repository.Contexto;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidatorInterceptor<ActualizarClienteRequest>, ActualizarClienteValidacion>();
builder.Services.AddValidatorsFromAssemblyContaining <ActualizarClienteRequest()>;
// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<FiltroValidacion>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("postgresConnection");

builder.Services.AddDbContext<ContextoAplicacionDB>(Options =>
{
    Options.UseNpgsql(connectionString);
});

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
