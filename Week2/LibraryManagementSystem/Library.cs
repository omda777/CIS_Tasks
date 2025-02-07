using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        List<librarian> Librarians = new List<librarian>();
        List<BorrowBook> borrowBooks = new List<BorrowBook>();

        public void UserRegesiter()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            int age =int.Parse(Console.ReadLine());
            User user = new User(name, age);
            users.Add(user);
            Console.WriteLine("Your library card is {0}",user.LibraryCard);
        }
        public void LibrarianRegesiter()
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your ID:");
            int id =int.Parse(Console.ReadLine());  

            Librarians.Add(new librarian(name, id));
        }
        public void AddBook ()
        {
            Console.Write("Enter the title of book:");
            string title = Console.ReadLine();
            Console.Write("Enter the Autour of book:");
            string authour = Console.ReadLine();
            Console.Write("Enter the published year of book:");
            int _year =int.Parse(Console.ReadLine());
            books.Add(new Book(title, authour,_year));

        }
        public void RemoveBook()
        {
            Console.Write("Enter the title of book:");
            string title = Console.ReadLine();  
            books.RemoveAll(book => book.Title == title);
        }
        public void Borrow()
        {
            Console.Write("Enter the tilte of book :");
            string title = Console.ReadLine();
            Book foundBook = books.FirstOrDefault(b => b.Title == title);

            if (foundBook != null)
            {
                Console.Write("Enter the name of user :");
                string name =Console.ReadLine();    
                User userborrow = users.FirstOrDefault(b => b.Name == name);
                if (userborrow != null)
                {
                    borrowBooks.Add(new BorrowBook(userborrow, foundBook));
                    books.Remove(foundBook);
                }
                else
                {
                    Console.WriteLine("this user does not rgister ,plz rgister to borrow book");
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }


        }
        
        public bool SearchBookByTitle (string title)
        {
            
            foreach (Book book in books)
            {
                if (book.Title == title)
                    return true;
            }
            return false;
        }
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library");
                return;
            }

            Console.WriteLine("All books in library\n--------------------\n");
            foreach (var book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine("===========================");
            }

        }

        
    }
}
