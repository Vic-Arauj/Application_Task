using Application_Task.Database;
using Application_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Task.Repositories
{
    public class TaskModelRepository : ITaskModelRepository
    {
        private Application_TaskContext _db;
        public TaskModelRepository()
        {
            _db = new Application_TaskContext();
        }
        public IList<TaskModel> GetTaskModels()
        {
           return _db.Tasks.AsNoTracking().OrderByDescending(a => a.TaskDate).ToList();
        }
        public TaskModel GetById(int id)
        {
            return _db.Tasks.Include(a=> a.SubTask).FirstOrDefault(a=> a.Id == id);
        }
        public void Add(TaskModel task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }
        public void Update(TaskModel task)
        {
            _db.Tasks.Update(task);
            _db.SaveChanges();
        }
        public void Delete(TaskModel task)
        {
            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }

      
    }
}
