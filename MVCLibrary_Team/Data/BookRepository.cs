using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace MVCLibrary_Team.Data
{
    public class BookRepository : IRepository<Book>
    {
        private readonly IBaseDataModel baseDataModel;

        public BookRepository(IBaseDataModel baseDataModel)
        {
            this.baseDataModel = baseDataModel;
        }
        public void Add(Book item) => baseDataModel.Books.Add(item);
        public void Remove(Book item) => baseDataModel.Books.Remove(item);
        public void Delete(Book item) => item.IsDeleted = true;
        public void Update(Book item, int id)
        {
            var book1 = GetById(id);
            book1.Title = item.Title;
            book1.Author = item.Author;
            book1.Year = item.Year;
            //book1.BookGenre = book.BookGenre;
        }
        public IEnumerable<Book> GetAll() => baseDataModel.Books;
        public Book? GetById(int id)
        {
            return baseDataModel.Books.FirstOrDefault(x => x.Id == id);
        }
    }
}
