namespace MVCLibrary_Team.Data
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item , int id);
        void Delete(T item);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
