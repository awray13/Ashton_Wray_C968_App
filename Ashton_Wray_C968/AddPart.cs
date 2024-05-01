using System;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class AddPartForm : Form
    {
        //TODO: Constants for max values allowed: Tested and working.
        // Define max values for all the text baxes
        private const int MAX_INVENTORY = 999999999;
        private const int MAX_MIN = 1;
        private const int MAX_MAX = 999999999;
        private const int MAX_MACHINE_ID = 999999999;
        private const decimal MAX_PRICE = 999999999.99m;


        public AddPartForm()
        {
            InitializeComponent();

            // Set the PartId text box to the auto-generated value
            addPartIdTextBox.Text = Inventory.CalculatePartId() + "";

        }

        // Save button click event
        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            // Auto-generate PartId with Inventory.CalculatePartId() method
            addPartIdTextBox.Text = Inventory.CalculatePartId() + "";


            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(addPartNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addPartInventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(addPartPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(addPartMinTextBox.Text) ||
                string.IsNullOrWhiteSpace(addPartMaxTextBox.Text) ||
                string.IsNullOrWhiteSpace(addPartMacIdCompNameTextBox.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if In-House radio button is selected
            if (addPartInHouseRadioButton.Checked)
            {
                //TODO: InHouse Inventory Validation: Check if Inventory is between Min and Max: Tested and working.
                // Check if Inventory is a valid integer and within the maximum range
                if (!int.TryParse(addPartInventoryTextBox.Text, out int inventory) || inventory < 0 || inventory > MAX_INVENTORY)
                {
                    MessageBox.Show("Inventory cannot exceed " + MAX_INVENTORY.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Max is within the maximum range
                if (!int.TryParse(addPartMaxTextBox.Text, out int max) || max > MAX_MAX)
                {
                    string errorMessage = "Maximum cannot exceed " + MAX_MAX.ToString();
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check to see if Min is less than Max
                if (!int.TryParse(addPartMinTextBox.Text, out int min) || min > max)
                {
                    string errorMessage = "Your minimum exceeds your maximum. Please try again.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TODO: check to see if inventory is between min and max - needs to be tested
                // Check if inventory is greater than Max or less than Min
                if (inventory > int.Parse(addPartMaxTextBox.Text) || inventory < int.Parse(addPartMinTextBox.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than Max or less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Price is a valid decimal and within the maximum range
                // TODO: Price Validation: Tested and working.
                if (!decimal.TryParse(addPartPriceTextBox.Text, out decimal price) || price < 0 || price > MAX_PRICE)
                {
                    MessageBox.Show("Price cannot exceed " + MAX_PRICE.ToString("C") + " and must be a valid decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Machine ID is a valid integer and within the maximum range
                if (!int.TryParse(addPartMacIdCompNameTextBox.Text, out int machineId) || machineId < 0 || machineId > MAX_MACHINE_ID)
                {
                    MessageBox.Show("Machine ID cannot exceed " + MAX_MACHINE_ID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new InHouse part object and add it to the Inventory BindingLists
                Inventory.AddPart(new InHouse(
                    Inventory.CalculatePartId(),
                    addPartNameTextBox.Text,
                    Convert.ToDecimal(addPartPriceTextBox.Text, System.Globalization.CultureInfo.CurrentCulture),
                    Convert.ToInt32(addPartInventoryTextBox.Text),
                    Convert.ToInt32(addPartMinTextBox.Text),
                    Convert.ToInt32(addPartMaxTextBox.Text),
                    Convert.ToInt32(addPartMacIdCompNameTextBox.Text)
                    ));

                // Close the AddPartForms
                this.Close();
            }
            // else if Outsourced radio button is selected
            else
            {
                // Check if Inventory is between Min and Max and within the maximum range
                // TODO: Outsource Inventory Validation: Tested and working.
                if (!int.TryParse(addPartInventoryTextBox.Text, out int inventory) || inventory < 0 || inventory > MAX_INVENTORY)
                {
                    MessageBox.Show("Inventory cannot exceed " + MAX_INVENTORY.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Max is within the maximum range
                if (!int.TryParse(addPartMaxTextBox.Text, out int max) || max > MAX_MAX)
                {
                    string errorMessage = "Maximum cannot exceed " + MAX_MAX.ToString();
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Min is less than Max and within the maximum range
                if (!int.TryParse(addPartMinTextBox.Text, out int min) || !int.TryParse(addPartMaxTextBox.Text, out int max2) || min > max2)
                {
                    string errorMessage = "Your minimum exceeds your maximum. Please try again.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if inventory is greater than Max or less than Min
                if (inventory > int.Parse(addPartMaxTextBox.Text) || inventory < int.Parse(addPartMinTextBox.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than Max or less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Price is a valid decimal and within the maximum range
                if (!decimal.TryParse(addPartPriceTextBox.Text, out decimal price) || price > MAX_PRICE)
                {
                    MessageBox.Show("Price cannot exceed " + MAX_PRICE.ToString("C"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //TODO: Company Name Character Validation: Tested and working.
                // Check if Company Name only contains letters and spaces
                foreach (char c in addPartMacIdCompNameTextBox.Text)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        MessageBox.Show("Company Name must only contain letters and spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Create a new Outsourced object and add it to the Inventory BindingLists
                Inventory.AddPart(new Outsourced(
                    Inventory.CalculatePartId(),
                    addPartNameTextBox.Text,
                    Convert.ToDecimal(addPartPriceTextBox.Text),
                    Convert.ToInt32(addPartInventoryTextBox.Text),
                    Convert.ToInt32(addPartMinTextBox.Text),
                    Convert.ToInt32(addPartMaxTextBox.Text),
                    addPartMacIdCompNameTextBox.Text
                    ));
                addPartOutsourcedRadioButton.Checked = true;

                // Close the AddPartForms
                this.Close();
            }
        }

        // Cancel button click event
        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            // Close the AddPartForm
            this.Close();
        }

        // In-House radio button checked changed event
        private void AddPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set label text to "Machine ID" when In-House radio button is selected
            addPartMacIdCompNameLabel.Text = "Machine ID";
        }

        // Outsourced radio button checked changed event
        private void AddPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Set label text to "Company Name" when Outsourced radio button is selected
            addPartMacIdCompNameLabel.Text = "Company Name";
        }

        // This method is used to validate the inventory text box is a number
        private void AddPartInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the price text box is a decimal
        private void AddPartPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number, the backspace key, or a decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the max text box is a number
        private void AddPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the min text box is a number
        private void AddPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void AddPartMacIdCompNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // First check if Outsourced radio button is selected
            if (addPartOutsourcedRadioButton.Checked)
            {
                // Check if the key pressed is not a letter, a space, or the backspace key
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                {
                    e.Handled = true;
                }
            }
            // else if In-House radio button is selected
            else
            {
                // Check if the key pressed is not a number or the backspace key or minus sign
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                {
                    e.Handled = true;
                }
            }
        }

    }
}
