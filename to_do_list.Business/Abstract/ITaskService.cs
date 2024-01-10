using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Entities;

namespace to_do_list.Business.Abstract
{
   public interface ITaskService
    {
        void delete(TasksList tasksList);
        void updateTask(TasksList tasksList);
        TasksList create(TasksList tasksList);
        List<TasksList> getTasks(int userId);
        TasksList getTaskbyId(int taskId);
    }
}
