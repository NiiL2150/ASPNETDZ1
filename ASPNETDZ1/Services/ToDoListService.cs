using Microsoft.Extensions.DependencyInjection;

namespace ASPNETDZ1.Services
{
    public static class ToDoListService
    {
        public static void AddToDoListService(this IServiceCollection service)
        {
            service.AddSingleton<IToDoList, ToDoList>();
        }
    }
}
