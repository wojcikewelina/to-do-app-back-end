using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public List<Task> GetAllTasks()
        {
            using (var dbContext = new ToDoContext())
            {
                return dbContext.Tasks.ToList();
            }
        }

        public void AddTask(Task newTask)
        {
            using (var dbContext = new ToDoContext())
            {
                dbContext.Tasks.Add(newTask);
                dbContext.SaveChanges();
            }
        }

        public void EditTask(int id, Task task)
        {
            using (var db = new ToDoContext())
            {
                var existBook = db.Tasks.Single(x => x.Id == id);
                existBook.Name = task.Name;
                existBook.Status = task.Status;
                db.SaveChanges();
            }
        }

        public void DeleteTask(int id)
        {
            using (var dbContext = new ToDoContext())
            {
                var task = dbContext.Tasks.FirstOrDefault(x => x.Id == id);
                dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }
        }

     
    }
}
