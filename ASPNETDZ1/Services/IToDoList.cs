using System.Collections.Generic;

namespace ASPNETDZ1.Services
{
    public interface IToDoList
    {
        public ICollection<string> List { get; set; }
        public void Add(string value);
        public void RemoveAt(int id);
    }
}
