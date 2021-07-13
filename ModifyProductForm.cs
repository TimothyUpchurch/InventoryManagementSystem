using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyProductForm : Form
    {
        Inventory invi = new Inventory();
        Product prod = new Product();
        BindingList<Part> initialParts = new BindingList<Part>();
        public ModifyProductForm(Inventory inv, Product product)
        {
            InitializeComponent();
            initForm(inv, product);
            fieldEventValidation();
        }
        private void initForm(Inventory inv, Product product)
        {
            invi = inv;
            prod = product;

            //set initial parts list for the product so when the user cancels the unmodified list will appear.
            foreach(Part part in prod.AssociatedParts)
            {
                initialParts.Add(part);
            }

            // Set fields to product values
            productIDText.Text = product.ProductID.ToString();
            productNameText.Text = product.Name;
            productInventoryText.Text = product.InStock.ToString();
            productPriceText.Text = product.Price.ToString();
            productMaxText.Text = product.Max.ToString();
            productMinText.Text = product.Min.ToString();

            // init dataGridViews
            var partsBindingSource = new BindingSource(inv.AllParts, null);
            allPartsGridView.DataSource = partsBindingSource;
            var associatedPartsBindingSource = new BindingSource(product.AssociatedParts, null);
            associatedPartsGridView.DataSource = associatedPartsBindingSource;

            // removes unnecessary column                
            allPartsGridView.RowHeadersVisible = false;
            associatedPartsGridView.RowHeadersVisible = false;

            //clears auto select on first row
            allPartsGridView.DataBindingComplete += gridView_DataBindingComplete;
            associatedPartsGridView.DataBindingComplete += gridView_DataBindingComplete;
        }
        private void gridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears auto select on first row
            allPartsGridView.ClearSelection();
            associatedPartsGridView.ClearSelection();
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

        // Add & Delete associated part
        private void modifyAddAssociatedPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (allPartsGridView.Rows.Count > 0 && allPartsGridView.SelectedRows.Count != 0)
                {
                    prod.addAssociatedPart(allPartsGridView.SelectedRows[0].DataBoundItem as Part);
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
        private void modifyDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (associatedPartsGridView.SelectedRows.Count != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        var part = associatedPartsGridView.SelectedRows[0].DataBoundItem as Part;
                        prod.removeAssociatedPart(part.PartId);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a value.");
                }
            }
            catch (EvaluateException ex)
            {
                // exception other than trying to delete with nothing selected.
                MessageBox.Show(ex.Message);
            };
        }
        // Save product
        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod.AssociatedParts.Count != 0)
                {
                    if (Validation.allProductFieldsOccupied(productNameText, productInventoryText, productPriceText, productMaxText, productMinText) && Validation.allProductFieldsValid(productNameText, productInventoryText, productPriceText, productMaxText, productMinText))
                    {
                        //if all fields are occupied and valid -- update product and return to main form.
                        invi.updateProduct(prod.ProductID, new Product(prod.AssociatedParts, productNameText.Text, decimal.Parse(productPriceText.Text), Int32.Parse(productInventoryText.Text), Int32.Parse(productMinText.Text), Int32.Parse(productMaxText.Text)));
                        // After product is updated go back to main screen.  
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Products must have associated parts.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            //sets associatedparts back to unmodified parts list.
            prod.AssociatedParts = initialParts;
            Close();
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