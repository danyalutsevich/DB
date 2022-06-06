namespace ARM.Forms
{
    partial class DepartmentsDetails
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
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listBoxDepartments
            // 
            this.listBoxDepartments.FormattingEnabled = true;
            this.listBoxDepartments.ItemHeight = 15;
            this.listBoxDepartments.Location = new System.Drawing.Point(12, 60);
            this.listBoxDepartments.Name = "listBoxDepartments";
            this.listBoxDepartments.Size = new System.Drawing.Size(120, 199);
            this.listBoxDepartments.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(150, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 1;
            // 
            // DepartmentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBoxDepartments);
            this.Name = "DepartmentsDetails";
            this.Text = "DepartmentsDetails";
            this.Load += new System.EventHandler(this.DepartmentsDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartments;
        private System.Windows.Forms.TreeView treeView1;
    }
}