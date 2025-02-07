using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class User
    {
        private static int CountCard ;
        private string name;
        private int librarycard;
        private int age;

        // properities
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int LibraryCard
        { 
            get { return librarycard; }
            set { librarycard = value; }
        }
        public int Age
        { 
            get { return age; } 
            set { age = value; } 
        }

        // constructor 
        public User(string _name ,int _age )
        {
            Name = _name;
            Age = _age;
            LibraryCard = CountCard++;
        }
         static User ()
         {
            CountCard = 10;
         }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nLibraryCard:{LibraryCard}";
        }
    }
}
