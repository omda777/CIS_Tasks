using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoppingSystem
{
    public class MenuSystem
    {
       public  Cart cart = new Cart();
        public  void Menu()
        {
            bool looping = true;

            while (looping)
            {
                Console.Clear();
                Console.WriteLine("Shopping System Menu:");
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. View Cart");
                Console.WriteLine("3. Remove Item from Cart");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Undo Last Action");
                Console.WriteLine("6. View Total Price");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:cart.AddItem(); break;
                    case 2:cart.ViewCart(); break;
                    case 3:cart.RemoveItem(); break;
                    case 4:cart.Checkout(); break;
                    case 5:cart.UndoLastAction(); break;
                    case 6:cart.ViewTotalPrice(); break;
                    case 7: looping = false; break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
            }

        }

        
    }
}
