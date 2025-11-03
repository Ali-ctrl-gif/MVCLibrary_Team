using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IBaseDataModel baseDataModel;

        public CategoryRepository(IBaseDataModel baseDataModel)
        {
            this.baseDataModel = baseDataModel;
        }
        public void Add(Category item) => baseDataModel.Categories.Add(item);
        public void Remove(Category item) => baseDataModel.Categories.Remove(item);
        public void Delete(Category item ) => item.IsDeleted = true;
        public void Update(Category item, int id) { }
        public IEnumerable<Category> GetAll() => baseDataModel.Categories;
        public Category? GetById(int id)
        {
            return baseDataModel.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
