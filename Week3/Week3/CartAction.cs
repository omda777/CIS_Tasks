using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoppingSystem
{
    public class CartAction
    {
        public string Action { get; }
        public Product Item { get; }

        public CartAction(string action, Product item)
        {
            Action = action;
            Item = item;
        }
    }
}
