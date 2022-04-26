using System.Collections.Generic;
using System.Linq;

namespace ASPNETDZ1.Services
{
    public class ToDoList : IToDoList
    {
        public ICollection<string> List { get; set; }
        public void Add(string value)
        {
            List.Add(value);
        }
        public void RemoveAt(int id)
        {
            if(id>=0 && id < List.Count)
            {
                List.Remove(List.ElementAt(id));
            }
        }
        public ToDoList()
        {
            List = new List<string>();
        }
    }
}
