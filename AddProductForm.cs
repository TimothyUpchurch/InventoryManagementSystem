using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddProductForm : Form
    {
        Product newProduct = new Product();
        public Inventory invi;
        public AddProductForm(Inventory inv)
        {
            InitializeComponent();
            initGridViews();
            fieldEventValidation();

            //Add bindingsources/datasources
            var partsBindingSource = new BindingSource(inv.AllParts, null);
            allPartsGridView.DataSource = partsBindingSource;

            var associatedPartsBindingSource = new BindingSource(newProduct.AssociatedParts, null);
            associatedPartsGridView.DataSource = associatedPartsBindingSource;

            invi = inv;           
        }
        private void initGridViews()
        {   // removes unnecessary column                
            allPartsGridView.RowHeadersVisible = false;
            associatedPartsGridView.RowHeadersVisible = false;
            //clears auto select on first row
            allPartsGridView.DataBindingComplete += gridView_DataBindingComplete;
            associatedPartsGridView.DataBindingComplete += gridView_DataBindingComplete;
        }
        private void fieldEventValidation()
        {
            //Events & Validation for form fields
            productNameText.TextChanged += (sender, e) => Validation.checkInt(productNameText);
            productNameText.VisibleChanged += (sender, e) => Validation.checkInt(productNameText);

            productInventoryText.TextChanged += (sender, e) => Validation.checkString(productInventoryText);
            productInventoryText.VisibleChanged += (sender, e) => Validation.checkString(productInventoryText);

            productPriceText.TextChanged += (sender, e) => Validation.checkDecimal(productPriceText);
            productPriceText.VisibleChanged += (sender, e) => Validation.checkDecimal(productPriceText);

            productMinText.TextChanged += (sender, e) => Validation.checkString(productMinText);
            productMinText.VisibleChanged += (sender, e) => Validation.checkString(productMinText);

            productMaxText.TextChanged += (sender, e) => Validation.checkString(productMaxText);
            productMaxText.VisibleChanged += (sender, e) => Validation.checkString(productMaxText);
        }
        private void gridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears auto select on first row
            allPartsGridView.ClearSelection();
            associatedPartsGridView.ClearSelection();
        }

        // Add - Delete - Cancel - Save -- associated part
        private void addAssociatedPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (allPartsGridView.Rows.Count > 0 && allPartsGridView.SelectedRows.Count != 0)
                {
                    newProduct.addAssociatedPart(allPartsGridView.SelectedRows[0].DataBoundItem as Part);
                }
                else
                {
                    MessageBox.Show("Please select a part.");
                }
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (associatedPartsGridView.SelectedRows.Count != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        var part = associatedPartsGridView.SelectedRows[0].DataBoundItem as Part;
                        newProduct.removeAssociatedPart(part.PartId);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a value.");
                }
            }
            catch (EvaluateException ex)
            {
                // Exception other than trying to delete with nothing selected.
                MessageBox.Show(ex.Message);
            };
        }
        private void productCancelButton_Click(object sender, EventArgs e)
        {
            // Close out form.
            Close();
        }
        private void productSaveButton_Click(object sender, EventArgs e)
        {           
            try
            {
                if (newProduct.AssociatedParts.Count != 0)
                {
                    if (Validation.allProductFieldsOccupied(productNameText, productInventoryText, productPriceText, productMaxText, productMinText) && Validation.allProductFieldsValid(productNameText, productInventoryText, productPriceText, productMaxText, productMinText))
                    {
                        Product product = new Product(newProduct.AssociatedParts, productNameText.Text, decimal.Parse(productPriceText.Text), Int32.Parse(productInventoryText.Text), Int32.Parse(productMinText.Text), Int32.Parse(productMaxText.Text));
                        invi.addProduct(product);
                        // After product is added go back to main screen.  
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Products must have associated parts.");
                }
            }
            catch
            {
                MessageBox.Show("Enter all values in the correct format.");
            }
        }
        private void searchPart_Click(object sender, EventArgs e)
        {
            bool contains = false;
            if (allPartsGridView.Rows.Count > 0)
            {
                if (searchPartsText.Text.Length != 0)
                {
                    for (int i = 0; i < invi.AllParts.Count; i++)
                    {                      
                        if (invi.lookupPart(i).Name.Contains(searchPartsText.Text))
                        {
                            allPartsGridView.Rows[i].Selected = true;
                            contains = true;
                            break;
                        }
                        contains = false;
                        allPartsGridView.Rows[i].Selected = false;
                    }
                    if (!contains)
                    {
                        MessageBox.Show("No results found. Try Another Search!");
                    };
                }
                else
                {
                    MessageBox.Show("Please add text.");
                }
            }
            else
            {
                MessageBox.Show("No associated parts. Please add a part first.");
            }
            searchPartsText.Text = "";
        }
    }
}