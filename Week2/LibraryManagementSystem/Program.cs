using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
/*
 * Abdelrahman Emad
 * 6/2/2025
 * CIS_MU
 */
namespace LibraryManagementSystem
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            
            Library lib = new Library();
            bool looping = true;
            while (looping)
            {
                label1:
                Console.Clear();
                Console.WriteLine("Library Management System");
                Console.WriteLine("choise ");
                Console.WriteLine("1. for User");
                Console.WriteLine("2. for Librarian");
                Console.WriteLine("3. for Exist");
                Console.WriteLine("--------------------\n");
                char choice = Console.ReadLine()[0];
                Console.Clear();
                if(choice == '1')
                {
                    label2:
                    Console.Clear();
                    Console.WriteLine("choise ");
                    Console.WriteLine("1. Register");
                    Console.WriteLine("2. Shearch ");
                    Console.WriteLine("3. Borrow Book");
                    Console.WriteLine("4. Display Books");
                    Console.WriteLine("5. Previous menu");
                    Console.WriteLine("6. Exist");
                    Console.WriteLine("--------------------\n");
                    char c1 = Console.ReadLine()[0];
         
                    switch (c1)
                    {
                        case '1':
                            {
                                lib.UserRegesiter();
                                Console.WriteLine("successfully regesiter");
                                Console.ReadKey();
                                goto label2;
                            }
                        case '2':
                            {
                                Console.WriteLine("Enter the title of book");
                                string title = Console.ReadLine();
                                bool flage = lib.SearchBookByTitle(title);
                                if (flage)
                                {
                                    Console.WriteLine("the book exsist in library");
                                }
                                else
                                {
                                    Console.WriteLine("the book does not exsist in library");
                                }
                                Console.ReadKey();
                                goto label2;
                            }
                        case '3':
                            {
                                lib.Borrow();
                                Console.ReadKey();
                                goto label2;
                            }
                        case '4':
                            {
                                lib.DisplayBooks();
                                Console.ReadKey();
                                break;
                            }
                        case '5':
                            {
                                Console.Clear();
                                goto label1;
                            }
                        case '6':
                            {
                                looping = false;
                                break;
                            }
                    }

                }
                else if(choice == '2')
                {
                label3:
                    Console.Clear();
                    Console.WriteLine("1.  Register");
                    Console.WriteLine("2. Menu library");
                    Console.WriteLine("3. Previous menu");
                    Console.WriteLine("4. Exist");
                    Console.WriteLine("--------------------\n");
                    char c2 = Console.ReadLine()[0];
                    
                    switch(c2)
                    {
                        case '1':
                            {
                                lib.LibrarianRegesiter();
                                Console.WriteLine("successfully regesiter");
                                Console.ReadKey();
                                goto label3;
                            }
                        case '2':
                            {
                                label4:
                                Console.Clear() ;   
                                Console.WriteLine("1. Add Book");
                                Console.WriteLine("2. Remove Book");
                                Console.WriteLine("3. Display Books");
                                Console.WriteLine("4. Previous menu");
                                Console.WriteLine("--------------------\n");
                                char c3 = Console.ReadLine()[0];
                         
                                switch(c3)
                                {
                                    case '1':
                                        { 
                                            lib.AddBook();
                                            Console.WriteLine("the book add successfly");
                                            Console.ReadKey();
                                            goto label4;
                                            
                                        }
                                    case '2':
                                        {
                                            lib.RemoveBook();
                                            Console.WriteLine("the book remove successfly");
                                            Console.ReadKey();
                                            goto label4;
                                        }
                                    case '3':
                                        {
                                            lib.DisplayBooks();
                                            Console.ReadKey();
                                            break;
                                        }
                                    case '4':
                                        {
                                            Console.Clear();
                                            goto label3;
                                            break;
                                        }
                                }


                                break;
                            }
                        case '3':
                            {
                                Console.Clear ();
                                goto label1;
                                break;
                            }
                        case '4':
                            {
                                looping =false;
                                break;
                            }
                    }
                    
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you ..");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! plz try again");
                    Console.ReadKey();
                    Console.Clear();
                }

       
                
            }
        }
        
    }
}
