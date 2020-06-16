namespace Deadline5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCountMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BuyProductCountMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SellProductCountMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            this.SellProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductCategory});
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(350, 263);
            this.ProductsDataGridView.TabIndex = 1;
            this.ProductsDataGridView.Click += new System.EventHandler(this.ProductsDataGridView_Click);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название продукта";
            this.ProductName.Name = "ProductName";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Цена продукта";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Категория продукта";
            this.ProductCategory.Name = "ProductCategory";
            // 
            // ProductCountMskTxtBox
            // 
            this.ProductCountMskTxtBox.Location = new System.Drawing.Point(439, 40);
            this.ProductCountMskTxtBox.Name = "ProductCountMskTxtBox";
            this.ProductCountMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ProductCountMskTxtBox.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(436, 12);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(115, 13);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Количество продукта";
            // 
            // BuyProductCountMskTxtBox
            // 
            this.BuyProductCountMskTxtBox.Location = new System.Drawing.Point(439, 88);
            this.BuyProductCountMskTxtBox.Name = "BuyProductCountMskTxtBox";
            this.BuyProductCountMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.BuyProductCountMskTxtBox.TabIndex = 6;
            // 
            // SellProductCountMskTxtBox
            // 
            this.SellProductCountMskTxtBox.Location = new System.Drawing.Point(439, 169);
            this.SellProductCountMskTxtBox.Name = "SellProductCountMskTxtBox";
            this.SellProductCountMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SellProductCountMskTxtBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Продажа продукта в количестве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Покупка продукта в количестве";
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.Location = new System.Drawing.Point(444, 118);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(75, 23);
            this.BuyProductBtn.TabIndex = 10;
            this.BuyProductBtn.Text = "Купить";
            this.BuyProductBtn.UseVisualStyleBackColor = true;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // SellProductBtn
            // 
            this.SellProductBtn.Location = new System.Drawing.Point(444, 204);
            this.SellProductBtn.Name = "SellProductBtn";
            this.SellProductBtn.Size = new System.Drawing.Size(75, 23);
            this.SellProductBtn.TabIndex = 11;
            this.SellProductBtn.Text = "Продать";
            this.SellProductBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SellProductBtn);
            this.Controls.Add(this.BuyProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellProductCountMskTxtBox);
            this.Controls.Add(this.BuyProductCountMskTxtBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductCountMskTxtBox);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.MaskedTextBox ProductCountMskTxtBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.MaskedTextBox BuyProductCountMskTxtBox;
        private System.Windows.Forms.MaskedTextBox SellProductCountMskTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyProductBtn;
        private System.Windows.Forms.Button SellProductBtn;
    }
}

