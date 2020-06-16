namespace Deadline5
{
    partial class AddForm
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
            this.ProductNameMskdTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.ProductPriceMskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.CategoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameMskdTxtBx
            // 
            this.ProductNameMskdTxtBx.Location = new System.Drawing.Point(8, 38);
            this.ProductNameMskdTxtBx.Name = "ProductNameMskdTxtBx";
            this.ProductNameMskdTxtBx.Size = new System.Drawing.Size(120, 20);
            this.ProductNameMskdTxtBx.TabIndex = 0;
            // 
            // ProductPriceMskTxtBx
            // 
            this.ProductPriceMskTxtBx.Location = new System.Drawing.Point(8, 79);
            this.ProductPriceMskTxtBx.Mask = "00000000000";
            this.ProductPriceMskTxtBx.Name = "ProductPriceMskTxtBx";
            this.ProductPriceMskTxtBx.Size = new System.Drawing.Size(120, 20);
            this.ProductPriceMskTxtBx.TabIndex = 1;
            this.ProductPriceMskTxtBx.ValidatingType = typeof(int);
            // 
            // CategoryCheckedListBox
            // 
            this.CategoryCheckedListBox.FormattingEnabled = true;
            this.CategoryCheckedListBox.Location = new System.Drawing.Point(8, 122);
            this.CategoryCheckedListBox.Name = "CategoryCheckedListBox";
            this.CategoryCheckedListBox.Size = new System.Drawing.Size(120, 79);
            this.CategoryCheckedListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория продукта";
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Location = new System.Drawing.Point(26, 218);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(75, 42);
            this.ProductAddBtn.TabIndex = 6;
            this.ProductAddBtn.Text = "Создать продукт";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.ProductAddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryCheckedListBox);
            this.Controls.Add(this.ProductPriceMskTxtBx);
            this.Controls.Add(this.ProductNameMskdTxtBx);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ProductNameMskdTxtBx;
        private System.Windows.Forms.MaskedTextBox ProductPriceMskTxtBx;
        private System.Windows.Forms.CheckedListBox CategoryCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProductAddBtn;
    }
}