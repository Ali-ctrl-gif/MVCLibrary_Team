using MVCLibrary_Team.Models;
namespace MVCLibrary_Team.Data
{
    public class SeedData
    {
        public static void InitializeUser(IBaseDataModel repository)
        {
            if (repository.Members.Any())
            {
                return;
            }
            repository.Members.Add(
                new Member
                {
                    FullName = "Ehsan Arefzadeh",
                    Email = "arefzaadeh@gmail.com",
                    JoinDate = DateTime.Now,
                    Username = "ehsan",
                    Password = "1234",
                    IsAdmin = true

                }
            );
            repository.Members.Add(
                new Member
                {
                    FullName = "Alireza Arefzadeh",
                    Email = "alireza@gmail.com",
                    JoinDate = DateTime.Now,
                    Username = "alireza",
                    Password = "1234",
                    IsAdmin = false
                }
            );
            repository.Members.Add(
                new Member
                {
                    FullName = "Pouyan Arefzadeh",
                    Email = "pouyan@gmail.com",
                    JoinDate = DateTime.Now,
                    Username = "pouyan",
                    Password = "1234",
                    IsAdmin = false
                }
            );
        }
        public static void InitializeBook(IBaseDataModel repository)
        {
            if (repository.Books.Any())
            {
                return;
            }
            repository.Books.Add(
                new Book
                {
                    Title = "CSharp in a nutshell",
                    Author = "Oriely",
                    CategoryId = 1,
                    Year = "2023"
                }
            );
            repository.Books.Add(
                new Book
                {
                    Title = "Clean Code",
                    Author = "C Martin",
                    CategoryId = 1,
                    Year = "2000",
                    IsAvailable = false
                }
            );
            repository.Books.Add(
                new Book
                {
                    Title = "ASP.NET",
                    Author = "Microsoft",
                    CategoryId = 1,
                    Year = "2024"
                }
            );
            repository.Books.Add(
                new Book
                {
                    Title = "Toy story",
                    Author = "Disney - Pixar",
                    CategoryId = 1,
                    Year = "2024"
                }
            );
        }
        public static void InitializeBorrow(IBaseDataModel repository)
        {
            if (repository.Borrows.Any())
            {
                return;
            }
            repository.Borrows.Add(
                new Borrow
                {
                    BookId = 2,
                    UserId = 2,
                }
            );
        }
    }
}

