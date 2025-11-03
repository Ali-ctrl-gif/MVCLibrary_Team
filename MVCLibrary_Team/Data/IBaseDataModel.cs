
using MVCLibrary_Team.Models;

namespace MVCLibrary_Team.Data
{
    public interface IBaseDataModel
    {
        List<Book> Books { get; set; }
        List<Member> Members { get; set; }
        List<Borrow> Borrows { get; set; }
        List<Category> Categories { get; set; }
    }
}
