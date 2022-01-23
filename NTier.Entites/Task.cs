using System;
using System.ComponentModel.DataAnnotations;

namespace NTier.Entites
{
    public class Task
    {
        public int Id { get; set; }
        public int SubTaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Date { get; set; }
        public bool IsItCompleted { get; set; }
    }
}
