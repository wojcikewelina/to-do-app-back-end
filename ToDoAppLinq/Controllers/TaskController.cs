using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        private ITaskRepository _TaskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _TaskRepository = taskRepository;
        }

        [HttpGet]

        public ActionResult Get()
        {
            return Ok(_TaskRepository.GetAllTasks());
        }

        [HttpPost]
        public ActionResult Add(Task task)
        {
            _TaskRepository.AddTask(task);
            return Ok("created");
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, Task task)
        {
            _TaskRepository.EditTask(id, task);
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _TaskRepository.DeleteTask(id);
            return Ok();
        }

    }
}