using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPartForm : Form
    {
        public Inventory invi;
        public ModifyPartForm(Inventory inv, Part part)
        {
            InitializeComponent();
            initForm(inv, part);
            fieldEventValidation();
        }
        private void initForm(Inventory inv, Part part)
        {
            invi = inv;
            Inhouse inhouse = part as Inhouse;
            Outsourced outSourced = part as Outsourced;

            //Sets fields to values from the part selected.
            modifyIDText.Text = part.PartId.ToString();
            modifyNameText.Text = part.Name.ToString();
            modifyInventoryText.Text = part.InStock.ToString();
            modifyPriceText.Text = part.Price.ToString();
            modifyMaxText.Text = part.Max.ToString();
            modifyMinText.Text = part.Min.ToString();

            //Checks which subclass is being passed - sets text field and checkbox accordingly.
            if (part.GetType().ToString() == "InventoryManagementSystem.Inhouse")
            {
                modifyDynamicText.Text = inhouse.MachineID.ToString();
                inHouseButton.Checked = true;
            }
            else
            {
                modifyDynamicText.Text = outSourced.CompanyName.ToString();
                outSourcedButton.Checked = true;
            }
        }
        private void fieldEventValidation()
        {
            //Events & Validation for form fields
            modifyNameText.TextChanged += (sender, e) => Validation.checkInt(modifyNameText);
            modifyNameText.VisibleChanged += (sender, e) => Validation.checkInt(modifyNameText);

            modifyInventoryText.TextChanged += (sender, e) => Validation.checkString(modifyInventoryText);
            modifyInventoryText.VisibleChanged += (sender, e) => Validation.checkString(modifyInventoryText);

            modifyPriceText.TextChanged += (sender, e) => Validation.checkDecimal(modifyPriceText);
            modifyPriceText.VisibleChanged += (sender, e) => Validation.checkDecimal(modifyPriceText);

            modifyMinText.TextChanged += (sender, e) => Validation.checkString(modifyMinText);
            modifyMinText.VisibleChanged += (sender, e) => Validation.checkString(modifyMinText);

            modifyMaxText.TextChanged += (sender, e) => Validation.checkString(modifyMaxText);
            modifyMaxText.VisibleChanged += (sender, e) => Validation.checkString(modifyMaxText);

            modifyDynamicText.TextChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, modifyDynamicText);
            modifyDynamicText.VisibleChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, modifyDynamicText);


            inHouseButton.CheckedChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, modifyDynamicText);
            outSourcedButton.CheckedChanged += (sender, e) => Validation.validateDynamicField(sender, e, inHouseButton, outSourcedButton, modifyDynamicText);
        }
        private void modifySaveButton_Click(object sender, EventArgs e)
        {
            try
            {              
                if (Validation.allPartFieldsOccupied(modifyNameText, modifyInventoryText, modifyPriceText, modifyMaxText, modifyMinText, modifyDynamicText))
                {
                    if (Validation.allPartFieldsValid(modifyNameText, modifyInventoryText, modifyPriceText, modifyMaxText, modifyMinText, modifyDynamicText, inHouseButton, outSourcedButton, invi))
                    {
                        if (Validation.updatePart(Int32.Parse(modifyIDText.Text),modifyNameText.Text, Int32.Parse(modifyInventoryText.Text), decimal.Parse(modifyPriceText.Text), Int32.Parse(modifyMinText.Text), Int32.Parse(modifyMaxText.Text), modifyDynamicText, inHouseButton, outSourcedButton, invi))
                        {
                            //if all fields are occupied/valid and update is successful -- update part and go back to main form.
                            Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter all values in the correct format.");
            }
        }
        private void modifyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Radio button events
        private void checkRadioInHouse(object sender, EventArgs e)
        {
            //if checked show machine id and move position to align better with other labels
            modifyDynamicLabel.Text = "Machine ID";
            modifyDynamicLabel.Left = 56;
        }
        private void checkRadioOut(object sender, EventArgs e)
        {
            //if checked show company and move position to align better with other labels
            modifyDynamicLabel.Text = "Company Name";
            modifyDynamicLabel.Left = 35;
        }
    }
}