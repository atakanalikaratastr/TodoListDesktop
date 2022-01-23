using NTier.Business.Abstract;
using NTier.DataAccess.Abstract;
using NTier.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTier.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDAL _taskDAL;
        public TaskManager(ITaskDAL taskDAL)
        {
            _taskDAL = taskDAL;
        }
        public void Add(Task task)
        {
            _taskDAL.Add(task);
        }

        public void Delete(Task task)
        {

            _taskDAL.Delete(task);

        }

        public Task GetTaskById(int id)
        {
            return _taskDAL.Get(x => x.Id == id);
        }

        public List<Task> GetTaskList()
        {
            return _taskDAL.GetAll().Where(x => x.SubTaskID == 0).ToList();
        }

        public List<Task> GetTaskListByIsItCompleted(bool isItCompleted)
        {
            if (isItCompleted == true)
            {
                return _taskDAL.GetAll().Where(x => x.IsItCompleted == true & x.SubTaskID == 0).ToList();
            }
            else if (isItCompleted == false)
            {
                return _taskDAL.GetAll().Where(x => x.IsItCompleted == false & x.SubTaskID == 0).ToList();
            }
            else
            {
                return _taskDAL.GetAll();
            }
        }

        public List<Task> GetTaskListByMonthAndYear(int month, int year)
        {

            return _taskDAL.GetAll().Where(x => x.Date.Month == month & x.Date.Year == year & x.SubTaskID == 0).ToList();


        }

        public List<Task> GetTaskListByNameOrDescription(string name, string descriptin)
        {
            return _taskDAL.GetAll().Where(x => x.TaskName == name | x.TaskDescription == descriptin).ToList();
        }

        public List<Task> GetTaskListBySubTaskId(int id)
        {
            return _taskDAL.GetAll().Where(x => x.SubTaskID == id).ToList();
        }

        public List<Task> GetTaskListByYear(int year)
        {
            return _taskDAL.GetAll().Where(x => x.Date.Year == year & x.SubTaskID == 0).ToList(); 
        }

        public void Update(Task task)
        {
            _taskDAL.Update(task);
        }
    }
}
