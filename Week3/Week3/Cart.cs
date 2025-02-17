using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoppingSystem
{
    public class Cart
    {
        public List<Product> Items = new List<Product>();
        public Stack<CartAction> ActionHistory = new Stack<CartAction>();
        public float TotalPrice {  get; set; }

        public void AddItem()
        {
            Console.Write("Enter the ID of Item:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the Name of Item:");
            string name = Console.ReadLine();
            Console.Write("Enter the Price of Item:");
            float price = float.Parse(Console.ReadLine());
            TotalPrice += price;

            Product item = new Product(id, name, price);
            Items.Add(item);
            CartAction action = new CartAction("ADD", item);
            ActionHistory.Push(action);
            Console.WriteLine("Item added successfully...");
            Console.ReadKey();
        }
        public void ViewTotalPrice()
        {
            Console.WriteLine($"Total Price : {ViewTotalPrice}");
            Console.ReadKey();
        }

        public void UndoLastAction()
        {
            if (ActionHistory.Count > 0)
            {
                var lastAction = ActionHistory.Pop();
                if (lastAction.Action == "ADD")
                {
                    Items.Remove(lastAction.Item);
                    Console.WriteLine($"Undo: Removed {lastAction.Item.Name} from cart.");
                    Console.ReadKey();
                }
                else if (lastAction.Action == "REMOVE")
                {
                    Items.Add(lastAction.Item);
                    Console.WriteLine($"Undo: Added {lastAction.Item.Name} back to cart.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("No actions to undo.");
                Console.ReadKey();
            }
        }

        public void Checkout()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Your cart is empty. Nothing to checkout.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Order Summary:");
                ViewCart();
                ViewTotalPrice();
                Items.Clear();
                ActionHistory.Clear();
                Console.ReadKey();
            }
        }

        public void RemoveItem()
        {
            ViewCart();
            Console.Write("Enter the ID of Item you need ot remove it:");
            int id = int.Parse( Console.ReadLine() );

            var item = Items.Find(i => i.ID == id);
            if (item != null)
            {
                TotalPrice -= item.Price;
                Items.Remove(item);
                ActionHistory.Push(new CartAction("REMOVE", item));
                Console.WriteLine("removing Item successfully.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"the Item not found in cart.");
                Console.ReadKey();
            }
        }

        public void ViewCart()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("No Items in Cart");
            }
            else
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"The Item {i + 1}\n");
                    Console.WriteLine(Items[i]);
                }
            }
            Console.ReadKey();
        }

        

    }
}
