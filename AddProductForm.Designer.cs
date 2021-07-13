namespace InventoryManagementSystem
{
    partial class AddProductForm
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.productIDText = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryText = new System.Windows.Forms.TextBox();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productMinText = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxText = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.allPartsGridView = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productCancelButton = new System.Windows.Forms.Button();
            this.productSaveButton = new System.Windows.Forms.Button();
            this.addAssociatedPart = new System.Windows.Forms.Button();
            this.associatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            this.searchPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(16, 25);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(82, 16);
            this.addPartLabel.TabIndex = 1;
            this.addPartLabel.Text = "Add Product";
            // 
            // productIDText
            // 
            this.productIDText.Enabled = false;
            this.productIDText.Location = new System.Drawing.Point(123, 253);
            this.productIDText.Name = "productIDText";
            this.productIDText.Size = new System.Drawing.Size(141, 20);
            this.productIDText.TabIndex = 6;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(39, 256);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(18, 13);
            this.productIDLabel.TabIndex = 5;
            this.productIDLabel.Text = "ID";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(123, 299);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(141, 20);
            this.productNameText.TabIndex = 12;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(39, 302);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(35, 13);
            this.productNameLabel.TabIndex = 11;
            this.productNameLabel.Text = "Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productInventoryText
            // 
            this.productInventoryText.Location = new System.Drawing.Point(123, 344);
            this.productInventoryText.Name = "productInventoryText";
            this.productInventoryText.Size = new System.Drawing.Size(141, 20);
            this.productInventoryText.TabIndex = 14;
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Location = new System.Drawing.Point(39, 347);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.productInventoryLabel.TabIndex = 13;
            this.productInventoryLabel.Text = "Inventory";
            this.productInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(123, 393);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(141, 20);
            this.productPriceText.TabIndex = 16;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(39, 396);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.productPriceLabel.TabIndex = 15;
            this.productPriceLabel.Text = "Price";
            this.productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productMinText
            // 
            this.productMinText.Location = new System.Drawing.Point(248, 439);
            this.productMinText.Name = "productMinText";
            this.productMinText.Size = new System.Drawing.Size(80, 20);
            this.productMinText.TabIndex = 20;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(200, 442);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(24, 13);
            this.productMinLabel.TabIndex = 19;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxText
            // 
            this.productMaxText.Location = new System.Drawing.Point(92, 439);
            this.productMaxText.Name = "productMaxText";
            this.productMaxText.Size = new System.Drawing.Size(81, 20);
            this.productMaxText.TabIndex = 18;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(39, 442);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.productMaxLabel.TabIndex = 17;
            this.productMaxLabel.Text = "Max";
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.AllowUserToAddRows = false;
            this.allPartsGridView.AllowUserToDeleteRows = false;
            this.allPartsGridView.AllowUserToResizeColumns = false;
            this.allPartsGridView.AllowUserToResizeRows = false;
            this.allPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(461, 91);
            this.allPartsGridView.MultiSelect = false;
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.ReadOnly = true;
            this.allPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsGridView.Size = new System.Drawing.Size(519, 228);
            this.allPartsGridView.TabIndex = 22;
            this.allPartsGridView.TabStop = false;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(457, 54);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(67, 20);
            this.partsLabel.TabIndex = 21;
            this.partsLabel.Text = "All Parts";
            // 
            // productCancelButton
            // 
            this.productCancelButton.Location = new System.Drawing.Point(921, 697);
            this.productCancelButton.Name = "productCancelButton";
            this.productCancelButton.Size = new System.Drawing.Size(59, 31);
            this.productCancelButton.TabIndex = 24;
            this.productCancelButton.Text = "Cancel";
            this.productCancelButton.UseVisualStyleBackColor = true;
            this.productCancelButton.Click += new System.EventHandler(this.productCancelButton_Click);
            // 
            // productSaveButton
            // 
            this.productSaveButton.Location = new System.Drawing.Point(844, 697);
            this.productSaveButton.Name = "productSaveButton";
            this.productSaveButton.Size = new System.Drawing.Size(59, 31);
            this.productSaveButton.TabIndex = 23;
            this.productSaveButton.Text = "Save";
            this.productSaveButton.UseVisualStyleBackColor = true;
            this.productSaveButton.Click += new System.EventHandler(this.productSaveButton_Click);
            // 
            // addAssociatedPart
            // 
            this.addAssociatedPart.Location = new System.Drawing.Point(921, 337);
            this.addAssociatedPart.Name = "addAssociatedPart";
            this.addAssociatedPart.Size = new System.Drawing.Size(59, 31);
            this.addAssociatedPart.TabIndex = 25;
            this.addAssociatedPart.Text = "Add";
            this.addAssociatedPart.UseVisualStyleBackColor = true;
            this.addAssociatedPart.Click += new System.EventHandler(this.addAssociatedPart_Click);
            // 
            // associatedPartsGridView
            // 
            this.associatedPartsGridView.AllowUserToAddRows = false;
            this.associatedPartsGridView.AllowUserToDeleteRows = false;
            this.associatedPartsGridView.AllowUserToResizeColumns = false;
            this.associatedPartsGridView.AllowUserToResizeRows = false;
            this.associatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridView.Location = new System.Drawing.Point(461, 398);
            this.associatedPartsGridView.MultiSelect = false;
            this.associatedPartsGridView.Name = "associatedPartsGridView";
            this.associatedPartsGridView.ReadOnly = true;
            this.associatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGridView.Size = new System.Drawing.Size(519, 228);
            this.associatedPartsGridView.TabIndex = 27;
            this.associatedPartsGridView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Parts Associated With This Product";
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(921, 643);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(59, 31);
            this.deleteAssociatedPartButton.TabIndex = 28;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.deleteAssociatedPartButton_Click);
            // 
            // searchPartsText
            // 
            this.searchPartsText.Location = new System.Drawing.Point(807, 51);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(173, 20);
            this.searchPartsText.TabIndex = 30;
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(712, 49);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 31;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 740);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.searchPartsText);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.associatedPartsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAssociatedPart);
            this.Controls.Add(this.productCancelButton);
            this.Controls.Add(this.productSaveButton);
            this.Controls.Add(this.allPartsGridView);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.productMinText);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productMaxText);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productPriceText);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryText);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productIDText);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.TextBox productIDText;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productInventoryText;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productMinText;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productMaxText;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.DataGridView allPartsGridView;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button productCancelButton;
        private System.Windows.Forms.Button productSaveButton;
        private System.Windows.Forms.Button addAssociatedPart;
        private System.Windows.Forms.DataGridView associatedPartsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.TextBox searchPartsText;
        private System.Windows.Forms.Button searchPart;
    }
}