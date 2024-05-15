using System.Collections.Generic;
using ToDoList_FRANCISCO.Models;

namespace ToDoList_FRANCISCO.Services
{
    public interface IToDoService
    {
        IEnumerable<ToDoItem> GetAll();
        ToDoItem GetById(int id);
        void Add(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(int id);
    }
}
