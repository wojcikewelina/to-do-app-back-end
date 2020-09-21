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

        private ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]

        public ActionResult Get()
        {
            return Ok(_taskRepository.GetAllTasks());
        }

        [HttpPost]
        public ActionResult Add(Task task)
        {
            _taskRepository.AddTask(task);
            return Ok("created");
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, Task task)
        {
            _taskRepository.EditTask(id, task);
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _taskRepository.DeleteTask(id);
            return Ok();
        }

    }
}