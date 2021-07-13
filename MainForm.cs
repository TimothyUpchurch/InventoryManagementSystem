using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        Inventory inv = new Inventory();
        public MainForm()
        {
            InitializeComponent();
            initgridViews();
        }     
        private void initgridViews()
        {           
            // removes unnecessary column
            partsGridView.RowHeadersVisible = false;
            productsGridView.RowHeadersVisible = false;

            // init binding source and data source          
            var partsBindingSource = new BindingSource(inv.AllParts, null);
            partsGridView.DataSource = partsBindingSource;

            var productsBindingSource = new BindingSource(inv.Products, null);
            productsGridView.DataSource = productsBindingSource;

            //clears auto-selected rows
            partsGridView.DataBindingComplete += gridView_DataBindingComplete;
            productsGridView.DataBindingComplete += gridView_DataBindingComplete;
        }
        // clears first auto-selected row after data binding is complete.
        private void gridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsGridView.ClearSelection();
            productsGridView.ClearSelection();
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            // Shows MainForm when closing another form.
            Show();
        }
        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // --------------partsGridView------------------
        private void addPartButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm(inv);         
            addPartForm.Show();
            Hide();
            addPartForm.FormClosing += formClosing;
        }
        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (partsGridView.SelectedRows.Count != 0)
                {
                    ModifyPartForm modifyPartForm = new ModifyPartForm(inv, (Part)partsGridView.SelectedRows[0].DataBoundItem);
                    modifyPartForm.Show();
                    Hide();
                    modifyPartForm.FormClosing += formClosing;
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
        private void deletePartButton_Click(object sender, EventArgs e)
        {       
            // add beter validation/exception handling here
            try
            {
                if (partsGridView.SelectedRows.Count != 0 )
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {

                        inv.deletePart((Part)partsGridView.SelectedRows[0].DataBoundItem);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a value.");
                }
            }
            catch(EvaluateException ex)
            {
                // exception other than trying to delete with nothing selected.
                MessageBox.Show(ex.Message);
            };
            
        }


        // --------------productsGridView------------------
        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(inv);
            addProductForm.Show();
            Hide();
            addProductForm.FormClosing += formClosing;
        }
        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsGridView.SelectedRows.Count != 0)
                {
                    ModifyProductForm modifyProductForm = new ModifyProductForm(inv, (Product)productsGridView.SelectedRows[0].DataBoundItem);
                    modifyProductForm.Show();
                    Hide();
                    modifyProductForm.FormClosing += formClosing;
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
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (productsGridView.SelectedRows.Count != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        var product = productsGridView.SelectedRows[0].DataBoundItem as Product;
                        if (product.AssociatedParts.Count > 0)
                        {
                            MessageBox.Show("Can not delete a product with associated parts.");
                        }
                        else
                        {
                            inv.removeProduct(product.ProductID);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a value.");
                }

            }
            catch (EvaluateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // --------------Search-Functions------------------
        // checks to see if part/product name contains the search field text.
        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            bool contains = false;
            if (partsGridView.Rows.Count > 0)
            {
                if(searchPartsText.Text.Length != 0)
                {
                    for (int i = 0; i < inv.AllParts.Count; i++)
                    {
                        if (inv.lookupPart(i).Name.Contains(searchPartsText.Text))
                        {                          
                            partsGridView.Rows[i].Selected = true;
                            contains = true;
                            break;
                        }
                        contains = false;
                        partsGridView.Rows[i].Selected = false;
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
                MessageBox.Show("No parts. Please add a part first.");
            }
            searchPartsText.Text = "";
        }
        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            bool contains = false;
            if (productsGridView.Rows.Count > 0)
            {
                if (searchProductsText.Text.Length != 0)
                {
                    for (int i = 0; i < inv.Products.Count; i++)
                    {
                        if (inv.lookupProduct(i).Name.Contains(searchProductsText.Text))
                        {
                            productsGridView.Rows[i].Selected = true;
                            contains = true;
                            break;
                        }
                        contains = false;
                        productsGridView.Rows[i].Selected = false;
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
                MessageBox.Show("No Products. Please add a product first.");
            }
            searchProductsText.Text = "";
        }
    }
}
