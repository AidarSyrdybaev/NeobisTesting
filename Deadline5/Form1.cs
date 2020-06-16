using Deadline5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadline5
{
    public partial class Form1 : Form
    {   
        public Shop Shop { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shop = new Shop();
            Shop.AddProduct(new Product ("Iphone", 216, Category.Technic));
            ProductsDataGridView.DataSource = Shop.ProductAndProductCount.Keys.ToList();
            ProductsDataGridView.Columns.Remove("Name");
            ProductsDataGridView.Columns.Remove("Price");
            ProductsDataGridView.Columns.Remove("Category");
            ProductsDataGridView.Columns[0].DataPropertyName = "Name";
            ProductsDataGridView.Columns[1].DataPropertyName = "Price";
            ProductsDataGridView.Columns[2].DataPropertyName = "Category";
            ProductCountMskTxtBox.Enabled = false;
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows != null && ProductsDataGridView.SelectedRows.Count == 1)
            {
                Shop.ProductBuy((Product)ProductsDataGridView.SelectedRows[0].Tag, int.Parse(BuyProductBtn.Text));
            }
        }

        private void ProductsDataGridView_Click(object sender, EventArgs e)
        {
            ProductCountMskTxtBox.Text = ProductsDataGridView.SelectedCells[0].Value.ToString();
        }

        private void Inizialization()
        { }
    }
}
