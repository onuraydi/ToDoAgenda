using ToDoAgenda.Business.Abstract.UserServices;
using ToDoAgenda.Business.Concrete.Managers.UserManager;
using ToDoAgenda.DataAccess.Abstract.ForEntity;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore.ForEntity;
using AutoMapper;
using ToDoAgenda.Business.Abstract.TimerServices;
using ToDoAgenda.Business.Concrete.Managers.TimerManagers;
using ToDoAgenda.Business.Abstract.TaskServices;
using ToDoAgenda.Business.Concrete.Managers.TaskManagers;
using ToDoAgenda.Business.Abstract.SettingServices;
using ToDoAgenda.Business.Concrete.Managers.SettingManagers;
using ToDoAgenda.Business.Abstract.ResutlServices;
using ToDoAgenda.Business.Concrete.Managers.ResultManagers;
using ToDoAgenda.Business.Abstract.ImportanceLevelServices;
using ToDoAgenda.Business.Concrete.Managers.ImportanceLevelManagers;
using ToDoAgenda.Business.Abstract.DefinedTaskServices;
using ToDoAgenda.Business.Concrete.Managers.DefinedTaskManagers;
using Microsoft.EntityFrameworkCore;
using ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore;
using FluentValidation;
using TODoAgenda.Entities.Concrete;
using ToDoAgenda.Business.ValidationRules.FluentValidation;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllers();


builder.Services.AddDbContext<ToDoAgendaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));



// Dependency injeciton ile farklý birþeyler yapýlabilir mi araþtýr ve uygula

builder.Services.AddScoped<IUserDal, EfCoreUserDal>();
builder.Services.AddScoped<IUserService, UserManager>();

builder.Services.AddScoped<ITimerDal, EfCoreTimerDal>();
builder.Services.AddScoped<ITimerService, TimerManager>();

builder.Services.AddScoped<ITaskDal, EfCoreTaskDal>();
builder.Services.AddScoped<ITaskService, TaskManager>();

builder.Services.AddScoped<ISettingDal, EfCoreSettingDal>();
builder.Services.AddScoped<ISettingService, SettingManager>();

builder.Services.AddScoped<IResultDal, EfCoreResultDal>();
builder.Services.AddScoped<IResultService,ResultManager>();

builder.Services.AddScoped<IImportanceLevelDal, EfCoreImportanceLevelDal>();
builder.Services.AddScoped<IImportanceLevelService, ImportanceLevelManager>();

builder.Services.AddScoped<IDefinedTaskDal, EfCoreDefinedTaskDal>();
builder.Services.AddScoped<IDefinedTaskService, DefinedTaskManager>();
builder.Services.AddScoped<IValidator<DefinedTask>, DefinedTaskValidator>();

/////////////////////////////////////////////////////////////////////////////////////


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