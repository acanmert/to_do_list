using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using to_do_list.Entities;

namespace to_do_list.DataAccess
{
    public class UserDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AHMETCANPC;Database=toDoList;Integrated Security=True;");
        }
        public DbSet<User> Users{ get; set; }
    }
}
