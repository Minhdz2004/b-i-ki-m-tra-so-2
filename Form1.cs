using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Windowform
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>(); // Khởi tạo tại đây
        private ShoppingCart cart = new ShoppingCart(); // Khởi tạo tại đây

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            UpdateCartDisplay();
        }

        private void LoadProducts()
        {
            products = new List<Product>
            {
                new Product { Name = "Product 1", Price = 100, Quantity = 10, Image = "path/to/image1.jpg" },
                new Product { Name = "Product 2", Price = 150, Quantity = 15, Image = "path/to/image2.jpg" },
                new Product { Name = "Product 3", Price = 200, Quantity = 20, Image = "path/to/image3.jpg" },
            };

            dataGridViewProducts.DataSource = products;
        }

        private void UpdateCartDisplay()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cart.Items;
            dataGridViewCart.Refresh(); // Cập nhật DataGridView
            labelTotalQuantity.Text = "Tổng số lượng: " + cart.GetTotalQuantity();
            labelTotalPrice.Text = "Tổng giá trị: " + cart.GetTotalPrice() + " VND";
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                var selectedProduct = dataGridViewProducts.CurrentRow.DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    cart.AddProduct(new Product
                    {
                        Name = selectedProduct.Name,
                        Price = selectedProduct.Price,
                        Quantity = 1,
                        Image = selectedProduct.Image
                    });
                    UpdateCartDisplay();
                }
            }
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.CurrentRow != null) 
            { 
                var selectedProduct = dataGridViewCart.CurrentRow.DataBoundItem as Product; 
                if (selectedProduct != null) 
                { 
                    cart.RemoveProduct(selectedProduct.Image);
                    UpdateCartDisplay(); 
                } 
            }
            else { MessageBox.Show("Không có sản phẩm nào được chọn để xóa."); }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn hàng đã được thanh toán thành công!");
            cart.ClearCart();
            UpdateCartDisplay();
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu cần thiết, xử lý sự kiện khi người dùng nhấp vào cell trong DataGridViewCart
        }

        private void buttonRemoveFromCart_Click_1(object sender, EventArgs e)
        {

        }
    }
}
