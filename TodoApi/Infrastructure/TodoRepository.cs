// data base access
using TodoApi.Models;

namespace TodoApi.Infrastructure
{
	public class TodoRepository
	{
		private readonly TodoContext _context;


		public TodoRepository(TodoContext todoContext)
		{
			_context = todoContext;
		}

		public async Task<TodoItem?> GetTodoItem(long id)
		{
			TodoItem? todoItem = await _context.TodoItems.FindAsync(id);
            if(todoItem == null){
                return null;
            }
			return todoItem;

		}
	}
}