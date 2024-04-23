using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.WebFormsUI
{
    public partial class OrderWindow : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;
        public OrderWindow()
        {
            InitializeComponent();
            
            _productService = InstanceFactory.GetInstance<IProductService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();

            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = _productService.GetAll();
            foreach(Product product in products)
            {
                RenderProduct(product.Name, product.ProductStock);
            }   
        }

        private void AddToDgv(string productName, int productAmount, decimal productPrice)
        {
            List<Product> products = _productService.GetAll();
            DataGridViewRow row = (DataGridViewRow)this.dgvProductList.Rows[0].Clone();
            row.Cells["Ürün"].Value = productName;
            row.Cells["Adet"].Value = (int)row.Cells["Adet"].Value + productAmount;
            decimal productAmountDecimal = Convert.ToDecimal(productAmount);
            row.Cells["Fiyat"].Value = (int)row.Cells["Fiyat"].Value + (productAmountDecimal * productPrice);
            dgvProductList.Rows.Add(row);
        }

        public void RenderProduct(string pName = " ", int stockAmount = 0) // Load products into screen
        {
            System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
            // 
            // panel1
            //  
            //panel1.Location = new System.Drawing.Point(3, 3);
            //panel1.Name = "panel1";
            //panel1.Size = new System.Drawing.Size(135, 53);
            //panel1.TabIndex = 0;
            ////// 
            ////// label1
            ////// 
            ////label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            ////label1.AutoSize = true;
            ////label1.Location = new System.Drawing.Point(27, 21);
            ////label1.Name = "label1";
            ////label1.Size = new System.Drawing.Size(70, 13);
            ////label1.TabIndex = 0;
            ////label1.Text = productName;

            //stockInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            //stockInfo.AutoSize = true;
            //stockInfo.Location = new System.Drawing.Point(panel1.Width/2, panel1.Height/2);
            //stockInfo.Name = "stockInfo";
            //stockInfo.Size = new System.Drawing.Size(70, 13);
            //stockInfo.TabIndex = 0;
            //stockInfo.Text = "5 kaldı";

            //// 
            //// panel1
            //// 
            //panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            //panel1.Controls.Add(this.productName);
            //panel1.Location = new System.Drawing.Point(3, 3);
            //panel1.Name = "panel1";
            //panel1.Size = new System.Drawing.Size(200, 100);
            //panel1.TabIndex = 0;
            //// 
            //// productName
            //// 
            //productName.AutoSize = true;
            //productName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //productName.Location = new System.Drawing.Point(64, 48);
            //productName.Name = "productName";
            //productName.Size = new System.Drawing.Size(72, 30);
            //productName.TabIndex = 0;
            //productName.Text = pName;


            //panel1.PerformLayout();

            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 100);
            panel1.TabIndex = 0;

            // 
            // button3
            // 

            button3.BackColor = System.Drawing.Color.LimeGreen;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(-3, -3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(202, 102);
            button3.TabIndex = 0;
            button3.Text = pName + "\nStok miktarı:" + stockAmount;
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(AddOrder);

            // 
            // panel1
            // 

            panel1.Controls.Add(button3);

            flowLayoutPanel1.Controls.Add(panel1);
        }

        private void button2_Click(object sender, EventArgs e) // Send Order Button
        {
            // Read entire DGV
            // Turn dgv rows into Product Entity
            // Add them to database as reading continue...

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                string dgvPName = (string)row.Cells["Ürün"].Value;
                int dgvPAmount = Convert.ToInt32(row.Cells["Adet"].Value);
                decimal dgvPPrice = Convert.ToDecimal(row.Cells["Fiyat"].Value);

                Order order = new Order();
                order.OrderName = dgvPName;
                order.OrderDate = DateTime.Now;

                _orderService.Add(order);
            }
        }
        private void AddOrder(object sender, EventArgs e)
        {
            //string dgvPName = (string)dgvProductList.Rows[0].Cells["Ürün"].Value;
            //int dgvPAmount = Convert.ToInt32(dgvProductList.Rows[0].Cells["Adet"].Value);
            //decimal dgvPPrice = Convert.ToDecimal(dgvProductList.Rows[0].Cells["Fiyat"].Value);


            AddToDgv(dgvPName, dgvPAmount, dgvPPrice);
        }
    }
}
