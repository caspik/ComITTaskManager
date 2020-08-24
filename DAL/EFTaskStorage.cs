using System;
using System.Collections.Generic;

using TaskManager.Models;

namespace TaskManager.DAL
{
    public class EFTaskStorage : IStoreTasks
    {
        readonly TaskManagerContext _context;
        public EFTaskStorage(TaskManagerContext myContext) {
            _context = myContext;
        }
        public List<TaskList> GetAllItems() {
            return new List<TaskList>();
        }

        public TaskList GetById(Guid id) {
            return new TaskList();
        }

        public void CreateTaskList (TaskList taskToCreate) {}

        public void UpdateTaskList (TaskList taskToUpdate) {}

        public void DeleteTaskList (Guid id) {}
    }
}