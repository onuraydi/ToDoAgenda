using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;
using TODoAgenda.Entities.Concrete.ResultEntities;
using Task = TODoAgenda.Entities.Concrete.Task;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore
{
    public class ToDoAgendaContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public ToDoAgendaContext()  // hata almamak için gerekli
        {

        }

        public ToDoAgendaContext(DbContextOptions<ToDoAgendaContext> options,IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connectionString = _configuration.GetConnectionString("DefaultConnection");
                //optionsBuilder.UseNpgsql("Server = localhost; Port = 8001;Database = ToDoAgendaDb2 ; user Id = postgres; Password=123456Aa*;");
                optionsBuilder.UseNpgsql("Server = localhost; Port = 8000;Database = ToDoAgendaDb ; user Id = postgres; Password=123456Aa*;");
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Timer> Timers { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ResultType> ResultTypes { get; set; }
        public DbSet<ImportanceLevel> ImportanceLevels { get; set; }
        public DbSet<DefinedTask> DefinedTasks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
