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
            ProductListRefresh();
            MoneyLb.Text = Shop.Money.ToString();
            ProductInformationFill();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductListBx.SelectedItem != null)
            {
                try
                {
                    var Product = (Product)ProductListBx.SelectedItem;
                    Shop.ProductBuy(Product, int.Parse(BuyProductCountMskTxtBox.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProductInformationFill()
        {
            if (ProductListBx.SelectedItem != null)
            {
                var Product = (Product)ProductListBx.SelectedItem;
                ProductNameTxt.Text = Product.Name;
                ProductPriceTxt.Text = Product.Price.ToString();
                ProductCategoryTxt.Text = Product.Category.ToString();
                ProductCountTxt.Text = Shop.ProductAndProductCount[Product].ToString();
            }
        }

        private void ProductListBx_Click(object sender, EventArgs e)
        {
            ProductInformationFill();
        }

        private void SellProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductListBx.SelectedItem != null)
            {
                try
                {
                    var Product = (Product)ProductListBx.SelectedItem;
                    Shop.ProductSell(Product, int.Parse(SellProductCountMskTxtBox.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProductRemoveBt_Click(object sender, EventArgs e)
        {
            var Product = (Product)ProductListBx.SelectedItem;
            Shop.ProductAndProductCount.Remove(Product);
        }

        private void ProductAddBt_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        public void ProductListRefresh()
        {
            ProductListBx.DataSource = Shop.ProductAndProductCount.Keys.ToList();
            ProductListBx.DisplayMember = "Name";
            ProductListBx.ValueMember = "Name";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileWorker.SaveMoney(Shop.Money);
            FileWorker.SaveInformation(Shop.ProductAndProductCount);
        }

        private void MoneyAddBtn_Click(object sender, EventArgs e)
        {
            Shop.Money += int.Parse(MoneyMskTxtBox.Text);
            MoneyLb.Text = Shop.Money.ToString();
            FileWorker.SaveMoney(Shop.Money);
        }
    }
}
