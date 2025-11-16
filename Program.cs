using MediatR;
using StudentManagement.Data;
using StudentManagement.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Force Development environment
builder.Environment.EnvironmentName = "Development";

// Register StudentStore as Singleton
builder.Services.AddSingleton<StudentStore>();

// Register Repository
builder.Services.AddScoped<IStudentRepository, InMemoryStudentRepository>();

// Register MediatR
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ALWAYS enable Swagger (no environment check)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Student Management API V1");
    c.RoutePrefix = "swagger"; // Access at /swagger
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();