namespace Deadline6SecondTry.Forms.Create
{
    partial class DepartmentCreateForm
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
            this.DepartmentNameTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartmentNameTxtBx
            // 
            this.DepartmentNameTxtBx.Location = new System.Drawing.Point(11, 52);
            this.DepartmentNameTxtBx.Name = "DepartmentNameTxtBx";
            this.DepartmentNameTxtBx.Size = new System.Drawing.Size(188, 20);
            this.DepartmentNameTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование факультета";
            // 
            // DepartmentCreateBtn
            // 
            this.DepartmentCreateBtn.Location = new System.Drawing.Point(11, 78);
            this.DepartmentCreateBtn.Name = "DepartmentCreateBtn";
            this.DepartmentCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.DepartmentCreateBtn.TabIndex = 2;
            this.DepartmentCreateBtn.Text = "Создать факультет";
            this.DepartmentCreateBtn.UseVisualStyleBackColor = true;
            this.DepartmentCreateBtn.Click += new System.EventHandler(this.DepartmentCreateBtn_Click);
            // 
            // DepartmentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 212);
            this.Controls.Add(this.DepartmentCreateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepartmentNameTxtBx);
            this.Name = "DepartmentCreate";
            this.Text = "DepartmentCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DepartmentNameTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DepartmentCreateBtn;
    }
}