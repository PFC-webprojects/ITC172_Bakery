using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bakery02.Models
{
    public class Cart
    {
        public List<CartItem> CartItems;
        public void Add(CartItem cartItem)
        {
            CartItems.Add(cartItem);
        }
        public Person Employee { get; set; }
        public Person Customer { get; set; }
        public decimal Total
        {
            get
            {
                decimal decTotal = 0;
                foreach(CartItem cartItem in CartItems)
                {
                    decTotal  +=  cartItem.Quantity * cartItem.Product.ProductPrice;
                }
                return decTotal;
            }
        }
        
    }
}