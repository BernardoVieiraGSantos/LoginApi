using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configuração de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirOrigemLocal", policy =>
    {
        policy.WithOrigins("http://localhost:8080") // Substitua pela URL do frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Adicionar o middleware de CORS
app.UseCors("PermitirOrigemLocal");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
