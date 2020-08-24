using System;
using System.Collections.Generic;

using TaskManager.Models;

namespace TaskManager.DAL
{
    public interface IStoreTasks
    {
        List<TaskList> GetAllItems();

        TaskList GetById(Guid id);

        void CreateTaskList (TaskList taskToCreate);

        void UpdateTaskList (TaskList taskToUpdate);

        void DeleteTaskList (Guid id);
    }
}