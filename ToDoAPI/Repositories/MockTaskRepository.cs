using System;
using System.Collections.Generic;
using System.Text;
using ToDoDataAccess.Interfaces;

namespace ToDoDataAccess.Models
{
    public class MockTaskRepository : ITaskRepository
    {

        public List<Task> GetAllTasks()
        {
            return new List<Task>()
            {
                new Task(){Id=1, Name="Nauczy się grać na gitarze", Status= "done"}
            };
        }

        void ITaskRepository.AddTask(Task task)
        {
            throw new NotImplementedException();
        }

        void ITaskRepository.DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        void ITaskRepository.EditTask(int id,Task task)
        {
            throw new NotImplementedException();
        }

        List<Task> ITaskRepository.GetAllTasks()
        {
            throw new NotImplementedException();
        }
    }
}
