namespace Deadline6SecondTry.Forms
{
    partial class DepartmentForm
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
            this.DepartmentCreateForm = new System.Windows.Forms.Button();
            this.CafedreLstBx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DepartmentCreateForm
            // 
            this.DepartmentCreateForm.Location = new System.Drawing.Point(12, 12);
            this.DepartmentCreateForm.Name = "DepartmentCreateForm";
            this.DepartmentCreateForm.Size = new System.Drawing.Size(217, 23);
            this.DepartmentCreateForm.TabIndex = 0;
            this.DepartmentCreateForm.Text = "Создать факультет";
            this.DepartmentCreateForm.UseVisualStyleBackColor = true;
            this.DepartmentCreateForm.Click += new System.EventHandler(this.DepartmentCreateForm_Click);
            // 
            // CafedreLstBx
            // 
            this.CafedreLstBx.FormattingEnabled = true;
            this.CafedreLstBx.Location = new System.Drawing.Point(12, 96);
            this.CafedreLstBx.Name = "CafedreLstBx";
            this.CafedreLstBx.Size = new System.Drawing.Size(326, 160);
            this.CafedreLstBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список факультетов:";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CafedreLstBx);
            this.Controls.Add(this.DepartmentCreateForm);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DepartmentCreateForm;
        private System.Windows.Forms.ListBox CafedreLstBx;
        private System.Windows.Forms.Label label1;
    }
}