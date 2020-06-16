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
            this.PriceLb = new System.Windows.Forms.Label();
            this.BuyProductCountMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SellProductCountMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            this.SellProductBtn = new System.Windows.Forms.Button();
            this.ProductListBx = new System.Windows.Forms.ListBox();
            this.ProductNameLb = new System.Windows.Forms.Label();
            this.ProductPriceLb = new System.Windows.Forms.Label();
            this.ProductCategoryLb = new System.Windows.Forms.Label();
            this.ProductInformationPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductPriceTxt = new System.Windows.Forms.Label();
            this.ProductCategoryTxt = new System.Windows.Forms.Label();
            this.ProductCountTxt = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.Label();
            this.ProductRemoveBt = new System.Windows.Forms.Button();
            this.ProductAddBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyLb = new System.Windows.Forms.Label();
            this.MoneyMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.MoneyAddBtn = new System.Windows.Forms.Button();
            this.ProductInformationPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Location = new System.Drawing.Point(5, 91);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(115, 13);
            this.PriceLb.TabIndex = 5;
            this.PriceLb.Text = "Количество продукта";
            // 
            // BuyProductCountMskTxtBox
            // 
            this.BuyProductCountMskTxtBox.Location = new System.Drawing.Point(54, 74);
            this.BuyProductCountMskTxtBox.Mask = "00000";
            this.BuyProductCountMskTxtBox.Name = "BuyProductCountMskTxtBox";
            this.BuyProductCountMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.BuyProductCountMskTxtBox.TabIndex = 6;
            this.BuyProductCountMskTxtBox.ValidatingType = typeof(int);
            // 
            // SellProductCountMskTxtBox
            // 
            this.SellProductCountMskTxtBox.Location = new System.Drawing.Point(54, 142);
            this.SellProductCountMskTxtBox.Mask = "00000";
            this.SellProductCountMskTxtBox.Name = "SellProductCountMskTxtBox";
            this.SellProductCountMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SellProductCountMskTxtBox.TabIndex = 7;
            this.SellProductCountMskTxtBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Продажа продукта в количестве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Покупка продукта в количестве";
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.Location = new System.Drawing.Point(68, 100);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(75, 23);
            this.BuyProductBtn.TabIndex = 10;
            this.BuyProductBtn.Text = "Купить";
            this.BuyProductBtn.UseVisualStyleBackColor = true;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // SellProductBtn
            // 
            this.SellProductBtn.Location = new System.Drawing.Point(68, 168);
            this.SellProductBtn.Name = "SellProductBtn";
            this.SellProductBtn.Size = new System.Drawing.Size(75, 23);
            this.SellProductBtn.TabIndex = 11;
            this.SellProductBtn.Text = "Продать";
            this.SellProductBtn.UseVisualStyleBackColor = true;
            this.SellProductBtn.Click += new System.EventHandler(this.SellProductBtn_Click);
            // 
            // ProductListBx
            // 
            this.ProductListBx.FormattingEnabled = true;
            this.ProductListBx.Location = new System.Drawing.Point(24, 12);
            this.ProductListBx.Name = "ProductListBx";
            this.ProductListBx.Size = new System.Drawing.Size(372, 264);
            this.ProductListBx.TabIndex = 12;
            this.ProductListBx.Click += new System.EventHandler(this.ProductListBx_Click);
            // 
            // ProductNameLb
            // 
            this.ProductNameLb.AutoSize = true;
            this.ProductNameLb.Location = new System.Drawing.Point(5, 23);
            this.ProductNameLb.Name = "ProductNameLb";
            this.ProductNameLb.Size = new System.Drawing.Size(106, 13);
            this.ProductNameLb.TabIndex = 13;
            this.ProductNameLb.Text = "Название продукта";
            // 
            // ProductPriceLb
            // 
            this.ProductPriceLb.AutoSize = true;
            this.ProductPriceLb.Location = new System.Drawing.Point(5, 45);
            this.ProductPriceLb.Name = "ProductPriceLb";
            this.ProductPriceLb.Size = new System.Drawing.Size(82, 13);
            this.ProductPriceLb.TabIndex = 14;
            this.ProductPriceLb.Text = "Цена продукта";
            // 
            // ProductCategoryLb
            // 
            this.ProductCategoryLb.AutoSize = true;
            this.ProductCategoryLb.Location = new System.Drawing.Point(5, 68);
            this.ProductCategoryLb.Name = "ProductCategoryLb";
            this.ProductCategoryLb.Size = new System.Drawing.Size(109, 13);
            this.ProductCategoryLb.TabIndex = 15;
            this.ProductCategoryLb.Text = "Категория продукта";
            // 
            // ProductInformationPanel
            // 
            this.ProductInformationPanel.Controls.Add(this.ProductNameTxt);
            this.ProductInformationPanel.Controls.Add(this.ProductCountTxt);
            this.ProductInformationPanel.Controls.Add(this.ProductCategoryTxt);
            this.ProductInformationPanel.Controls.Add(this.ProductPriceTxt);
            this.ProductInformationPanel.Controls.Add(this.PriceLb);
            this.ProductInformationPanel.Controls.Add(this.ProductNameLb);
            this.ProductInformationPanel.Controls.Add(this.ProductCategoryLb);
            this.ProductInformationPanel.Controls.Add(this.ProductPriceLb);
            this.ProductInformationPanel.Location = new System.Drawing.Point(416, 12);
            this.ProductInformationPanel.Name = "ProductInformationPanel";
            this.ProductInformationPanel.Size = new System.Drawing.Size(245, 123);
            this.ProductInformationPanel.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductAddBt);
            this.groupBox1.Controls.Add(this.ProductRemoveBt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SellProductBtn);
            this.groupBox1.Controls.Add(this.BuyProductCountMskTxtBox);
            this.groupBox1.Controls.Add(this.SellProductCountMskTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BuyProductBtn);
            this.groupBox1.Location = new System.Drawing.Point(416, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 283);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции с продуктом";
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.AutoSize = true;
            this.ProductPriceTxt.Location = new System.Drawing.Point(143, 45);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductPriceTxt.TabIndex = 16;
            // 
            // ProductCategoryTxt
            // 
            this.ProductCategoryTxt.AutoSize = true;
            this.ProductCategoryTxt.Location = new System.Drawing.Point(143, 68);
            this.ProductCategoryTxt.Name = "ProductCategoryTxt";
            this.ProductCategoryTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductCategoryTxt.TabIndex = 17;
            // 
            // ProductCountTxt
            // 
            this.ProductCountTxt.AutoSize = true;
            this.ProductCountTxt.Location = new System.Drawing.Point(143, 91);
            this.ProductCountTxt.Name = "ProductCountTxt";
            this.ProductCountTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductCountTxt.TabIndex = 18;
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.AutoSize = true;
            this.ProductNameTxt.Location = new System.Drawing.Point(143, 23);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductNameTxt.TabIndex = 19;
            // 
            // ProductRemoveBt
            // 
            this.ProductRemoveBt.Location = new System.Drawing.Point(116, 209);
            this.ProductRemoveBt.Name = "ProductRemoveBt";
            this.ProductRemoveBt.Size = new System.Drawing.Size(75, 41);
            this.ProductRemoveBt.TabIndex = 12;
            this.ProductRemoveBt.Text = "Удалить продукт";
            this.ProductRemoveBt.UseVisualStyleBackColor = true;
            this.ProductRemoveBt.Click += new System.EventHandler(this.ProductRemoveBt_Click);
            // 
            // ProductAddBt
            // 
            this.ProductAddBt.Location = new System.Drawing.Point(25, 209);
            this.ProductAddBt.Name = "ProductAddBt";
            this.ProductAddBt.Size = new System.Drawing.Size(75, 41);
            this.ProductAddBt.TabIndex = 13;
            this.ProductAddBt.Text = "Добавить продукт";
            this.ProductAddBt.UseVisualStyleBackColor = true;
            this.ProductAddBt.Click += new System.EventHandler(this.ProductAddBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество денег(в сомах):";
            // 
            // MoneyLb
            // 
            this.MoneyLb.AutoSize = true;
            this.MoneyLb.Location = new System.Drawing.Point(218, 281);
            this.MoneyLb.Name = "MoneyLb";
            this.MoneyLb.Size = new System.Drawing.Size(0, 13);
            this.MoneyLb.TabIndex = 18;
            // 
            // MoneyMskTxtBox
            // 
            this.MoneyMskTxtBox.Location = new System.Drawing.Point(151, 316);
            this.MoneyMskTxtBox.Name = "MoneyMskTxtBox";
            this.MoneyMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoneyMskTxtBox.TabIndex = 19;
            // 
            // MoneyAddBtn
            // 
            this.MoneyAddBtn.Location = new System.Drawing.Point(58, 304);
            this.MoneyAddBtn.Name = "MoneyAddBtn";
            this.MoneyAddBtn.Size = new System.Drawing.Size(75, 42);
            this.MoneyAddBtn.TabIndex = 20;
            this.MoneyAddBtn.Text = "Пополнить счет";
            this.MoneyAddBtn.UseVisualStyleBackColor = true;
            this.MoneyAddBtn.Click += new System.EventHandler(this.MoneyAddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyAddBtn);
            this.Controls.Add(this.MoneyMskTxtBox);
            this.Controls.Add(this.MoneyLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductInformationPanel);
            this.Controls.Add(this.ProductListBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProductInformationPanel.ResumeLayout(false);
            this.ProductInformationPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.MaskedTextBox BuyProductCountMskTxtBox;
        private System.Windows.Forms.MaskedTextBox SellProductCountMskTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyProductBtn;
        private System.Windows.Forms.Button SellProductBtn;
        private System.Windows.Forms.ListBox ProductListBx;
        private System.Windows.Forms.Label ProductNameLb;
        private System.Windows.Forms.Label ProductPriceLb;
        private System.Windows.Forms.Label ProductCategoryLb;
        private System.Windows.Forms.Panel ProductInformationPanel;
        private System.Windows.Forms.Label ProductNameTxt;
        private System.Windows.Forms.Label ProductCountTxt;
        private System.Windows.Forms.Label ProductCategoryTxt;
        private System.Windows.Forms.Label ProductPriceTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ProductAddBt;
        private System.Windows.Forms.Button ProductRemoveBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MoneyLb;
        private System.Windows.Forms.MaskedTextBox MoneyMskTxtBox;
        private System.Windows.Forms.Button MoneyAddBtn;
    }
}

