using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using TaskManager.Models;

namespace TaskManager.DAL
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) {}
        public DbSet<TaskList> Tasks {get;set;}
    }
}