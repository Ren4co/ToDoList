namespace ToDoList.DAL.Interfaces;

public interface IBaseRepository<T>
{
    Task Create(T entity);

    IQueryable<T> GetAll();

    Task Delete(T entity);

    Task<T> Update(T entity);
    //12312312

    //eqweqwe
    //fsdfsdf
}
