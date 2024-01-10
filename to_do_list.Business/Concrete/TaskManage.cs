using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Business.Abstract;
using to_do_list.DataAccess.Abstract;
using to_do_list.DataAccess.Concrete;
using to_do_list.Entities;

namespace to_do_list.Business.Concrete
{
    public class TaskManage : ITaskService
    {
        private TaskRepository _taskRepository;
        public TaskManage()
        {
            _taskRepository = new TaskRepository();
        }
        public TasksList create(TasksList tasksList)
        {
            if(!tasksList.Equals(null))
                _taskRepository.create(tasksList);
            return tasksList;
        }

        public void delete(TasksList tasksList)
        {
            if (!tasksList.Equals(null))
                _taskRepository.delete(tasksList);
        }

        public TasksList getTaskbyId(int taskId)
        {
            return _taskRepository.getTaskbyId(taskId);
        }

       

        public List<TasksList> getTasks(int userId)
        {
            
             return _taskRepository.getTask(userId);
        }

        public void updateTask(TasksList tasksList)
        {
            _taskRepository.updateTask(tasksList);
        }
    }
}
