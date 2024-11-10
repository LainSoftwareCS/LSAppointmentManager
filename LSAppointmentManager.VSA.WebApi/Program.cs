using LSAppointmentManager.Repositories;
using LSAppointmentManager.VSA.Services;
using System.ComponentModel;
using System.Reflection;
using LSAppointmentManager.VSA.Services.Endpoints;
//using LSAppointmentManager.Infrastructure.Impl.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.CustomSchemaIds(x =>
    {
        var att = x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault();
        if (att != null)
        {
            return att.DisplayName;
        }
        return x.Name;
    });
});
//builder.Services.AddSecurityServices();
builder.Services.AddMapping();
builder.Services.AddRepositories(builder.Configuration);
builder.Services.AddCors();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(c =>
    {
        c.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
}

app.UseHttpsRedirection();

//app.AddWorkstationEndpoints();
//app.AddCustomerEndpoints();
//app.AddWorkerEndpoints();
//app.AddAppointmentEndpoints();
app.AddSaleEndpoints();
//app.AddProductServiceEndpoints();
app.Run();