using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public class BaseDataModel : IBaseDataModel
    {
        public BaseDataModel()
        {
            Books = new List<Book>();
            Users = new List<Member>();
            Borrows = new List<Borrow>();
        }
        public List<Book> Books { get; set; }
        public List<Member> Users { get; set; }
        public List<Borrow> Borrows { get; set; }
    }
}
