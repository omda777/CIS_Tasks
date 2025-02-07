using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowBook : Book
    {
        public User User { get; set; }
        
        public BorrowBook(User user,Book book):base (book.Title ,book.Author)
        {
            User = user;
           
        }

    }
}
