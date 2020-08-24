using System;
using System.Collections.Generic;

namespace TaskManager.Models
{
    public class ProjectList
    {
        public Guid Id { get; set; } 

        public Guid TaskListId {get;set;}

        public string ProjectName { get; set; }

        public DateTime ProjectStartDate { get; set; }

        public DateTime ProjectEndDate { get; set; }

        public bool IsDeleted {get;set;}
    }
}