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
            CategoryCheckCmbBx.Items.Add(Category.Accessories);
            CategoryCheckCmbBx.Items.Add(Category.Food);
            CategoryCheckCmbBx.Items.Add(Category.Technic);
            CategoryCheckCmbBx.Items.Add(Category.None);
            CategoryCheckCmbBx.SelectedItem = Category.None;
            ProductInformationFill();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            if (ProductListBx.SelectedItem != null && !string.IsNullOrWhiteSpace(BuyProductCountMskTxtBox.Text))
            {
                try
                {
                    var Product = (Product)ProductListBx.SelectedItem;
                    Shop.ProductBuy(Product, int.Parse(BuyProductCountMskTxtBox.Text));
                    ProductCountTxt.Text = Shop.ReturnProductCount(Product).ToString();
                    BuyProductCountMskTxtBox.Text = string.Empty;
                    MoneyLb.Text = Shop.Money.ToString();
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
            if (ProductListBx.SelectedItem != null && !string.IsNullOrWhiteSpace(SellProductCountMskTxtBox.Text))
            {
                try
                {
                    var Product = (Product)ProductListBx.SelectedItem;
                    Shop.ProductSell(Product, int.Parse(SellProductCountMskTxtBox.Text));
                    ProductCountTxt.Text = Shop.ReturnProductCount(Product).ToString();
                    SellProductCountMskTxtBox.Text = string.Empty;
                    MoneyLb.Text = Shop.Money.ToString();
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
            ProductListBx.DataSource = Shop.ProductAndProductCount.Keys.ToList();
            ProductListBx.DisplayMember = "Name";
            ProductListBx.ValueMember = "Name";
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
            if (!string.IsNullOrWhiteSpace(MoneyMskTxtBox.Text))
            {
                Shop.Money += int.Parse(MoneyMskTxtBox.Text);
                MoneyLb.Text = Shop.Money.ToString();
                FileWorker.SaveMoney(Shop.Money);
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            ProductListBx.DataSource = Shop.ProductAndProductCount.Keys.ToList().SortName(NameOrderOnChkBx.Checked).SortCategory(CategoryOrderOnChkBx.Checked).SortPrice(PriceOrderOnChkBx.Checked);
            ProductListBx.DisplayMember = "Name";
            ProductListBx.ValueMember = "Name";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int FromPrice = string.IsNullOrWhiteSpace(fromPriceMskTxtBx.Text) ? 0 : int.Parse(fromPriceMskTxtBx.Text);
            int ToPrice = string.IsNullOrWhiteSpace(ToPriceMskTxtBx.Text) ? 0 : int.Parse(ToPriceMskTxtBx.Text);
            var ProductSearchSelected = Shop.ProductAndProductCount.Keys.ToList().SearchName(NameSearchMskTxtBx.Text).SearchCategory((Category)CategoryCheckCmbBx.SelectedItem).SearchPrice(FromPrice,ToPrice);
            ProductListBx.DataSource = ProductSearchSelected;
            ProductListBx.DisplayMember = "Name";
            ProductListBx.ValueMember = "Name";

        }

        private void SearchCleanBtn_Click(object sender, EventArgs e)
        {
            ProductListRefresh();
        }
    }
}
