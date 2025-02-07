using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        private string title;
        private string author;
        private int publishedYear;

        // properties
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public int PublishedYear { get { return publishedYear; } set { publishedYear = value; } }

        // constructor
        public Book(string _title ,string _author ,int _publishedyear)
        {
            Title = _title;
            Author = _author;
            PublishedYear = _publishedyear;
        }
        public Book(string _title, string _author) 
        { 
            Title= _title;
            Author = _author;
            publishedYear = 0;
        }
        public override string ToString()
        {
            if(PublishedYear == 0)
            return $"Title: {Title}\nAuthor: {Author}";

            return $"Title: {Title}\nAuthor: {Author}\nPublishedYear: {PublishedYear}";
        }
    }
}
