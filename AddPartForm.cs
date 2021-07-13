using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddPartForm : Form
    {
        public Inventory invi;      
        public AddPartForm(Inventory inv)
        {
            InitializeComponent();
            invi = inv;
            fieldEventValidation();
        }
        private void fieldEventValidation()
        {
            //Events & Validation for form fields
            partNameText.TextChanged += (sender, e) => Validation.checkInt(partNameText);
            partNameText.VisibleChanged += (sender, e) => Validation.checkInt(partNameText);

            partInventoryText.TextChanged += (sender, e) => Validation.checkString(partInventoryText);
            partInventoryText.VisibleChanged += (sender, e) => Validation.checkString(partInventoryText);

            partPriceText.TextChanged += (sender, e) => Validation.checkDecimal(partPriceText);
            partPriceText.VisibleChanged += (sender, e) => Validation.checkDecimal(partPriceText);

            partMaxText.TextChanged += (sender, e) => Validation.checkString(partMaxText);
            partMaxText.VisibleChanged += (sender, e) => Validation.checkString(partMaxText);

            partMinText.TextChanged += (sender, e) => Validation.checkString(partMinText);
            partMinText.VisibleChanged += (sender, e) => Validation.checkString(partMinText);

            partDynamicText.TextChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, partDynamicText);
            partDynamicText.VisibleChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, partDynamicText);

            inHouseButton.CheckedChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, partDynamicText);
            outSourcedButton.CheckedChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, partDynamicText);
        }
        private void checkRadioInHouse(object sender, EventArgs e)
        {          
            //if checked show machine id and move position to align better with other labels
            partDynamicLabel.Text = "Machine ID";
            partDynamicLabel.Left = 56;
        }
        private void checkRadioOut(object sender, EventArgs e)
        {
            //if checked show company and move position to align better with other labels
            partDynamicLabel.Text = "Company Name";
            partDynamicLabel.Left = 35;
        }
        private void partSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all input fields are entered/valid - then create part
                if (Validation.allPartFieldsOccupied(partNameText, partInventoryText, partPriceText, partMaxText, partMinText, partDynamicText)
                    && Validation.allPartFieldsValid(partNameText, partInventoryText, partPriceText, partMaxText, partMinText, partDynamicText, inHouseButton, outSourcedButton, invi)
                    && Validation.createPart(partNameText.Text, Int32.Parse(partInventoryText.Text), decimal.Parse(partPriceText.Text), Int32.Parse(partMinText.Text), Int32.Parse(partMaxText.Text), partDynamicText, inHouseButton, outSourcedButton, invi))
                {
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Enter all values in the correct format.");
            }
        }
        private void partCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
