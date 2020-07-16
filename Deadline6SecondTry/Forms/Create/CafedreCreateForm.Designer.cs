namespace Deadline6SecondTry.Forms.Create
{
    partial class CafedreCreateForm
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
            this.DepartmentIdCmbBx = new System.Windows.Forms.ComboBox();
            this.TeacherBossId = new System.Windows.Forms.ComboBox();
            this.IsProfileChkBx = new System.Windows.Forms.CheckBox();
            this.CafedreNameTxtBx = new System.Windows.Forms.TextBox();
            this.Факультет = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CafedreCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartmentIdCmbBx
            // 
            this.DepartmentIdCmbBx.FormattingEnabled = true;
            this.DepartmentIdCmbBx.Location = new System.Drawing.Point(23, 105);
            this.DepartmentIdCmbBx.Name = "DepartmentIdCmbBx";
            this.DepartmentIdCmbBx.Size = new System.Drawing.Size(121, 21);
            this.DepartmentIdCmbBx.TabIndex = 2;
            // 
            // TeacherBossId
            // 
            this.TeacherBossId.FormattingEnabled = true;
            this.TeacherBossId.Location = new System.Drawing.Point(23, 145);
            this.TeacherBossId.Name = "TeacherBossId";
            this.TeacherBossId.Size = new System.Drawing.Size(121, 21);
            this.TeacherBossId.TabIndex = 3;
            // 
            // IsProfileChkBx
            // 
            this.IsProfileChkBx.AutoSize = true;
            this.IsProfileChkBx.Location = new System.Drawing.Point(23, 66);
            this.IsProfileChkBx.Name = "IsProfileChkBx";
            this.IsProfileChkBx.Size = new System.Drawing.Size(150, 17);
            this.IsProfileChkBx.TabIndex = 4;
            this.IsProfileChkBx.Text = "Профильность кафедры";
            this.IsProfileChkBx.UseVisualStyleBackColor = true;
            // 
            // CafedreNameTxtBx
            // 
            this.CafedreNameTxtBx.Location = new System.Drawing.Point(23, 28);
            this.CafedreNameTxtBx.Name = "CafedreNameTxtBx";
            this.CafedreNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.CafedreNameTxtBx.TabIndex = 5;
            // 
            // Факультет
            // 
            this.Факультет.AutoSize = true;
            this.Факультет.Location = new System.Drawing.Point(20, 89);
            this.Факультет.Name = "Факультет";
            this.Факультет.Size = new System.Drawing.Size(63, 13);
            this.Факультет.TabIndex = 6;
            this.Факультет.Text = "Факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Заведующий кафедрой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Наименование кафедры";
            // 
            // CafedreCreateBtn
            // 
            this.CafedreCreateBtn.Location = new System.Drawing.Point(23, 185);
            this.CafedreCreateBtn.Name = "CafedreCreateBtn";
            this.CafedreCreateBtn.Size = new System.Drawing.Size(170, 23);
            this.CafedreCreateBtn.TabIndex = 10;
            this.CafedreCreateBtn.Text = "Создать кафедру";
            this.CafedreCreateBtn.UseVisualStyleBackColor = true;
            this.CafedreCreateBtn.Click += new System.EventHandler(this.CafedreCreateBtn_Click);
            // 
            // CafedreCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CafedreCreateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Факультет);
            this.Controls.Add(this.CafedreNameTxtBx);
            this.Controls.Add(this.IsProfileChkBx);
            this.Controls.Add(this.TeacherBossId);
            this.Controls.Add(this.DepartmentIdCmbBx);
            this.Name = "CafedreCreateForm";
            this.Text = "CafedreCreateForm";
            this.Load += new System.EventHandler(this.CafedreCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DepartmentIdCmbBx;
        private System.Windows.Forms.ComboBox TeacherBossId;
        private System.Windows.Forms.CheckBox IsProfileChkBx;
        private System.Windows.Forms.TextBox CafedreNameTxtBx;
        private System.Windows.Forms.Label Факультет;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CafedreCreateBtn;
    }
}