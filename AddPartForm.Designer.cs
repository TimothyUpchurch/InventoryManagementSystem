namespace InventoryManagementSystem
{
    partial class AddPartForm
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
            this.inHouseButton = new System.Windows.Forms.RadioButton();
            this.outSourcedButton = new System.Windows.Forms.RadioButton();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.partIDText = new System.Windows.Forms.TextBox();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partPriceLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partDynamicLabel = new System.Windows.Forms.Label();
            this.partNameText = new System.Windows.Forms.TextBox();
            this.partInventoryText = new System.Windows.Forms.TextBox();
            this.partPriceText = new System.Windows.Forms.TextBox();
            this.partMaxText = new System.Windows.Forms.TextBox();
            this.partMinText = new System.Windows.Forms.TextBox();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partDynamicText = new System.Windows.Forms.TextBox();
            this.partSaveButton = new System.Windows.Forms.Button();
            this.partCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 13);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(60, 16);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // inHouseButton
            // 
            this.inHouseButton.AutoSize = true;
            this.inHouseButton.Location = new System.Drawing.Point(102, 13);
            this.inHouseButton.Name = "inHouseButton";
            this.inHouseButton.Size = new System.Drawing.Size(68, 17);
            this.inHouseButton.TabIndex = 1;
            this.inHouseButton.TabStop = true;
            this.inHouseButton.Text = "In-House";
            this.inHouseButton.UseVisualStyleBackColor = true;
            this.inHouseButton.Enter += new System.EventHandler(this.checkRadioInHouse);
            // 
            // outSourcedButton
            // 
            this.outSourcedButton.AutoSize = true;
            this.outSourcedButton.Location = new System.Drawing.Point(192, 13);
            this.outSourcedButton.Name = "outSourcedButton";
            this.outSourcedButton.Size = new System.Drawing.Size(80, 17);
            this.outSourcedButton.TabIndex = 2;
            this.outSourcedButton.TabStop = true;
            this.outSourcedButton.Text = "Outsourced";
            this.outSourcedButton.UseVisualStyleBackColor = true;
            this.outSourcedButton.Enter += new System.EventHandler(this.checkRadioOut);
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(101, 68);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(18, 13);
            this.partIDLabel.TabIndex = 3;
            this.partIDLabel.Text = "ID";
            // 
            // partIDText
            // 
            this.partIDText.Enabled = false;
            this.partIDText.Location = new System.Drawing.Point(140, 65);
            this.partIDText.Name = "partIDText";
            this.partIDText.Size = new System.Drawing.Size(109, 20);
            this.partIDText.TabIndex = 4;
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Location = new System.Drawing.Point(84, 112);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(35, 13);
            this.partNameLabel.TabIndex = 5;
            this.partNameLabel.Text = "Name";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Location = new System.Drawing.Point(68, 155);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.partInventoryLabel.TabIndex = 6;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partPriceLabel
            // 
            this.partPriceLabel.AutoSize = true;
            this.partPriceLabel.Location = new System.Drawing.Point(56, 196);
            this.partPriceLabel.Name = "partPriceLabel";
            this.partPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.partPriceLabel.TabIndex = 7;
            this.partPriceLabel.Text = "Price / Cost";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Location = new System.Drawing.Point(92, 236);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.partMaxLabel.TabIndex = 8;
            this.partMaxLabel.Text = "Max";
            // 
            // partDynamicLabel
            // 
            this.partDynamicLabel.AutoSize = true;
            this.partDynamicLabel.Location = new System.Drawing.Point(56, 274);
            this.partDynamicLabel.Name = "partDynamicLabel";
            this.partDynamicLabel.Size = new System.Drawing.Size(62, 13);
            this.partDynamicLabel.TabIndex = 9;
            this.partDynamicLabel.Text = "Machine ID";
            // 
            // partNameText
            // 
            this.partNameText.Location = new System.Drawing.Point(140, 109);
            this.partNameText.Name = "partNameText";
            this.partNameText.Size = new System.Drawing.Size(109, 20);
            this.partNameText.TabIndex = 10;
            // 
            // partInventoryText
            // 
            this.partInventoryText.Location = new System.Drawing.Point(140, 152);
            this.partInventoryText.Name = "partInventoryText";
            this.partInventoryText.Size = new System.Drawing.Size(109, 20);
            this.partInventoryText.TabIndex = 11;
            // 
            // partPriceText
            // 
            this.partPriceText.Location = new System.Drawing.Point(140, 193);
            this.partPriceText.Name = "partPriceText";
            this.partPriceText.Size = new System.Drawing.Size(109, 20);
            this.partPriceText.TabIndex = 12;
            // 
            // partMaxText
            // 
            this.partMaxText.Location = new System.Drawing.Point(140, 233);
            this.partMaxText.Name = "partMaxText";
            this.partMaxText.Size = new System.Drawing.Size(60, 20);
            this.partMaxText.TabIndex = 13;
            // 
            // partMinText
            // 
            this.partMinText.Location = new System.Drawing.Point(268, 233);
            this.partMinText.Name = "partMinText";
            this.partMinText.Size = new System.Drawing.Size(60, 20);
            this.partMinText.TabIndex = 15;
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Location = new System.Drawing.Point(220, 236);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(24, 13);
            this.partMinLabel.TabIndex = 14;
            this.partMinLabel.Text = "Min";
            // 
            // partDynamicText
            // 
            this.partDynamicText.Location = new System.Drawing.Point(140, 271);
            this.partDynamicText.Name = "partDynamicText";
            this.partDynamicText.Size = new System.Drawing.Size(109, 20);
            this.partDynamicText.TabIndex = 16;
            // 
            // partSaveButton
            // 
            this.partSaveButton.Location = new System.Drawing.Point(192, 333);
            this.partSaveButton.Name = "partSaveButton";
            this.partSaveButton.Size = new System.Drawing.Size(59, 31);
            this.partSaveButton.TabIndex = 17;
            this.partSaveButton.Text = "Save";
            this.partSaveButton.UseVisualStyleBackColor = true;
            this.partSaveButton.Click += new System.EventHandler(this.partSaveButton_Click);
            // 
            // partCancelButton
            // 
            this.partCancelButton.Location = new System.Drawing.Point(269, 333);
            this.partCancelButton.Name = "partCancelButton";
            this.partCancelButton.Size = new System.Drawing.Size(59, 31);
            this.partCancelButton.TabIndex = 18;
            this.partCancelButton.Text = "Cancel";
            this.partCancelButton.UseVisualStyleBackColor = true;
            this.partCancelButton.Click += new System.EventHandler(this.partCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 395);
            this.Controls.Add(this.outSourcedButton);
            this.Controls.Add(this.inHouseButton);
            this.Controls.Add(this.partCancelButton);
            this.Controls.Add(this.partSaveButton);
            this.Controls.Add(this.partDynamicText);
            this.Controls.Add(this.partMinText);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.partMaxText);
            this.Controls.Add(this.partPriceText);
            this.Controls.Add(this.partInventoryText);
            this.Controls.Add(this.partNameText);
            this.Controls.Add(this.partDynamicLabel);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partPriceLabel);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIDText);
            this.Controls.Add(this.partIDLabel);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton inHouseButton;
        private System.Windows.Forms.RadioButton outSourcedButton;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.TextBox partIDText;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.Label partPriceLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partDynamicLabel;
        private System.Windows.Forms.TextBox partNameText;
        private System.Windows.Forms.TextBox partInventoryText;
        private System.Windows.Forms.TextBox partPriceText;
        private System.Windows.Forms.TextBox partMaxText;
        private System.Windows.Forms.TextBox partMinText;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.TextBox partDynamicText;
        private System.Windows.Forms.Button partSaveButton;
        private System.Windows.Forms.Button partCancelButton;
    }
}