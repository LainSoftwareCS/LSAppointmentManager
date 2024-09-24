using LSAppointmenteManager.Application;
using LSAppointmentManager.Persistance;
using LSAppointmentManager.WebAPI.Endpoints;
using Valibute.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
builder.Services.AddPersistanceServices(builder.Configuration);
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors(options =>
    options
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()
    );

app.UseValibute();

app.AddWorkstationEndpoints();

app.Run();

