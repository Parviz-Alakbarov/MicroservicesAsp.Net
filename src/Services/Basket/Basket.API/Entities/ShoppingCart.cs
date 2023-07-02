namespace Basket.API.Entities
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
                if (Items != null)
                {
                    foreach (var item in Items)
                    {
                        total += item.Price * item.Quantity;
                    }
                }

                return total;
            }
        }

        public ShoppingCart()
        {
        }
        public ShoppingCart(string userName) : this()
        {
            UserName = userName;
            Items = new List<ShoppingCartItem>();
        }
    }
}
