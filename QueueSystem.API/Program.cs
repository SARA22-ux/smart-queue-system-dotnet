using QueueSystem.Application.Interfaces;
using QueueSystem.Application.Services;
using QueueSystem.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;




// Services
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IQueueService, QueueService>();

var app = builder.Build();

app.UseDeveloperExceptionPage(); 

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();