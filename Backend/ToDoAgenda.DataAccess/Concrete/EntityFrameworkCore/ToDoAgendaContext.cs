using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAgenda.Entities.Concrete;
using Task = TODoAgenda.Entities.Concrete.Task;
using Timer = TODoAgenda.Entities.Concrete.Timer;

namespace ToDoAgenda.DataAccess.Concrete.EntityFrameworkCore
{
    public class ToDoAgendaContext:DbContext
    {
        public ToDoAgendaContext()
        {

        }
        public ToDoAgendaContext(DbContextOptions<ToDoAgendaContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Timer> Timers { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ImportanceLevel> ImportanceLevels { get; set; }
        public DbSet<DefinedTask> DefinedTasks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
