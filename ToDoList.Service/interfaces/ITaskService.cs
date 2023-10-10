using ToDoList.Domain.Entity;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModels.Task;

namespace ToDoList.Service.interfaces;

public interface ITaskService
{
    Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model);
}