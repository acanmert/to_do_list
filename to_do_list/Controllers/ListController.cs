using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using to_do_list.Business.Abstract;
using to_do_list.Entities;
using to_do_list.Models;

namespace to_do_list.Controllers
{
    public class ListController : Controller
    {
        private ITaskService _taskService;
     
        private User _user =new User();
        private TasksList _taskList =new TasksList();
        int userId;

        public ListController(ITaskService taskService)
        {
            _taskService = taskService;
           
        }

        [HttpGet]
        public IActionResult Main()
        {   
            TempData.Keep("UserId");
            _user.Id = Convert.ToInt32(TempData["UserId"]);
            
            _user.Name = TempData["UserName"].ToString();
            
            _taskList.Id = _user.Id;
            var deneme = getTasks(_user.Id);
            
            return View(getTasks(_user.Id));
        }

        [HttpPost]
        public IActionResult Main(string taskText)
        {
            TempData.Keep("UserId");

            userId = Convert.ToInt32(TempData["UserId"]);
            
            _taskList.Tasks = taskText;
            _taskList.UserId = userId;
            addTask(_taskList);
            return View(getTasks(userId));
        }
        public void addTask(TasksList tasks)
        {
            
            _taskService.create(tasks);
        }
        public List<TasksList> getTasks(int userId)
        {
            return _taskService.getTasks(userId);
        }
        [HttpPost]
        public IActionResult deleteTask(int Id)
        {
            var deletedTask= _taskService.getTaskbyId(Id);
            _taskService.delete(deletedTask);
            return View();
        }
        [HttpPost]
        public IActionResult updateTask(int Id)
        {
            var updatedTask = _taskService.getTaskbyId(Id);
            if (!updatedTask.Equals(null))
            {
                TempData["Id"] = updatedTask.Id;
                TempData["Tasks"] = updatedTask.Tasks;
                TempData["UserId"] = updatedTask.Id;
                TempData.Keep("UserId");

                return RedirectToAction("updated", "List", updatedTask);
            }
            throw new Exception("Hata");  
            
        }
    }
}
