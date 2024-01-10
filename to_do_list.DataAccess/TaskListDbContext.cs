using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_do_list.Entities;

namespace to_do_list.DataAccess
{
    public class TaskListDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AHMETCANPC;Database=toDoList;Integrated Security=True;");
        }
        public DbSet<TasksList> TaskLists { get; set; }
    }
}
