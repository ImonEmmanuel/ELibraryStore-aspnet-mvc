using ELibraryStore.Models;

namespace ELibraryStore.Data.InitialData
{
    public class Book_AuthorData
    {
        public List<Book_Author> GetBook_Authors()
        {
            List<Book_Author> book_authors = new List<Book_Author>()
            {
                new Book_Author()
                {
                    AuthorId = 1,
                    BookId = 1
                },
                new Book_Author()
                {
                    AuthorId = 1,
                    BookId = 2
                },

                    new Book_Author()
                {
                    AuthorId = 1,
                    BookId = 3
                },
                    new Book_Author()
                {
                    AuthorId = 2,
                    BookId = 2
                },

                new Book_Author()
                {
                    AuthorId = 2,
                    BookId = 3
                },
                new Book_Author()
                {
                    AuthorId = 2,
                    BookId = 4
                },
                new Book_Author()
                {
                    AuthorId =3,
                    BookId = 3
                },


                new Book_Author()
                {
                    AuthorId = 3,
                    BookId = 4
                },
                new Book_Author()
                {
                    AuthorId = 3,
                    BookId = 1
                },
                new Book_Author()
                {
                    AuthorId = 4,
                    BookId = 4
                },


                new Book_Author()
                {
                    AuthorId = 5,
                    BookId = 4
                },
                new Book_Author()
                {
                    AuthorId = 5,
                    BookId = 2
                },
                new Book_Author()
                {
                    AuthorId = 4,
                    BookId = 2
                },
                new Book_Author()
                {
                    AuthorId = 5,
                    BookId = 1
                },


                new Book_Author()
                {
                    AuthorId = 5,
                    BookId = 3
                },
                new Book_Author()
                {
                    AuthorId = 4,
                    BookId = 3
                }
            }; 
            return book_authors;
        }
    }
}
