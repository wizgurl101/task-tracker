using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace task_tracker.Models
{
    // the : colon depict class inheritance (same as extends in Java)
    // a base class is specified by appending a colon and the name of the base class
    // following the derived class name
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
