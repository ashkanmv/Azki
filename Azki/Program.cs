using azki.Repositories;
using azki.Service;
using Azki.Repositories;
using Azki.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAny", b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
});

builder.Services.AddScoped<IInstrumentService, InstrumentService>();
builder.Services.AddScoped<IInstrumentRepository, InstrumentRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<LogRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAny");

app.UseAuthorization();

app.MapControllers();

app.Run();
