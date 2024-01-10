using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Entities;

namespace to_do_list.DataAccess.Abstract
{
    public interface ITaskRepository
    {
        void delete(TasksList tasksList);
        TasksList create(TasksList tasksList);
        List<TasksList> getTask(int userId);
        TasksList getTaskbyId(int taskId);
        void updateTask(TasksList tasksList);

    }
}
