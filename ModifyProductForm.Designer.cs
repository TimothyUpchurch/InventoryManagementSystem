namespace InventoryManagementSystem
{
    partial class ModifyProductForm
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
            this.modifyDeleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.associatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyAddAssociatedPart = new System.Windows.Forms.Button();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.allPartsGridView = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productMinText = new System.Windows.Forms.TextBox();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxText = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productInventoryText = new System.Windows.Forms.TextBox();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDText = new System.Windows.Forms.TextBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.addPartLabel = new System.Windows.Forms.Label();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyDeleteAssociatedPartButton
            // 
            this.modifyDeleteAssociatedPartButton.Location = new System.Drawing.Point(936, 637);
            this.modifyDeleteAssociatedPartButton.Name = "modifyDeleteAssociatedPartButton";
            this.modifyDeleteAssociatedPartButton.Size = new System.Drawing.Size(59, 31);
            this.modifyDeleteAssociatedPartButton.TabIndex = 49;
            this.modifyDeleteAssociatedPartButton.Text = "Delete";
            this.modifyDeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.modifyDeleteAssociatedPartButton.Click += new System.EventHandler(this.modifyDeleteAssociatedPartButton_Click);
            // 
            // associatedPartsGridView
            // 
            this.associatedPartsGridView.AllowUserToAddRows = false;
            this.associatedPartsGridView.AllowUserToDeleteRows = false;
            this.associatedPartsGridView.AllowUserToResizeColumns = false;
            this.associatedPartsGridView.AllowUserToResizeRows = false;
            this.associatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridView.Location = new System.Drawing.Point(476, 392);
            this.associatedPartsGridView.MultiSelect = false;
            this.associatedPartsGridView.Name = "associatedPartsGridView";
            this.associatedPartsGridView.ReadOnly = true;
            this.associatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGridView.Size = new System.Drawing.Size(519, 228);
            this.associatedPartsGridView.TabIndex = 48;
            this.associatedPartsGridView.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Parts Associated With This Product";
            // 
            // modifyAddAssociatedPart
            // 
            this.modifyAddAssociatedPart.Location = new System.Drawing.Point(936, 331);
            this.modifyAddAssociatedPart.Name = "modifyAddAssociatedPart";
            this.modifyAddAssociatedPart.Size = new System.Drawing.Size(59, 31);
            this.modifyAddAssociatedPart.TabIndex = 46;
            this.modifyAddAssociatedPart.Text = "Add";
            this.modifyAddAssociatedPart.UseVisualStyleBackColor = true;
            this.modifyAddAssociatedPart.Click += new System.EventHandler(this.modifyAddAssociatedPart_Click);
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(936, 691);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(59, 31);
            this.modifyProductCancelButton.TabIndex = 45;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.modifyProductCancelButton_Click);
            // 
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(859, 691);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(59, 31);
            this.modifyProductSaveButton.TabIndex = 44;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.modifyProductSaveButton_Click);
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.AllowUserToAddRows = false;
            this.allPartsGridView.AllowUserToDeleteRows = false;
            this.allPartsGridView.AllowUserToResizeColumns = false;
            this.allPartsGridView.AllowUserToResizeRows = false;
            this.allPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(476, 85);
            this.allPartsGridView.MultiSelect = false;
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.ReadOnly = true;
            this.allPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsGridView.Size = new System.Drawing.Size(519, 228);
            this.allPartsGridView.TabIndex = 43;
            this.allPartsGridView.TabStop = false;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(472, 48);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(67, 20);
            this.partsLabel.TabIndex = 42;
            this.partsLabel.Text = "All Parts";
            // 
            // productMinText
            // 
            this.productMinText.Location = new System.Drawing.Point(263, 433);
            this.productMinText.Name = "productMinText";
            this.productMinText.Size = new System.Drawing.Size(80, 20);
            this.productMinText.TabIndex = 41;
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(215, 436);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(24, 13);
            this.productMinLabel.TabIndex = 40;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxText
            // 
            this.productMaxText.Location = new System.Drawing.Point(107, 433);
            this.productMaxText.Name = "productMaxText";
            this.productMaxText.Size = new System.Drawing.Size(81, 20);
            this.productMaxText.TabIndex = 39;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(54, 436);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.productMaxLabel.TabIndex = 38;
            this.productMaxLabel.Text = "Max";
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(138, 387);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(141, 20);
            this.productPriceText.TabIndex = 37;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(54, 390);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.productPriceLabel.TabIndex = 36;
            this.productPriceLabel.Text = "Price";
            this.productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productInventoryText
            // 
            this.productInventoryText.Location = new System.Drawing.Point(138, 338);
            this.productInventoryText.Name = "productInventoryText";
            this.productInventoryText.Size = new System.Drawing.Size(141, 20);
            this.productInventoryText.TabIndex = 35;
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Location = new System.Drawing.Point(54, 341);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.productInventoryLabel.TabIndex = 34;
            this.productInventoryLabel.Text = "Inventory";
            this.productInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(138, 293);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(141, 20);
            this.productNameText.TabIndex = 33;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(54, 296);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(35, 13);
            this.productNameLabel.TabIndex = 32;
            this.productNameLabel.Text = "Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productIDText
            // 
            this.productIDText.Enabled = false;
            this.productIDText.Location = new System.Drawing.Point(138, 247);
            this.productIDText.Name = "productIDText";
            this.productIDText.Size = new System.Drawing.Size(141, 20);
            this.productIDText.TabIndex = 31;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(54, 250);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(18, 13);
            this.productIDLabel.TabIndex = 30;
            this.productIDLabel.Text = "ID";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(31, 19);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(97, 16);
            this.addPartLabel.TabIndex = 29;
            this.addPartLabel.Text = "Modify Product";
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(727, 46);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 51;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchPartsText
            // 
            this.searchPartsText.Location = new System.Drawing.Point(822, 48);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(173, 20);
            this.searchPartsText.TabIndex = 50;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 738);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.searchPartsText);
            this.Controls.Add(this.modifyDeleteAssociatedPartButton);
            this.Controls.Add(this.associatedPartsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modifyAddAssociatedPart);
            this.Controls.Add(this.modifyProductCancelButton);
            this.Controls.Add(this.modifyProductSaveButton);
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
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyDeleteAssociatedPartButton;
        private System.Windows.Forms.DataGridView associatedPartsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyAddAssociatedPart;
        private System.Windows.Forms.Button modifyProductCancelButton;
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.DataGridView allPartsGridView;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox productMinText;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.TextBox productMaxText;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productInventoryText;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productIDText;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.TextBox searchPartsText;
    }
}