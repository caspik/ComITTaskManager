using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            var result = _context.Tasks.ToList();
            return result;
        }

        public TaskList GetById(Guid id) {
            return new TaskList();
        }

        public void CreateTaskList (TaskList taskToCreate) {
            _context.Add(taskToCreate);
            _context.SaveChanges();
        }

        public void UpdateTaskList (TaskList taskToUpdate) {
            _context.Update(taskToUpdate);
            _context.SaveChanges();
        }

        public void DeleteTaskList (Guid id) {
            
        }
    }
}