namespace MVCLibrary_Team.Data
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        IEnumerable<T> GetAll();
    }
}
