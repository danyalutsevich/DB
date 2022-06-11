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
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCreatePrice = new System.Windows.Forms.TextBox();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(55, 87);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(206, 214);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "🠊";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 302);
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
            this.comboBoxOrderBy.Location = new System.Drawing.Point(140, 58);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrderBy.TabIndex = 3;
            this.comboBoxOrderBy.Text = "Name";
            this.comboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ORDER BY";
            // 
            // textBoxPerPage
            // 
            this.textBoxPerPage.Location = new System.Drawing.Point(136, 303);
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
            this.labelPage.Location = new System.Drawing.Point(167, 334);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(13, 15);
            this.labelPage.TabIndex = 6;
            this.labelPage.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Page: ";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(267, 58);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(27, 23);
            this.buttonOrder.TabIndex = 7;
            this.buttonOrder.Text = "🠋";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(53, 25);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(12, 15);
            this.labelProductID.TabIndex = 8;
            this.labelProductID.Text = "-";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(26, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(26, 118);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(160, 23);
            this.textBoxPrice.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(26, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 23);
            this.textBoxName.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(51, 147);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.buttonDelete);
            this.groupBoxUpdate.Controls.Add(this.textBoxName);
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.labelProductID);
            this.groupBoxUpdate.Controls.Add(this.labelID);
            this.groupBoxUpdate.Controls.Add(this.textBoxPrice);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Location = new System.Drawing.Point(294, 87);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(301, 214);
            this.groupBoxUpdate.TabIndex = 13;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(51, 176);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.buttonCreate);
            this.groupBoxCreate.Controls.Add(this.textBoxCreateName);
            this.groupBoxCreate.Controls.Add(this.label2);
            this.groupBoxCreate.Controls.Add(this.label4);
            this.groupBoxCreate.Controls.Add(this.textBoxCreatePrice);
            this.groupBoxCreate.Location = new System.Drawing.Point(601, 87);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(187, 214);
            this.groupBoxCreate.TabIndex = 14;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(91, 121);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Location = new System.Drawing.Point(6, 44);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(160, 23);
            this.textBoxCreateName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // textBoxCreatePrice
            // 
            this.textBoxCreatePrice.Location = new System.Drawing.Point(6, 92);
            this.textBoxCreatePrice.Name = "textBoxCreatePrice";
            this.textBoxCreatePrice.Size = new System.Drawing.Size(160, 23);
            this.textBoxCreatePrice.TabIndex = 11;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.groupBoxUpdate);
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
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
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
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCreatePrice;
    }
}