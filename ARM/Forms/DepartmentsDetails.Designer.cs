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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDepId = new System.Windows.Forms.Label();
            this.labelAmountOfManagers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.listBoxDepartments.SelectedIndexChanged += new System.EventHandler(this.listBoxDepartments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department ID:";
            // 
            // labelDepId
            // 
            this.labelDepId.AutoSize = true;
            this.labelDepId.Location = new System.Drawing.Point(231, 60);
            this.labelDepId.Name = "labelDepId";
            this.labelDepId.Size = new System.Drawing.Size(17, 15);
            this.labelDepId.TabIndex = 1;
            this.labelDepId.Text = "id";
            // 
            // labelAmountOfManagers
            // 
            this.labelAmountOfManagers.AutoSize = true;
            this.labelAmountOfManagers.Location = new System.Drawing.Point(267, 88);
            this.labelAmountOfManagers.Name = "labelAmountOfManagers";
            this.labelAmountOfManagers.Size = new System.Drawing.Size(49, 15);
            this.labelAmountOfManagers.TabIndex = 1;
            this.labelAmountOfManagers.Text = "amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount of Managers:";
            // 
            // DepartmentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAmountOfManagers);
            this.Controls.Add(this.labelDepId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDepartments);
            this.Name = "DepartmentsDetails";
            this.Text = "DepartmentsDetails";
            this.Load += new System.EventHandler(this.DepartmentsDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDepId;
        private System.Windows.Forms.Label labelAmountOfManagers;
        private System.Windows.Forms.Label label3;
    }
}