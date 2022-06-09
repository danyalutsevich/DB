namespace ARM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.labelDepartments = new System.Windows.Forms.Label();
            this.labelDepartmentsCount = new System.Windows.Forms.Label();
            this.labelManagers = new System.Windows.Forms.Label();
            this.labelManagersCount = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelProductsCount = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.labelSalesCount = new System.Windows.Forms.Label();
            this.buttonDepDetails = new System.Windows.Forms.Button();
            this.buttonCloudConnect = new System.Windows.Forms.Button();
            this.labelGoogleCloud = new System.Windows.Forms.Label();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection:";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(690, 26);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(0, 15);
            this.labelConnectionStatus.TabIndex = 1;
            // 
            // labelDepartments
            // 
            this.labelDepartments.AutoSize = true;
            this.labelDepartments.Location = new System.Drawing.Point(35, 26);
            this.labelDepartments.Name = "labelDepartments";
            this.labelDepartments.Size = new System.Drawing.Size(78, 15);
            this.labelDepartments.TabIndex = 2;
            this.labelDepartments.Text = "Departments:";
            // 
            // labelDepartmentsCount
            // 
            this.labelDepartmentsCount.AutoSize = true;
            this.labelDepartmentsCount.Location = new System.Drawing.Point(119, 26);
            this.labelDepartmentsCount.Name = "labelDepartmentsCount";
            this.labelDepartmentsCount.Size = new System.Drawing.Size(13, 15);
            this.labelDepartmentsCount.TabIndex = 3;
            this.labelDepartmentsCount.Text = "0";
            // 
            // labelManagers
            // 
            this.labelManagers.AutoSize = true;
            this.labelManagers.Location = new System.Drawing.Point(35, 51);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(65, 15);
            this.labelManagers.TabIndex = 2;
            this.labelManagers.Text = "Managers: ";
            // 
            // labelManagersCount
            // 
            this.labelManagersCount.AutoSize = true;
            this.labelManagersCount.Location = new System.Drawing.Point(119, 51);
            this.labelManagersCount.Name = "labelManagersCount";
            this.labelManagersCount.Size = new System.Drawing.Size(13, 15);
            this.labelManagersCount.TabIndex = 3;
            this.labelManagersCount.Text = "0";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(35, 78);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(57, 15);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products:";
            // 
            // labelProductsCount
            // 
            this.labelProductsCount.AutoSize = true;
            this.labelProductsCount.Location = new System.Drawing.Point(119, 78);
            this.labelProductsCount.Name = "labelProductsCount";
            this.labelProductsCount.Size = new System.Drawing.Size(13, 15);
            this.labelProductsCount.TabIndex = 3;
            this.labelProductsCount.Text = "0";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(35, 103);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(36, 15);
            this.labelSales.TabIndex = 2;
            this.labelSales.Text = "Sales:";
            // 
            // labelSalesCount
            // 
            this.labelSalesCount.AutoSize = true;
            this.labelSalesCount.Location = new System.Drawing.Point(119, 103);
            this.labelSalesCount.Name = "labelSalesCount";
            this.labelSalesCount.Size = new System.Drawing.Size(13, 15);
            this.labelSalesCount.TabIndex = 3;
            this.labelSalesCount.Text = "0";
            // 
            // buttonDepDetails
            // 
            this.buttonDepDetails.Location = new System.Drawing.Point(173, 22);
            this.buttonDepDetails.Name = "buttonDepDetails";
            this.buttonDepDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonDepDetails.TabIndex = 4;
            this.buttonDepDetails.Text = "Details";
            this.buttonDepDetails.UseVisualStyleBackColor = true;
            this.buttonDepDetails.Click += new System.EventHandler(this.buttonDepDetails_Click);
            // 
            // buttonCloudConnect
            // 
            this.buttonCloudConnect.Location = new System.Drawing.Point(180, 301);
            this.buttonCloudConnect.Name = "buttonCloudConnect";
            this.buttonCloudConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonCloudConnect.TabIndex = 5;
            this.buttonCloudConnect.Text = "Connect";
            this.buttonCloudConnect.UseVisualStyleBackColor = true;
            this.buttonCloudConnect.Click += new System.EventHandler(this.buttonCloudConnect_Click);
            // 
            // labelGoogleCloud
            // 
            this.labelGoogleCloud.AutoSize = true;
            this.labelGoogleCloud.Location = new System.Drawing.Point(35, 305);
            this.labelGoogleCloud.Name = "labelGoogleCloud";
            this.labelGoogleCloud.Size = new System.Drawing.Size(139, 15);
            this.labelGoogleCloud.TabIndex = 6;
            this.labelGoogleCloud.Text = "Google Cloud SQL Server";
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(173, 78);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonProducts.TabIndex = 4;
            this.buttonProducts.Text = "Details";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoogleCloud);
            this.Controls.Add(this.buttonCloudConnect);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonDepDetails);
            this.Controls.Add(this.labelSalesCount);
            this.Controls.Add(this.labelProductsCount);
            this.Controls.Add(this.labelManagersCount);
            this.Controls.Add(this.labelDepartmentsCount);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.labelDepartments);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label labelDepartments;
        private System.Windows.Forms.Label labelDepartmentsCount;
        private System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.Label labelManagersCount;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelProductsCount;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelSalesCount;
        private System.Windows.Forms.Button buttonDepDetails;
        private System.Windows.Forms.Button buttonCloudConnect;
        private System.Windows.Forms.Label labelGoogleCloud;
        private System.Windows.Forms.Button buttonProducts;
    }
}
