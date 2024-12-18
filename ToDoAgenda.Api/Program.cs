using ToDoAgenda.Business.Abstract.UserServices;
using ToDoAgenda.Business.Concrete.Managers.UserManager;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllers();

builder.Services.AddScoped<IUserDal, EfCoreUserDal>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();