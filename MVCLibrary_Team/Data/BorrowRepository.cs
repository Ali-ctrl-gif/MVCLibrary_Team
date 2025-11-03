
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public class BorrowRepository : IRepository<Borrow>
    {
        private readonly IBaseDataModel baseDataModel;

        public BorrowRepository(IBaseDataModel baseDataModel)
        {
            this.baseDataModel = baseDataModel;
        }
        public void Add(Borrow item) => baseDataModel.Borrows.Add(item);
        public void Remove(Borrow item) => baseDataModel.Borrows.Remove(item);
        public void Update(Borrow item , int id) { }
        public void Delete(Borrow item) { }
        public IEnumerable<Borrow> GetAll() => baseDataModel.Borrows;
        public Borrow? GetById(int id)
        {
            return baseDataModel.Borrows.FirstOrDefault(x => x.Id == id);
        }
    }
}
