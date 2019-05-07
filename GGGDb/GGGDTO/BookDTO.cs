using GGGDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGGDTO
{
    public class BookDTO
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public decimal BookPrice { get; set; }

        public BookDTO(Book b)
        {
            this.BookId = b.BookId;
            this.BookName = b.BookName;
            this.BookAuthor = b.BookAuthor;
            this.BookPrice = b.BookPrice;
        }
    }
}
