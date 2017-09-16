using BackendCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCore.Interfaces
{
   public interface IToDoRepository
    {
        bool DoesItemExist(string id);
        IEnumerable<ToDoItem> AllItems { get; }
        ToDoItem Find(string id);
        void Insert(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(string id);
    }
}
