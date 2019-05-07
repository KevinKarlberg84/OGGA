using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGGDb
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }

        public Book(Guid bookId, string bookName, string bookAuthor, decimal bookPrice)
        {
            this.BookId = bookId;
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.BookPrice = bookPrice;
        }
    }
}
