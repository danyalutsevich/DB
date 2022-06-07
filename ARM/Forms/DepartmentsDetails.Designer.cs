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
            this.labelAmountOfMainManagers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmountOfSecManagers = new System.Windows.Forms.Label();
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
            // labelAmountOfMainManagers
            // 
            this.labelAmountOfMainManagers.AutoSize = true;
            this.labelAmountOfMainManagers.Location = new System.Drawing.Point(297, 88);
            this.labelAmountOfMainManagers.Name = "labelAmountOfMainManagers";
            this.labelAmountOfMainManagers.Size = new System.Drawing.Size(49, 15);
            this.labelAmountOfMainManagers.TabIndex = 1;
            this.labelAmountOfMainManagers.Text = "amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount of Main Managers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of Sec Managers:";
            // 
            // labelAmountOfSecManagers
            // 
            this.labelAmountOfSecManagers.AutoSize = true;
            this.labelAmountOfSecManagers.Location = new System.Drawing.Point(288, 112);
            this.labelAmountOfSecManagers.Name = "labelAmountOfSecManagers";
            this.labelAmountOfSecManagers.Size = new System.Drawing.Size(49, 15);
            this.labelAmountOfSecManagers.TabIndex = 1;
            this.labelAmountOfSecManagers.Text = "amount";
            // 
            // DepartmentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAmountOfSecManagers);
            this.Controls.Add(this.labelAmountOfMainManagers);
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
        private System.Windows.Forms.Label labelAmountOfMainManagers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAmountOfSecManagers;
    }
}