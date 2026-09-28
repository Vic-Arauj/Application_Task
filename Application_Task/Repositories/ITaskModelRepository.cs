using Application_Task.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Task.Repositories
{
    public interface ITaskModelRepository
    {
        IList<TaskModel> GetTaskModels();
        TaskModel GetById(int id);
        void Add(TaskModel task);
        void Update(TaskModel task);
        void Delete(TaskModel task);

    }
}
