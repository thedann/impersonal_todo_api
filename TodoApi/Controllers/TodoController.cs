using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApi.Business;

namespace TodoApi.Controllers
{
  [Route("api/[controller]")]
  public class TodoController : Controller
  {
    public TodoController()
    {
    }


    // GET api/todo
    [HttpGet]
    public List<string> Get()
    {
      return TodoStore.Todos;
    }

    // POST api/todo
    [HttpPost]
    public void Post(string todo)
    {
      TodoStore.Todos.Add(todo);
      Console.WriteLine(todo);
      Console.WriteLine(JsonConvert.SerializeObject(TodoStore.Todos));
    }

    // DELETE api/todo/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      TodoStore.Todos.RemoveAt(id);
    }

  }
}