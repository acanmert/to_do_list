using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.DataAccess.Abstract;
using to_do_list.Entities;

namespace to_do_list.DataAccess.Concrete
{
    public class TaskRepository : ITaskRepository
    {
        public TasksList create(TasksList tasksList)
        {
            using (var taskDbContext = new TaskListDbContext())
            {

                taskDbContext.TaskLists.Add(tasksList);
                taskDbContext.SaveChanges();
                return tasksList;
                
            }
        }

        public void delete(TasksList tasksList)
        {
            using (var taskDbContext = new TaskListDbContext())
            {

                var deletedTasks=taskDbContext.TaskLists.Find(tasksList.Id);
                taskDbContext.TaskLists.Remove(deletedTasks);
                taskDbContext.SaveChanges();

            }
        }

        public List<TasksList> getTask(int userId)
        {
            using (var taskDbContext = new TaskListDbContext())
            {
                return taskDbContext.TaskLists.Where(t => t.UserId == userId).ToList();
            }
        }

        public TasksList getTaskbyId( int taskId)
        {
            using (var taskDbContext = new TaskListDbContext())
            {
                return taskDbContext.TaskLists.Where(t => t.Id == taskId).FirstOrDefault();
            };
        }
      
        public void updateTask(TasksList tasksList)
        {
            using (var taskDbContext = new TaskListDbContext())
            {

                var updatedTasks = taskDbContext.TaskLists.Find(tasksList.Id);
                taskDbContext.TaskLists.Update(updatedTasks);
                taskDbContext.SaveChanges();

            }
        }
    }
}
