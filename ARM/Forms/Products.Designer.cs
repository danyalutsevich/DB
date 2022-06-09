namespace ARM.Forms
{
    partial class Products
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPerPage = new System.Windows.Forms.TextBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(45, 45);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(206, 214);
            this.listBoxProducts.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "🠊";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "🠈";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(130, 16);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrderBy.TabIndex = 3;
            this.comboBoxOrderBy.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ORDER BY";
            // 
            // textBoxPerPage
            // 
            this.textBoxPerPage.Location = new System.Drawing.Point(126, 261);
            this.textBoxPerPage.Name = "textBoxPerPage";
            this.textBoxPerPage.Size = new System.Drawing.Size(44, 23);
            this.textBoxPerPage.TabIndex = 5;
            this.textBoxPerPage.Text = "5";
            this.textBoxPerPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPerPage.TextChanged += new System.EventHandler(this.textBoxPerPage_TextChanged);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(157, 292);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(13, 15);
            this.labelPage.TabIndex = 6;
            this.labelPage.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Page: ";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(257, 16);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(27, 23);
            this.buttonOrder.TabIndex = 7;
            this.buttonOrder.Text = "🠋";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.textBoxPerPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPerPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOrder;
    }
}