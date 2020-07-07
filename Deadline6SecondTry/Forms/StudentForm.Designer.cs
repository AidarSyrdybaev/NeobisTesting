namespace Deadline6SecondTry.Forms
{
    partial class StudentForm
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
            this.StudentCreateBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameSortChkBx = new System.Windows.Forms.CheckBox();
            this.DepartmentSortChkBx = new System.Windows.Forms.CheckBox();
            this.GroupSortChkBx = new System.Windows.Forms.CheckBox();
            this.ProfileCafedreChkBtn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.DepartmentLb = new System.Windows.Forms.Label();
            this.GroupLb = new System.Windows.Forms.Label();
            this.ProfileCafedreLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentCreateBtn
            // 
            this.StudentCreateBtn.Location = new System.Drawing.Point(38, 23);
            this.StudentCreateBtn.Name = "StudentCreateBtn";
            this.StudentCreateBtn.Size = new System.Drawing.Size(215, 23);
            this.StudentCreateBtn.TabIndex = 0;
            this.StudentCreateBtn.Text = "Добавить студента";
            this.StudentCreateBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сортировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NameSortChkBx
            // 
            this.NameSortChkBx.AutoSize = true;
            this.NameSortChkBx.Location = new System.Drawing.Point(24, 19);
            this.NameSortChkBx.Name = "NameSortChkBx";
            this.NameSortChkBx.Size = new System.Drawing.Size(70, 17);
            this.NameSortChkBx.TabIndex = 2;
            this.NameSortChkBx.Text = "По ФИО";
            this.NameSortChkBx.UseVisualStyleBackColor = true;
            // 
            // DepartmentSortChkBx
            // 
            this.DepartmentSortChkBx.AutoSize = true;
            this.DepartmentSortChkBx.Location = new System.Drawing.Point(134, 19);
            this.DepartmentSortChkBx.Name = "DepartmentSortChkBx";
            this.DepartmentSortChkBx.Size = new System.Drawing.Size(101, 17);
            this.DepartmentSortChkBx.TabIndex = 3;
            this.DepartmentSortChkBx.Text = "По факультету";
            this.DepartmentSortChkBx.UseVisualStyleBackColor = true;
            // 
            // GroupSortChkBx
            // 
            this.GroupSortChkBx.AutoSize = true;
            this.GroupSortChkBx.Location = new System.Drawing.Point(268, 19);
            this.GroupSortChkBx.Name = "GroupSortChkBx";
            this.GroupSortChkBx.Size = new System.Drawing.Size(77, 17);
            this.GroupSortChkBx.TabIndex = 4;
            this.GroupSortChkBx.Text = "По группе";
            this.GroupSortChkBx.UseVisualStyleBackColor = true;
            // 
            // ProfileCafedreChkBtn
            // 
            this.ProfileCafedreChkBtn.AutoSize = true;
            this.ProfileCafedreChkBtn.Location = new System.Drawing.Point(375, 19);
            this.ProfileCafedreChkBtn.Name = "ProfileCafedreChkBtn";
            this.ProfileCafedreChkBtn.Size = new System.Drawing.Size(166, 17);
            this.ProfileCafedreChkBtn.TabIndex = 5;
            this.ProfileCafedreChkBtn.Text = "По профилирущей кафедре";
            this.ProfileCafedreChkBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameSortChkBx);
            this.groupBox1.Controls.Add(this.ProfileCafedreChkBtn);
            this.groupBox1.Controls.Add(this.DepartmentSortChkBx);
            this.groupBox1.Controls.Add(this.GroupSortChkBx);
            this.groupBox1.Location = new System.Drawing.Point(38, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сортировки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 134);
            this.listBox1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NameLb);
            this.groupBox2.Location = new System.Drawing.Point(413, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ФИО";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GroupLb);
            this.groupBox3.Location = new System.Drawing.Point(413, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 46);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Группа";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ProfileCafedreLb);
            this.groupBox4.Location = new System.Drawing.Point(413, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 46);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Профилирующая кафедра";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DepartmentLb);
            this.groupBox5.Location = new System.Drawing.Point(413, 222);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 46);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Факультет";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Location = new System.Drawing.Point(16, 16);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(0, 13);
            this.NameLb.TabIndex = 7;
            // 
            // DepartmentLb
            // 
            this.DepartmentLb.AutoSize = true;
            this.DepartmentLb.Location = new System.Drawing.Point(16, 16);
            this.DepartmentLb.Name = "DepartmentLb";
            this.DepartmentLb.Size = new System.Drawing.Size(0, 13);
            this.DepartmentLb.TabIndex = 8;
            // 
            // GroupLb
            // 
            this.GroupLb.AutoSize = true;
            this.GroupLb.Location = new System.Drawing.Point(16, 16);
            this.GroupLb.Name = "GroupLb";
            this.GroupLb.Size = new System.Drawing.Size(0, 13);
            this.GroupLb.TabIndex = 9;
            // 
            // ProfileCafedreLb
            // 
            this.ProfileCafedreLb.AutoSize = true;
            this.ProfileCafedreLb.Location = new System.Drawing.Point(16, 16);
            this.ProfileCafedreLb.Name = "ProfileCafedreLb";
            this.ProfileCafedreLb.Size = new System.Drawing.Size(0, 13);
            this.ProfileCafedreLb.TabIndex = 10;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StudentCreateBtn);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentCreateBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox NameSortChkBx;
        private System.Windows.Forms.CheckBox DepartmentSortChkBx;
        private System.Windows.Forms.CheckBox GroupSortChkBx;
        private System.Windows.Forms.CheckBox ProfileCafedreChkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label GroupLb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ProfileCafedreLb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label DepartmentLb;
    }
}