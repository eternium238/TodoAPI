using Microsoft.AspNetCore.Mvc;
using TodoAPI.Context;
using TodoAPI.Model;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly TodoDbContext _todoDbContext;

        public TodoController(ILogger<WeatherForecastController> logger, TodoDbContext todoDbContext)
        {
            _logger = logger;
            _todoDbContext = todoDbContext;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            var todos = _todoDbContext.Todo.ToList();
            return todos;            
        }
    }
}