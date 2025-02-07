using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class librarian
    {
        public string Name { get; set; }    
        public int ID { get; set; } 

        public librarian(string name ,int id) 
        {
            Name = name;
            ID = id;
        }
    }
}
