using Microsoft.EntityFrameworkCore;
using System;
using ToDoDataAccess.Models;

namespace ToDoDataAccess
{
    public class ToDoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4L1MDSE\SQLEXPRESS;Initial Catalog=ToDoAppLinq;Integrated Security=True");
        }
    }
}
