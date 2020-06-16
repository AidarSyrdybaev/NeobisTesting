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
    public partial class AddForm : Form
    {
        Form1 Form1;
        public AddForm(Form1 form1)
        {
            Form1 = form1;
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            CategoryCheckedListBox.Items.Add(Category.Accessories);
            CategoryCheckedListBox.Items.Add(Category.Food);
            CategoryCheckedListBox.Items.Add(Category.Technic);
        }

        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            Form1.Shop.ProductAndProductCount.Add(new Product(ProductNameMskdTxtBx.Text, int.Parse(ProductPriceMskTxtBx.Text), (Category)CategoryCheckedListBox.SelectedItem), 0);
            FileWorker.SaveInformation(Form1.Shop.ProductAndProductCount);
            Form1.ProductListRefresh();
            Close();
        }
    }
}
