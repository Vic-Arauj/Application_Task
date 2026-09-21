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
    }
}
