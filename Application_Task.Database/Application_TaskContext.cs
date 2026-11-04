using System;
using System.Collections.Generic;
using System.Text;
using Application_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Application_Task.Database
{
    public class Application_TaskContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<SubTaskModel> SubTasks { get; set; }

        public Application_TaskContext()
        {
            Database.Migrate(); 
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ApplicationTask.db");
            optionsBuilder.UseSqlite($"filename={DatabasePath}");

            //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            //var folderpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //var DatabaseName = "ApplicationTask.db";
            //var DatabasePath = Path.Combine(folderpath + DatabaseName);
        }
    }
}
