using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_tracker.Models
{
    public class TaskItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCompete { get; set; }
    }
}
