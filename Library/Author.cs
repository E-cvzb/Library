using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

   public class Book
    {
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
    }
}