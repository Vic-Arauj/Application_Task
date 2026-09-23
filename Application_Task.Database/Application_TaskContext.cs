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
        public DbSet<SubTaskModel> SubTask { get; set; }

        public Application_TaskContext()
        { 
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //var folderpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //var DatabaseName = "ApplicationTask.db";
            //var DatabasePath = Path.Combine(folderpath + DatabaseName);

            var DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ApplicationTask.db");
            optionsBuilder.UseSqlite($"filename={DatabasePath}");
        }
    }
    public static class DatabaseStart
    {
        public static void Initialize()
        {
            using (var context = new Application_TaskContext())
            {
                context.Database.Migrate();
            }
        }
    }
}
