using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using Task = TaskAPI.Models.Task;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        //GetAllTasks
        [HttpGet(nameof(GetAllTasks))]
        public IEnumerable<Task> GetAllTasks()
        {
            return FakeDB.tasks;
        }

        //GetTaskById
        [HttpGet("{id}")]
        public ActionResult<Task> GetTaskById(int id)
        {
            Task task = FakeDB.tasks.Find(t => t.TaskId == id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        //CreateTask
        [HttpPost()]
        public ActionResult<Task> CreateTask(Task task)
        {
            FakeDB.tasks.Add(task);
            if (task == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        //UpdateTask
        [HttpPatch]
        public ActionResult<Task> UpdateTask(int id, Task task)
        {
            Task taskToUpdate = FakeDB.tasks.Find(t => t.TaskId == id);

            

        }

        //DeleteTask
        [HttpDelete("{id}")]
        public ActionResult<Task> DeleteTask(int id)
        {
            Task task = FakeDB.tasks.Find(t =>t.TaskId == id);
            if (task == null) 
            {
                return NotFound();
            }

           FakeDB.tasks.Remove(task);
           
           return Ok();
        }
    } 
}
