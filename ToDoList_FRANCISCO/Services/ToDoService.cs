using System.Collections.Generic;
using ToDoList_FRANCISCO.Models;
using ToDoList_FRANCISCO.Repositories;

namespace ToDoList_FRANCISCO.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _repository;

        public ToDoService(IToDoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _repository.GetAll();
        }

        public ToDoItem GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(ToDoItem item)
        {
            _repository.Add(item);
        }

        public void Update(ToDoItem item)
        {
            _repository.Update(item);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
