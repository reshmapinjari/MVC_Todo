using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Todo.Models;

namespace MVC_Todo.Services
{
    public interface ITodoItemService
    {
        
            Task<TodoItem[]> GetIncompleteItemsAsync();
        
    }
}
