using System.Collections.Generic;

namespace Windowform
{
    public class ShoppingCart
    {
        public List<Product> Items { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            var existingProduct = Items.Find(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                Items.Add(product);
            }
        }

        public void RemoveProduct(string productName)
        {
            var product = Items.Find(p => p.Name == productName);
            if (product != null)
            {
                Items.Remove(product);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in Items)
            {
                totalPrice += product.Price * product.Quantity;
            }
            return totalPrice;
        }

        public int GetTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (var product in Items)
            {
                totalQuantity += product.Quantity;
            }
            return totalQuantity;
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }
}
