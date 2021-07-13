namespace InventoryManagementSystem
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.searchProductsText = new System.Windows.Forms.TextBox();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(314, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(25, 85);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Location = new System.Drawing.Point(271, 80);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartsButton.TabIndex = 2;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // searchPartsText
            // 
            this.searchPartsText.Location = new System.Drawing.Point(364, 83);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(184, 20);
            this.searchPartsText.TabIndex = 3;
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.AllowUserToResizeColumns = false;
            this.partsGridView.AllowUserToResizeRows = false;
            this.partsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(29, 122);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(519, 264);
            this.partsGridView.TabIndex = 4;
            this.partsGridView.TabStop = false;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(364, 420);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(57, 36);
            this.addPartButton.TabIndex = 5;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(428, 420);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(57, 36);
            this.modifyPartButton.TabIndex = 6;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(491, 420);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(57, 36);
            this.deletePartButton.TabIndex = 7;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1068, 420);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(57, 36);
            this.deleteProductButton.TabIndex = 14;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(1005, 420);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(57, 36);
            this.modifyProductButton.TabIndex = 13;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(941, 420);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(57, 36);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(606, 122);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(519, 264);
            this.productsGridView.TabIndex = 11;
            this.productsGridView.TabStop = false;
            // 
            // searchProductsText
            // 
            this.searchProductsText.Location = new System.Drawing.Point(941, 83);
            this.searchProductsText.Name = "searchProductsText";
            this.searchProductsText.Size = new System.Drawing.Size(184, 20);
            this.searchProductsText.TabIndex = 10;
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Location = new System.Drawing.Point(848, 80);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductsButton.TabIndex = 9;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(602, 85);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 8;
            this.productsLabel.Text = "Products";
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.Location = new System.Drawing.Point(1068, 500);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(57, 36);
            this.exitApplicationButton.TabIndex = 15;
            this.exitApplicationButton.Text = "Exit";
            this.exitApplicationButton.UseVisualStyleBackColor = true;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 564);
            this.Controls.Add(this.exitApplicationButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.searchProductsText);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.searchPartsText);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.TextBox searchPartsText;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.TextBox searchProductsText;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button exitApplicationButton;
    }
}

