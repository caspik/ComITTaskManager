using System;
using System.Collections.Generic;

namespace TaskManager.Models
{
    public class TaskList
    {
        public Guid Id { get; set; } 

        public string Name { get; set; }

        public DateTime TaskStartDate { get; set; }

        public DateTime TaskEndDate { get; set; }

        public List<ProjectList> Projects {get;set;}

        public bool IsDeleted {get;set;}
    }
}