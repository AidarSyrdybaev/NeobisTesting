namespace Deadline6SecondTry.Forms.Create
{
    partial class TeacherCreateForm
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
            this.StudentSelectBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTxtBx = new System.Windows.Forms.TextBox();
            this.BornDateTimeTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.PassportIdMskBx = new System.Windows.Forms.MaskedTextBox();
            this.StudentsCmbBx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            MiddleNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentSelectBtn
            // 
            this.StudentSelectBtn.Location = new System.Drawing.Point(207, 61);
            this.StudentSelectBtn.Name = "StudentSelectBtn";
            this.StudentSelectBtn.Size = new System.Drawing.Size(188, 23);
            this.StudentSelectBtn.TabIndex = 25;
            this.StudentSelectBtn.Text = "Выбрать среди студентов.";
            this.StudentSelectBtn.UseVisualStyleBackColor = true;
            this.StudentSelectBtn.Click += new System.EventHandler(this.StudentSelectBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID паспорта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата Рождения";
            // 
            // AddressTxtBx
            // 
            this.AddressTxtBx.Location = new System.Drawing.Point(24, 240);
            this.AddressTxtBx.Name = "AddressTxtBx";
            this.AddressTxtBx.Size = new System.Drawing.Size(148, 20);
            this.AddressTxtBx.TabIndex = 18;
            // 
            // BornDateTimeTxtBox
            // 
            this.BornDateTimeTxtBox.Location = new System.Drawing.Point(24, 197);
            this.BornDateTimeTxtBox.Name = "BornDateTimeTxtBox";
            this.BornDateTimeTxtBox.Size = new System.Drawing.Size(148, 20);
            this.BornDateTimeTxtBox.TabIndex = 17;
            // 
            // MiddleNameTxtBox
            // 
            MiddleNameTxtBox.Location = new System.Drawing.Point(24, 151);
            MiddleNameTxtBox.Name = "MiddleNameTxtBox";
            MiddleNameTxtBox.Size = new System.Drawing.Size(148, 20);
            MiddleNameTxtBox.TabIndex = 16;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(24, 106);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(148, 20);
            this.NameTxtBox.TabIndex = 15;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(24, 64);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(148, 20);
            this.FirstNameTxtBox.TabIndex = 14;
            // 
            // PassportIdMskBx
            // 
            this.PassportIdMskBx.Location = new System.Drawing.Point(24, 25);
            this.PassportIdMskBx.Mask = "000000000";
            this.PassportIdMskBx.Name = "PassportIdMskBx";
            this.PassportIdMskBx.Size = new System.Drawing.Size(68, 20);
            this.PassportIdMskBx.TabIndex = 13;
            this.PassportIdMskBx.ValidatingType = typeof(int);
            // 
            // StudentsCmbBx
            // 
            this.StudentsCmbBx.FormattingEnabled = true;
            this.StudentsCmbBx.Location = new System.Drawing.Point(207, 34);
            this.StudentsCmbBx.Name = "StudentsCmbBx";
            this.StudentsCmbBx.Size = new System.Drawing.Size(121, 21);
            this.StudentsCmbBx.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Выбрать студента";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(24, 288);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Выберите кафедру";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Создать учителя";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TeacherCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentsCmbBx);
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
            this.Name = "TeacherCreateForm";
            this.Text = "TeacherCreateForm";
            this.Load += new System.EventHandler(this.TeacherCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentSelectBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTxtBx;
        private System.Windows.Forms.MaskedTextBox BornDateTimeTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.MaskedTextBox PassportIdMskBx;
        private System.Windows.Forms.ComboBox StudentsCmbBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}