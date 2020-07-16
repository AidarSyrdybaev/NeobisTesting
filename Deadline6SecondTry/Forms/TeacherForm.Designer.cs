namespace Deadline6SecondTry.Forms
{
    partial class TeacherForm
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
            System.Windows.Forms.TextBox MiddleNameTxtBox;
            this.PassportIdMskBx = new System.Windows.Forms.MaskedTextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.BornDateTimeTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.AddressTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentSelectBtn = new System.Windows.Forms.Button();
            MiddleNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PassportIdMskBx
            // 
            this.PassportIdMskBx.Location = new System.Drawing.Point(31, 36);
            this.PassportIdMskBx.Mask = "000000000";
            this.PassportIdMskBx.Name = "PassportIdMskBx";
            this.PassportIdMskBx.Size = new System.Drawing.Size(68, 20);
            this.PassportIdMskBx.TabIndex = 0;
            this.PassportIdMskBx.ValidatingType = typeof(int);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(31, 88);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(148, 20);
            this.FirstNameTxtBox.TabIndex = 1;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(31, 138);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(148, 20);
            this.NameTxtBox.TabIndex = 2;
            // 
            // MiddleNameTxtBox
            // 
            MiddleNameTxtBox.Location = new System.Drawing.Point(31, 190);
            MiddleNameTxtBox.Name = "MiddleNameTxtBox";
            MiddleNameTxtBox.Size = new System.Drawing.Size(148, 20);
            MiddleNameTxtBox.TabIndex = 3;
            // 
            // BornDateTimeTxtBox
            // 
            this.BornDateTimeTxtBox.Location = new System.Drawing.Point(31, 235);
            this.BornDateTimeTxtBox.Name = "BornDateTimeTxtBox";
            this.BornDateTimeTxtBox.Size = new System.Drawing.Size(148, 20);
            this.BornDateTimeTxtBox.TabIndex = 4;
            // 
            // AddressTxtBx
            // 
            this.AddressTxtBx.Location = new System.Drawing.Point(31, 279);
            this.AddressTxtBx.Name = "AddressTxtBx";
            this.AddressTxtBx.Size = new System.Drawing.Size(148, 20);
            this.AddressTxtBx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата Рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID паспорта:";
            // 
            // StudentSelectBtn
            // 
            this.StudentSelectBtn.Location = new System.Drawing.Point(237, 85);
            this.StudentSelectBtn.Name = "StudentSelectBtn";
            this.StudentSelectBtn.Size = new System.Drawing.Size(188, 23);
            this.StudentSelectBtn.TabIndex = 12;
            this.StudentSelectBtn.Text = "Выбрать среди студентов.";
            this.StudentSelectBtn.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentSelectBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTxtBx);
            this.Controls.Add(this.BornDateTimeTxtBox);
            this.Controls.Add(MiddleNameTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.PassportIdMskBx);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PassportIdMskBx;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.MaskedTextBox BornDateTimeTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StudentSelectBtn;
    }
}