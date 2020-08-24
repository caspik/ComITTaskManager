using System;
using System.Collections.Generic;

using TaskManager.Models;

namespace TaskManager.DAL
{
    public interface IStoreProjects
    {
        List<ProjectList> GetAllItems();

        ProjectList GetById(Guid id);

        void CreateProject (ProjectList projectToCreate);

        void UpdateProjectList (ProjectList taskToUpdate);

        void DeleteProjectList (Guid id);
    }
}