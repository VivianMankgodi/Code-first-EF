using System;

public interface IRepositoryAll<T>
{
    void Insertmethod(T entity);
    void Delete(T entity);
    IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetAll();
    T GetById(int id);
}
