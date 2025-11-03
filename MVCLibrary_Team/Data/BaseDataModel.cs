using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public class BaseDataModel : IBaseDataModel
    {
        public BaseDataModel()
        {
            Books = new List<Book>();
            Members = new List<Member>();
            Borrows = new List<Borrow>();
            Categories = new List<Category>();
        }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }
        public List<Borrow> Borrows { get; set; }
        public List<Category> Categories { get; set; }
    }
}
