namespace Windowform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            buttonAddToCart = new Button();
            buttonRemoveFromCart = new Button();
            dataGridViewCart = new DataGridView();
            labelTotalQuantity = new Label();
            labelTotalPrice = new Label();
            buttonCheckout = new Button();
            this.dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(35, 12);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(556, 514);
            dataGridViewProducts.TabIndex = 0;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(719, 221);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(151, 29);
            buttonAddToCart.TabIndex = 1;
            buttonAddToCart.Text = "Thêm vào giỏ hàng";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // buttonRemoveFromCart
            // 
            buttonRemoveFromCart.Location = new Point(937, 221);
            buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            buttonRemoveFromCart.Size = new Size(184, 29);
            buttonRemoveFromCart.TabIndex = 2;
            buttonRemoveFromCart.Text = "Xóa khỏi giỏ hàng";
            buttonRemoveFromCart.UseVisualStyleBackColor = true;
            buttonRemoveFromCart.Click += buttonRemoveFromCart_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(687, 36);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(436, 167);
            dataGridViewCart.TabIndex = 3;
            dataGridViewCart.CellContentClick += dataGridViewCart_CellContentClick;
            // 
            // labelTotalQuantity
            // 
            labelTotalQuantity.AutoSize = true;
            labelTotalQuantity.Location = new Point(719, 277);
            labelTotalQuantity.Name = "labelTotalQuantity";
            labelTotalQuantity.Size = new Size(124, 20);
            labelTotalQuantity.TabIndex = 4;
            labelTotalQuantity.Text = "Tổng số lượng sp";
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(719, 311);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(105, 20);
            labelTotalPrice.TabIndex = 5;
            labelTotalPrice.Text = "Tổng giá trị sp";
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(937, 374);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(139, 35);
            buttonCheckout.TabIndex = 6;
            buttonCheckout.Text = "Thanh toán";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 614);
            Controls.Add(buttonCheckout);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelTotalQuantity);
            Controls.Add(dataGridViewCart);
            Controls.Add(buttonRemoveFromCart);
            Controls.Add(buttonAddToCart);
            Controls.Add(dataGridViewProducts);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts; private System.Windows.Forms.Button buttonAddToCart; private System.Windows.Forms.Button buttonRemoveFromCart; private System.Windows.Forms.DataGridView dataGridViewCart; private System.Windows.Forms.Label labelTotalQuantity; private System.Windows.Forms.Label labelTotalPrice; private System.Windows.Forms.Button buttonCheckout;
    }
}
