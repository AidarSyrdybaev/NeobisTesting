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
            this.ProductNameTxt = new System.Windows.Forms.Label();
            this.ProductCountTxt = new System.Windows.Forms.Label();
            this.ProductCategoryTxt = new System.Windows.Forms.Label();
            this.ProductPriceTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductAddBt = new System.Windows.Forms.Button();
            this.ProductRemoveBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyLb = new System.Windows.Forms.Label();
            this.MoneyMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.MoneyAddBtn = new System.Windows.Forms.Button();
            this.NameOrderOnChkBx = new System.Windows.Forms.CheckBox();
            this.PriceOrderOnChkBx = new System.Windows.Forms.CheckBox();
            this.CategoryOrderOnChkBx = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.NameSearchMskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.ToPriceMskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.fromPriceMskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CategoryCheckCmbBx = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchCleanBtn = new System.Windows.Forms.Button();
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
            this.ProductListBx.Location = new System.Drawing.Point(38, 243);
            this.ProductListBx.Name = "ProductListBx";
            this.ProductListBx.Size = new System.Drawing.Size(372, 121);
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
            this.ProductInformationPanel.Location = new System.Drawing.Point(484, 12);
            this.ProductInformationPanel.Name = "ProductInformationPanel";
            this.ProductInformationPanel.Size = new System.Drawing.Size(245, 123);
            this.ProductInformationPanel.TabIndex = 16;
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.AutoSize = true;
            this.ProductNameTxt.Location = new System.Drawing.Point(143, 23);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductNameTxt.TabIndex = 19;
            // 
            // ProductCountTxt
            // 
            this.ProductCountTxt.AutoSize = true;
            this.ProductCountTxt.Location = new System.Drawing.Point(143, 91);
            this.ProductCountTxt.Name = "ProductCountTxt";
            this.ProductCountTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductCountTxt.TabIndex = 18;
            // 
            // ProductCategoryTxt
            // 
            this.ProductCategoryTxt.AutoSize = true;
            this.ProductCategoryTxt.Location = new System.Drawing.Point(143, 68);
            this.ProductCategoryTxt.Name = "ProductCategoryTxt";
            this.ProductCategoryTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductCategoryTxt.TabIndex = 17;
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.AutoSize = true;
            this.ProductPriceTxt.Location = new System.Drawing.Point(143, 45);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(0, 13);
            this.ProductPriceTxt.TabIndex = 16;
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
            this.groupBox1.Location = new System.Drawing.Point(484, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 283);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции с продуктом";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество денег(в сомах):";
            // 
            // MoneyLb
            // 
            this.MoneyLb.AutoSize = true;
            this.MoneyLb.Location = new System.Drawing.Point(205, 378);
            this.MoneyLb.Name = "MoneyLb";
            this.MoneyLb.Size = new System.Drawing.Size(0, 13);
            this.MoneyLb.TabIndex = 18;
            // 
            // MoneyMskTxtBox
            // 
            this.MoneyMskTxtBox.Location = new System.Drawing.Point(138, 408);
            this.MoneyMskTxtBox.Name = "MoneyMskTxtBox";
            this.MoneyMskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MoneyMskTxtBox.TabIndex = 19;
            // 
            // MoneyAddBtn
            // 
            this.MoneyAddBtn.Location = new System.Drawing.Point(38, 396);
            this.MoneyAddBtn.Name = "MoneyAddBtn";
            this.MoneyAddBtn.Size = new System.Drawing.Size(75, 42);
            this.MoneyAddBtn.TabIndex = 20;
            this.MoneyAddBtn.Text = "Пополнить счет";
            this.MoneyAddBtn.UseVisualStyleBackColor = true;
            this.MoneyAddBtn.Click += new System.EventHandler(this.MoneyAddBtn_Click);
            // 
            // NameOrderOnChkBx
            // 
            this.NameOrderOnChkBx.AutoSize = true;
            this.NameOrderOnChkBx.Location = new System.Drawing.Point(38, 31);
            this.NameOrderOnChkBx.Name = "NameOrderOnChkBx";
            this.NameOrderOnChkBx.Size = new System.Drawing.Size(75, 17);
            this.NameOrderOnChkBx.TabIndex = 24;
            this.NameOrderOnChkBx.Text = "По имени";
            this.NameOrderOnChkBx.UseVisualStyleBackColor = true;
            // 
            // PriceOrderOnChkBx
            // 
            this.PriceOrderOnChkBx.AutoSize = true;
            this.PriceOrderOnChkBx.Location = new System.Drawing.Point(138, 31);
            this.PriceOrderOnChkBx.Name = "PriceOrderOnChkBx";
            this.PriceOrderOnChkBx.Size = new System.Drawing.Size(67, 17);
            this.PriceOrderOnChkBx.TabIndex = 25;
            this.PriceOrderOnChkBx.Text = "По цене";
            this.PriceOrderOnChkBx.UseVisualStyleBackColor = true;
            // 
            // CategoryOrderOnChkBx
            // 
            this.CategoryOrderOnChkBx.AutoSize = true;
            this.CategoryOrderOnChkBx.Location = new System.Drawing.Point(233, 31);
            this.CategoryOrderOnChkBx.Name = "CategoryOrderOnChkBx";
            this.CategoryOrderOnChkBx.Size = new System.Drawing.Size(95, 17);
            this.CategoryOrderOnChkBx.TabIndex = 26;
            this.CategoryOrderOnChkBx.Text = "По категории";
            this.CategoryOrderOnChkBx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Сортировка:";
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(43, 52);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(88, 23);
            this.SortBtn.TabIndex = 28;
            this.SortBtn.Text = "Сортировать";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // NameSearchMskTxtBx
            // 
            this.NameSearchMskTxtBx.Location = new System.Drawing.Point(38, 129);
            this.NameSearchMskTxtBx.Name = "NameSearchMskTxtBx";
            this.NameSearchMskTxtBx.Size = new System.Drawing.Size(100, 20);
            this.NameSearchMskTxtBx.TabIndex = 31;
            // 
            // ToPriceMskTxtBx
            // 
            this.ToPriceMskTxtBx.Location = new System.Drawing.Point(199, 155);
            this.ToPriceMskTxtBx.Mask = "00000000";
            this.ToPriceMskTxtBx.Name = "ToPriceMskTxtBx";
            this.ToPriceMskTxtBx.Size = new System.Drawing.Size(75, 20);
            this.ToPriceMskTxtBx.TabIndex = 32;
            this.ToPriceMskTxtBx.ValidatingType = typeof(int);
            // 
            // fromPriceMskTxtBx
            // 
            this.fromPriceMskTxtBx.Location = new System.Drawing.Point(199, 129);
            this.fromPriceMskTxtBx.Mask = "00000000";
            this.fromPriceMskTxtBx.Name = "fromPriceMskTxtBx";
            this.fromPriceMskTxtBx.Size = new System.Drawing.Size(75, 20);
            this.fromPriceMskTxtBx.TabIndex = 33;
            this.fromPriceMskTxtBx.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Поиск продукта по параметрам:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "По Категории:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "От:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "По цене:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "До:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "По имени";
            // 
            // CategoryCheckCmbBx
            // 
            this.CategoryCheckCmbBx.FormattingEnabled = true;
            this.CategoryCheckCmbBx.Location = new System.Drawing.Point(317, 129);
            this.CategoryCheckCmbBx.Name = "CategoryCheckCmbBx";
            this.CategoryCheckCmbBx.Size = new System.Drawing.Size(121, 21);
            this.CategoryCheckCmbBx.TabIndex = 40;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(43, 194);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 41;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchCleanBtn
            // 
            this.SearchCleanBtn.Location = new System.Drawing.Point(145, 194);
            this.SearchCleanBtn.Name = "SearchCleanBtn";
            this.SearchCleanBtn.Size = new System.Drawing.Size(183, 23);
            this.SearchCleanBtn.TabIndex = 42;
            this.SearchCleanBtn.Text = "Обнулить условия поиска";
            this.SearchCleanBtn.UseVisualStyleBackColor = true;
            this.SearchCleanBtn.Click += new System.EventHandler(this.SearchCleanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchCleanBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CategoryCheckCmbBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromPriceMskTxtBx);
            this.Controls.Add(this.ProductListBx);
            this.Controls.Add(this.ToPriceMskTxtBx);
            this.Controls.Add(this.NameSearchMskTxtBx);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoryOrderOnChkBx);
            this.Controls.Add(this.PriceOrderOnChkBx);
            this.Controls.Add(this.NameOrderOnChkBx);
            this.Controls.Add(this.MoneyAddBtn);
            this.Controls.Add(this.MoneyMskTxtBox);
            this.Controls.Add(this.MoneyLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductInformationPanel);
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
        private System.Windows.Forms.CheckBox NameOrderOnChkBx;
        private System.Windows.Forms.CheckBox PriceOrderOnChkBx;
        private System.Windows.Forms.CheckBox CategoryOrderOnChkBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.MaskedTextBox NameSearchMskTxtBx;
        private System.Windows.Forms.MaskedTextBox ToPriceMskTxtBx;
        private System.Windows.Forms.MaskedTextBox fromPriceMskTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CategoryCheckCmbBx;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button SearchCleanBtn;
    }
}

