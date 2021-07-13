using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    static class Validation
    {
        // check input on form fields.
        public static void checkInt(TextBox text)
        {
            bool check = text.ToString().Any(char.IsDigit);
            bool checkEmpty = text.Text == "";
            if (check || checkEmpty)
            {
                text.Focus();
                text.BackColor = Color.Red;
            }
            else
            {
                text.BackColor = Color.White;
            }
        }
        public static void checkString(TextBox text)
        {
            if (int.TryParse(text.Text, out int num) && num >= 0)
            {
                text.Focus();
                text.BackColor = Color.White;
            }
            else
            {
                text.BackColor = Color.Red;
            }
        }
        public static void checkDecimal(TextBox text)
        {
            if (decimal.TryParse(text.Text, out decimal num))
            {
                text.Focus();
                text.BackColor = Color.White;
            }
            else
            {
                text.BackColor = Color.Red;
            }
        }
        public static void validateDynamicField(object sender, EventArgs e, RadioButton inHouse, RadioButton outSourced, TextBox text)
        {
            if (inHouse.Checked)
            {
                checkString(text);
            }
            else if (outSourced.Checked)
            {
                checkInt(text);
            }
        }

        //validation for add/modify parts
        public static bool allPartFieldsOccupied(TextBox name, TextBox inventory, TextBox price, TextBox max, TextBox min, TextBox dynamicText)
        {
            try
            {
                if (name.Text != "" && inventory.Text != "" && price.Text != "" && max.Text != "" && min.Text != "" && dynamicText.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a value in to each field.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool allPartFieldsValid(TextBox name, TextBox inventory, TextBox price, TextBox max, TextBox min, TextBox dynamicText, RadioButton inHouse, RadioButton outSourced, Inventory invi)
        {
            //grab all input from form and assign to part variables         
            string Name = name.Text.ToString();
            int InStock = Int32.Parse(inventory.Text.ToString());
            decimal Price = decimal.Parse(price.Text.ToString());
            int Min = Int32.Parse(min.Text.ToString());
            int Max = Int32.Parse(max.Text.ToString());

            if (!checkMinMax(Min, Max))
            {
                return false;
            }

            if (!inStockBetweenMinMax(Min, Max, InStock))
            {
                return false;
            }

            if (Name.GetType() == typeof(string) && !Name.Any(char.IsDigit) && InStock.GetType() == typeof(int) && Price.GetType() == typeof(decimal) && Min.GetType() == typeof(int) && Max.GetType() == typeof(int))
            {
                if (Min <= Max )
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Your minimum exceeds your maximum");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Enter all values in the correct format.");
                return false;
            }
        }
        public static bool createPart(string name, int inStock, decimal price, int min, int max, TextBox dynamicText, RadioButton inHouse, RadioButton outSourced, Inventory invi)
        {
            //Checks which radio button is selected. Creates part accordingly
            try
            {
                if (inHouse.Checked && !dynamicText.Text.Any(char.IsLetter))
                {
                    //Creates in-house object
                    int MachineID = Int32.Parse(dynamicText.Text.ToString());
                    invi.addPart(new Inhouse(name, inStock, price, min, max, MachineID));
                    return true;
                }
                else if (outSourced.Checked && !dynamicText.Text.Any(char.IsDigit))
                {
                    string companyName = dynamicText.Text.ToString();
                    invi.addPart(new Outsourced(name, inStock, price, min, max, companyName));
                    return true;
                }
                if (inHouse.Checked)
                {
                    MessageBox.Show("MachineID requires a number.");
                }
                else if (outSourced.Checked)
                {
                    MessageBox.Show("Company Name requires a string.");
                }
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool updatePart(int id, string name, int inStock, decimal price, int min, int max, TextBox dynamicText, RadioButton inHouse, RadioButton outSourced, Inventory invi)
        {
            //Checks which radio button is selected. Updates part accordingly
            try
            {
                if (inHouse.Checked && !dynamicText.Text.Any(char.IsLetter))
                {
                    //Creates in-house object
                    int MachineID = Int32.Parse(dynamicText.Text.ToString());
                    invi.updatePart(id, new Inhouse(name, inStock, price, min, max, MachineID));
                    return true;
                }
                else if (outSourced.Checked && !dynamicText.Text.Any(char.IsDigit))
                {
                    string companyName = dynamicText.Text.ToString();
                    invi.updatePart(id, new Outsourced(name, inStock, price, min, max, companyName));
                    return true;
                }
                if (inHouse.Checked)
                {
                    MessageBox.Show("MachineID requires a number.");                   
                }
                else if (outSourced.Checked)
                {
                    MessageBox.Show("Company Name requires a string.");                   
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Validations for add/modify products
        public static bool allProductFieldsOccupied(TextBox name, TextBox inventory, TextBox price, TextBox max, TextBox min)
        {
            try
            {
                if (name.Text != "" && inventory.Text != "" && price.Text != "" && max.Text != "" && min.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a value in to each field.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool allProductFieldsValid(TextBox name, TextBox inventory, TextBox price, TextBox max, TextBox min)
        {
            string Name = name.Text.ToString();
            int InStock = Int32.Parse(inventory.Text);
            decimal Price = Decimal.Parse(price.Text);
            int Min = Int32.Parse(min.Text);
            int Max = Int32.Parse(max.Text);

            if (!checkMinMax(Min, Max))
            {
                return false;
            }

            if (!inStockBetweenMinMax(Min, Max, InStock))
            {
                return false;
            }

            if (Name.GetType() == typeof(string) && !Name.Any(char.IsDigit) && InStock.GetType() == typeof(int) && Price.GetType() == typeof(decimal) && Min.GetType() == typeof(int) && Max.GetType() == typeof(int))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Enter all values in the correct format.");
                return false;
            }
        }
        // min - max
        public static bool checkMinMax(int min, int max)
        {
            if (min <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your minimum exceeds your maximum");
            }
            return false;
        }
        // InStock inbetween min && max
        public static bool inStockBetweenMinMax(int min, int max, int inStock)
        {
            if (inStock >= min && inStock <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Inventory must be between min and max.");
            }
            return false;
        }
    }
}