using NTier.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTier.Business.Abstract
{
    public interface ITaskService
    {
        List<Task> GetTaskList();
        void Add(Task task);
        void Update(Task task);
        void Delete(Task task);
        Task GetTaskById(int id);
        List<Task> GetTaskListByIsItCompleted(bool isItCompleted);
        List<Task> GetTaskListByNameOrDescription(string name,string descriptin);
        List<Task> GetTaskListByMonthAndYear(int month,int year);
        List<Task> GetTaskListByYear(int year);
        List<Task> GetTaskListBySubTaskId(int subid);

    }
}
