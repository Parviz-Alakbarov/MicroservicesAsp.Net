﻿namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (ShoppingCartItem item in Items)
                {
                    total += item.Price * item.Quantity;
                }
                return total;
            }
        }

        public ShoppingCart()
        {

        }
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }
    }
}
