// buisness logic - what needs to be taken from the full databse object reciveed from repositoruy
using TodoApi.Models;
using TodoApi.Infrastructure;

namespace TodoApi.Services;

public class TodoService
{
    private readonly TodoRepository _todoRepository;
    public TodoService(TodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<TodoItemDTO?> GetTodoItem(long id)
    {
        TodoItem? item = await _todoRepository.GetTodoItem(id);
        if(item == null){
          return null;
        }
        var itemDto = ItemToDTO(item);
        return itemDto;


    }
    private static TodoItemDTO ItemToDTO(TodoItem todoItem) =>
        new TodoItemDTO
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };
}