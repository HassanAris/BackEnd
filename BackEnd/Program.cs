using BackEnd.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione a configuração de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Adicionando serviços
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<LivroService>();
builder.Services.AddAutoMapper(typeof(EntitiesToDTOMappingProfile));

// Adicionando controllers
builder.Services.AddControllers();

// Adicionando Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("BancoLivro"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Usar CORS
app.UseCors("AllowAllOrigins");

// Configurar o pipeline de solicitações HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
