using System.Collections.Generic;
using System.Linq;
using ToDoList_FRANCISCO.Models;

namespace ToDoList_FRANCISCO.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly List<ToDoItem> _items = new List<ToDoItem>();
        private int _nextId = 1;

        public IEnumerable<ToDoItem> GetAll()
        {
            return _items;
        }

        public ToDoItem GetById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public void Add(ToDoItem item)
        {
            item.Id = _nextId++;
            _items.Add(item);
        }

        public void Update(ToDoItem item)
        {
            var existingItem = _items.FirstOrDefault(x => x.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.Description = item.Description;
                existingItem.IsComplete = item.IsComplete;
            }
        }

        public void Delete(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
    }
}
