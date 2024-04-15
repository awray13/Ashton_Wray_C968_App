using System;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class AddPartForm : Form
    {
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
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if In-House radio button is selected
            if (addPartInHouseRadioButton.Checked)
            {
                // Create a new InHouse part object with the values in the text boxes
                InHouse newInHousePart = new InHouse(
                    Inventory.CalculatePartId(),
                    addPartNameTextBox.Text,
                    Convert.ToDecimal(addPartPriceTextBox.Text),
                    Convert.ToInt32(addPartInventoryTextBox.Text),
                    Convert.ToInt32(addPartMinTextBox.Text),
                    Convert.ToInt32(addPartMaxTextBox.Text),
                    Convert.ToInt32(addPartMacIdCompNameTextBox.Text)
                    );

                // Check if Inventory is between Min and Max
                if (int.Parse(addPartInventoryTextBox.Text) < int.Parse(addPartMinTextBox.Text) ||
                    int.Parse(addPartInventoryTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
                {
                    MessageBox.Show("Inventory must be between Min and Max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Price is a decimal
                if (!decimal.TryParse(addPartPriceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Price must be a decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Min is less than Max
                if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
                {
                    MessageBox.Show("Min must be less than Max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set the MachineId attribute to the value in the text box
                if (!int.TryParse(addPartMacIdCompNameTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Machine ID must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add the new InHouse object to the AllParts BindingList and close the AddPartForm
                Inventory.AddPart(newInHousePart);
                this.Close();
            }
            // else if Outsourced radio button is selected
            else
            {
                // Create a new Outsourced object
                Outsourced newOutsourcedPart = new Outsourced(
                    Inventory.CalculatePartId(),
                    addPartNameTextBox.Text,
                    Convert.ToDecimal(addPartPriceTextBox.Text),
                    Convert.ToInt32(addPartInventoryTextBox.Text),
                    Convert.ToInt32(addPartMinTextBox.Text),
                    Convert.ToInt32(addPartMaxTextBox.Text),
                    addPartMacIdCompNameTextBox.Text
                    );
                addPartOutsourcedRadioButton.Checked = true;

                // Check if Inventory is between Min and Max
                if (int.Parse(addPartInventoryTextBox.Text) < int.Parse(addPartMinTextBox.Text) ||
                    int.Parse(addPartInventoryTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
                {
                    MessageBox.Show("Inventory must be between Min and Max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newOutsourcedPart.Inventory = Convert.ToInt32(addPartInventoryTextBox.Text);

                // Check if Price is a decimal
                if (!decimal.TryParse(addPartPriceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Price must be a decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newOutsourcedPart.Price = Convert.ToDecimal(addPartPriceTextBox.Text);

                // Check if Min is less than Max
                if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
                {
                    MessageBox.Show("Min must be less than Max", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newOutsourcedPart.Min = Convert.ToInt32(addPartMinTextBox.Text);
                newOutsourcedPart.Max = Convert.ToInt32(addPartMaxTextBox.Text);

                if (string.IsNullOrWhiteSpace(addPartMacIdCompNameTextBox.Text))
                {
                    MessageBox.Show("Company Name must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Set the CompanyName attribute to the value in the text box
                newOutsourcedPart.CompanyName = addPartMacIdCompNameTextBox.Text;

                // Add the new Outsourced object to the AllParts BindingList and close the AddPartForm
                Inventory.AddPart(newOutsourcedPart);
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

        }
    }
}
