using ELibraryStore.Models;

namespace ELibraryStore.Data.InitialData
{
    public class BookData
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Name = "Data and Computer Communications",
                    Description = "With a focus on the most current technology, it explores in detail all the critical technical areas in data communications, " +
                    "wide-area networking, local area networking, and protocol design",
                    Price = 74.99,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/512DZv6SkyL._SX381_BO1,204,203,200_.jpg",
                    DateAdded = DateTime.Now.AddDays(-10),
                    BookStoreId = 1,
                    PublisherId = 2,
                    BookUrl = "https://memberfiles.freewebs.com/00/88/103568800/documents/Data.And.Computer.Communications.8e.WilliamStallings.pdf",
                    BookCategory = Enum.BookCategory.Computing,
                    BookEdition = "10th Edition"
                },

                new Book()
                {
                    Name = "PRINCIPLES OF ELECTROMAGNETICS",
                    Description = "Principles of Electromagnetics is designed to serve as a textbook for UG student in EEE/ECE taking Introductory Course in Electromagnetics",
                    Price = 64.99,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/517cqSujX+L._SX380_BO1,204,203,200_.jpg",
                    DateAdded = DateTime.Now.AddDays(-10),
                    BookStoreId = 1,
                    PublisherId = 1,
                    BookUrl = "https://memberfiles.freewebs.com/00/88/103568800/documents/Data.And.Computer.Communications.8e.WilliamStallings.pdf",
                    BookCategory = Enum.BookCategory.Engineering,
                    BookEdition = "6th Edition"
                },

                 new Book()
                {
                    Name = "Start From Zero",
                    Description = "Start From Zero: Build Your Own Business & Experience True Freedom by Dane Maxwell Learn How To Start A Business From Nothing.",
                    Price = 17.99,
                    ImageUrl = "https://www-konga-com-res.cloudinary.com/w_auto,f_auto,fl_lossy,dpr_auto,q_auto/media/catalog/product/F/K/84279_1638860206.jpg",
                    DateAdded = DateTime.Now.AddDays(-10),
                    BookStoreId = 4,
                    PublisherId = 3,
                    BookUrl = "http://morfene.com/021.pdf",
                    BookCategory = Enum.BookCategory.Finance,
                    BookEdition = ""
                },

                 new Book()
                {
                    Name = "Things Fall Apart",
                    Description = "It is a classic narrative about Africa's cataclysmic encounter with Europe as it establishes a colonial presence on the continent.",
                    Price = 10.99,
                    ImageUrl = "https://img.thriftbooks.com/api/images/m/a2fb6a422f282994666af9507491b5a08475b860.jpg",
                    DateAdded = DateTime.Now.AddDays(-10),
                    BookStoreId = 3,
                    PublisherId = 3,
                    BookUrl = "",
                    BookCategory = Enum.BookCategory.History,
                    BookEdition = ""
                },

            };

            return books;
        }
    }
}
