using System.Collections.Generic;

namespace TodoApi.Business
{
  public static class TodoStore
  {

    public static List<string> Todos { get; set; }
    static TodoStore()
    {
      Todos = new List<string>();
    }

  }


}