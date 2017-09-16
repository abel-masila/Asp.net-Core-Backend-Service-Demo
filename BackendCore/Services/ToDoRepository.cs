﻿using BackendCore.Interfaces;
using BackendCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCore.Services
{
    public class ToDoRepository: IToDoRepository
    {
        private List<ToDoItem> _toDoList;
        public ToDoRepository()
        {
            InitializeData();
        }
        //Get all Items
        public IEnumerable<ToDoItem> AllItems
        {
            get { return _toDoList; }
        }
        //Delete/id/3
        public void Delete(string id)
        {
            _toDoList.Remove(this.Find(id));
        }
        //DoesItemExist/id/3
        public bool DoesItemExist(string id)
        {
            return _toDoList.Any(item=>item.ID==id);
        }
        //Find/id/3
        public ToDoItem Find(string id)
        {
            return _toDoList.FirstOrDefault(item=>item.ID==id);
        }
        //Insert Items
        public void Insert(ToDoItem item)
        {
             _toDoList.Add(item);
        }
        //Update/id/3
        public void Update(ToDoItem item)
        {
            var todoItem = this.Find(item.ID);
            var index = _toDoList.IndexOf(todoItem);
            _toDoList.RemoveAt(index);
            _toDoList.Insert(index,item);
        }
        //Init data for test
        private void InitializeData()
        {
            _toDoList = new List<ToDoItem>();
            var todoItem1 = new ToDoItem
            {
                ID = "6bb8a868-dba1-4f1a-93b7-24ebce87e243",
                Name = "Learn app development",
                Notes = "Attend Xamarin University",
                Done = true
            };
            var todoItem2 = new ToDoItem
            {
                ID = "b94afb54-a1cb-4313-8af3-b7511551b33b",
                Name = "Develop apps",
                Notes = "Use Xamarin Studio/Visual Studio",
                Done = false
            };
            var todoItem3 = new ToDoItem
            {
                ID = "ecfa6f80-3671-4911-aabe-63cc442c1ecf",
                Name = "Publish apps",
                Notes = "All app stores",
                Done = false
            };
            _toDoList.Add(todoItem1);
            _toDoList.Add(todoItem2);
            _toDoList.Add(todoItem3);
        }
    }
}
