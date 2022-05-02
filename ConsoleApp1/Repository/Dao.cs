using System.Collections.Generic;

namespace ConsoleApp1.Repository;

public interface Dao<T>
{
    public T get(int id);

    public List<T> getAll();

    public T getRandom();

    public void add(T t);

    public T update(T t);

    public T delete(int id);

    public T deleteAll();
}