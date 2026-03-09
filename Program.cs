using Microsoft.EntityFrameworkCore;
using secureapp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Example DB registration if you have it
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("SecureDb"));

var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

// IMPORTANT: Do NOT specify a port
app.Run();