using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class ModifyPartForm : Form
    {
        // Define the max values for the text boxes
        private const int MAX_PART_NAME = 256;
        private const int MAX_INVENTORY = 999999999;
        private const decimal MAX_PRICE = 999999999.99m;
        private const int MAX_MIN = 999999999;
        private const int MAX_MAX = 999999999;
        private const int MAX_MACHINE_ID = 999999999;
        private const int MAX_COMPANY_NAME = 50;


        public ModifyPartForm()
        {
            // Initialize the ModifyPartForm
            InitializeComponent();

            // Show part ID in the PartId text box
            modPartIdTextBox.Text = Inventory.AllParts.Count + "";

            // Event handlers for key press events
            modPartInventoryTextBox.KeyPress += new KeyPressEventHandler(ModPartInventoryTextBox_KeyPress);
            modPartPriceTextBox.KeyPress += new KeyPressEventHandler(ModPartPriceTextBox_KeyPress);
            modPartMaxTextBox.KeyPress += new KeyPressEventHandler(ModPartMaxTextBox_KeyPress);
            modPartMinTextBox.KeyPress += new KeyPressEventHandler(ModPartMinTextBox_KeyPress);


        }

        // Constructor for InHouse part
        public ModifyPartForm(InHouse inHousePart)
        {
            InitializeComponent();
            modPartIdTextBox.Enabled = false;
            // Show part ID in the PartId text box
            modPartIdTextBox.Text = Inventory.AllParts.Count + "";

            // This method is used to check if the text box is a digit
            modPartInventoryTextBox.KeyPress += new KeyPressEventHandler(ModPartInventoryTextBox_KeyPress);
            modPartPriceTextBox.KeyPress += new KeyPressEventHandler(ModPartPriceTextBox_KeyPress);
            modPartMaxTextBox.KeyPress += new KeyPressEventHandler(ModPartMaxTextBox_KeyPress);
            modPartMinTextBox.KeyPress += new KeyPressEventHandler(ModPartMinTextBox_KeyPress);


            // Set text box values to the InHouse part attributes
            modPartIdTextBox.Text = inHousePart.PartId.ToString();
            modPartNameTextBox.Text = inHousePart.Name;
            modPartInventoryTextBox.Text = inHousePart.Inventory.ToString();
            modPartPriceTextBox.Text = inHousePart.Price.ToString();
            modPartMinTextBox.Text = inHousePart.Min.ToString();
            modPartMaxTextBox.Text = inHousePart.Max.ToString();
            modPartMacIdCompNameTextBox.Text = inHousePart.MachineId.ToString();
            modPartInHouseRadioButton.Checked = true;
        }

        // Constructor for Outsourced part
        public ModifyPartForm(Outsourced outsourcedPart)
        {
            InitializeComponent();
            modPartIdTextBox.Enabled = false;

            // Show part ID in the PartId text box
            modPartIdTextBox.Text = Inventory.AllParts.Count + "";

            // This method is used to check if the text box is a digit
            modPartInventoryTextBox.KeyPress += new KeyPressEventHandler(ModPartInventoryTextBox_KeyPress);
            modPartPriceTextBox.KeyPress += new KeyPressEventHandler(ModPartPriceTextBox_KeyPress);
            modPartMaxTextBox.KeyPress += new KeyPressEventHandler(ModPartMaxTextBox_KeyPress);
            modPartMinTextBox.KeyPress += new KeyPressEventHandler(ModPartMinTextBox_KeyPress);

            // Set text box values to the Outsourced part attributes
            modPartIdTextBox.Text = outsourcedPart.PartId.ToString();
            modPartNameTextBox.Text = outsourcedPart.Name;
            modPartInventoryTextBox.Text = outsourcedPart.Inventory.ToString();
            modPartPriceTextBox.Text = outsourcedPart.Price.ToString();
            modPartMinTextBox.Text = outsourcedPart.Min.ToString();
            modPartMaxTextBox.Text = outsourcedPart.Max.ToString();
            modPartMacIdCompNameTextBox.Text = outsourcedPart.CompanyName;
            modPartOutsourcedRadioButton.Checked = true;
        }

        // In-House radio button checked changed event
        private void ModPartInHouseRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set label text to "Machine ID" when In-House radio button is selected
            modPartMacIdCompNameLabel.Text = "Machine ID";
        }

        // Outsourced radio button checked changed event
        private void ModPartOutsourcedRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set label text to "Company Name" when Outsourced radio button is selected
            modPartMacIdCompNameLabel.Text = "Company Name";
        }

        // This method checks if the form is valid
        private bool IsModPartFormVaild()
        {
            // Check if the part name text box is empty
            if (string.IsNullOrWhiteSpace(modPartNameTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            // Check if the inventory text box is empty
            if (string.IsNullOrWhiteSpace(modPartInventoryTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            // Check if the price text box is empty
            if (string.IsNullOrWhiteSpace(modPartPriceTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            // Check if the min text box is empty
            if (string.IsNullOrWhiteSpace(modPartMinTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            // Check if the max text box is empty
            if (string.IsNullOrWhiteSpace(modPartMaxTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            // Check if the machine ID or company name text box is empty
            if (string.IsNullOrWhiteSpace(modPartMacIdCompNameTextBox.Text))
            {
                MessageBox.Show("All fields are required!");
                return false;
            }

            return true;
        }

        // This method checks if the form is complete
        private bool IsModPartFormComplete()
        {
            // This if statement is used to check if the InHouse radio button is selected
            if (modPartInHouseRadioButton.Checked)
            {

                // Check if the inventory is a valid integer and within the maximum range
                if (!int.TryParse(modPartInventoryTextBox.Text, out int inventory) || inventory < 0 || inventory > MAX_INVENTORY)
                {
                    MessageBox.Show("Inventory cannot exceed " + MAX_INVENTORY.ToString());
                    return false;
                }

                // Check to see if Min is less than Max
                if (!int.TryParse(modPartMinTextBox.Text, out int min) || !int.TryParse(modPartMaxTextBox.Text, out int max2) || min > max2)
                {
                    string errorMessage = "Your minimum exceeds your maximum. Please try again.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if inventory is greater than Max or less than Min
                if (inventory > int.Parse(modPartMaxTextBox.Text) || inventory < int.Parse(modPartMinTextBox.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than Max or less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if the price text box is a decimal
                if (!decimal.TryParse(modPartPriceTextBox.Text, out decimal price) || price > MAX_PRICE)
                {
                    MessageBox.Show("Price cannot exceed " + MAX_PRICE.ToString("C") + " and must be a valid decimal!");
                    return false;
                }

                // Check if the max text box is a digit
                if (!int.TryParse(modPartMaxTextBox.Text, out int max) || max > MAX_MAX)
                {
                    string errorMessage = "Maximum cannot exceed " + MAX_MAX.ToString();
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if the machine ID is a digit
                if (!int.TryParse(modPartMacIdCompNameTextBox.Text, out int machineId) || machineId < 0 || machineId > MAX_MACHINE_ID)
                {
                    MessageBox.Show("Machine ID cannot exceed " + MAX_MACHINE_ID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // If statement to check if the Outsourced radio button is selected
            else if (modPartOutsourcedRadioButton.Checked)
            {
                // Check if the inventory text box is a digit
                if (!int.TryParse(modPartInventoryTextBox.Text, out int inventory) || inventory < 0 || inventory > MAX_INVENTORY)
                {
                    MessageBox.Show("Inventory cannot exceed " + MAX_INVENTORY.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if Min is less than Max and within the maximum range
                if (!int.TryParse(modPartMinTextBox.Text, out int min) || !int.TryParse(modPartMaxTextBox.Text, out int max2) || min > max2)
                {
                    string errorMessage = "Your minimum exceeds your maximum. Please try again.";
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if inventory is greater than Max or less than Min
                if (inventory > int.Parse(modPartMaxTextBox.Text) || inventory < int.Parse(modPartMinTextBox.Text))
                {
                    MessageBox.Show("Inventory cannot be greater than Max or less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if the price text box is a decimal
                if (!decimal.TryParse(modPartPriceTextBox.Text, out decimal price) || price > MAX_PRICE)
                {
                    MessageBox.Show("Price cannot exceed " + MAX_PRICE.ToString("C"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if the max text box is a digit
                if (!int.TryParse(modPartMaxTextBox.Text, out int max) || max > MAX_MAX)
                {
                    string errorMessage = "Maximum cannot exceed " + MAX_MAX.ToString();
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check if the company name text box is empty and not a digit
                foreach (char c in modPartMacIdCompNameTextBox.Text)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        MessageBox.Show("Company Name must only contain letters and spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
            }
            return true;
        }

        // This method updates the part form
        private void UpdateModPartForm()
        {
            // Check if the InHouse radio button is selected
            if (modPartInHouseRadioButton.Checked)
            {
                // Create a new InHouse object
                InHouse inHousePart = new InHouse();

                // Set the PartId attribute to the value in the text box
                inHousePart.PartId = int.Parse(modPartIdTextBox.Text);

                // Set the Name attribute to the value in the text box
                inHousePart.Name = modPartNameTextBox.Text;

                // Set the Inventory attribute to the value in the text box
                inHousePart.Inventory = int.Parse(modPartInventoryTextBox.Text);

                // Set the Price attribute to the value in the text box
                inHousePart.Price = decimal.Parse(modPartPriceTextBox.Text);

                // Set the Min attribute to the value in the text box
                inHousePart.Min = int.Parse(modPartMinTextBox.Text);

                // Set the Max attribute to the value in the text box
                inHousePart.Max = int.Parse(modPartMaxTextBox.Text);

                // Set the MachineId attribute to the value in the text box
                inHousePart.MachineId = int.Parse(modPartMacIdCompNameTextBox.Text);

                // Update the InHouse part in the inventory
                Inventory.UpdatePart(inHousePart.PartId, inHousePart);
            }
            // Check if the Outsourced radio button is selected
            else if (modPartOutsourcedRadioButton.Checked)
            {
                // Create a new Outsourced object
                Outsourced outsourcedPart = new Outsourced();

                // Set the PartId attribute to the value in the text box
                outsourcedPart.PartId = int.Parse(modPartIdTextBox.Text);

                // Set the Name attribute to the value in the text box
                outsourcedPart.Name = modPartNameTextBox.Text;

                // Set the Inventory attribute to the value in the text box
                outsourcedPart.Inventory = int.Parse(modPartInventoryTextBox.Text);

                // Set the Price attribute to the value in the text box
                outsourcedPart.Price = decimal.Parse(modPartPriceTextBox.Text);

                // Set the Min attribute to the value in the text box
                outsourcedPart.Min = int.Parse(modPartMinTextBox.Text);

                // Set the Max attribute to the value
                outsourcedPart.Max = int.Parse(modPartMaxTextBox.Text);

                // Set the CompanyName attribute to the value in the text box
                outsourcedPart.CompanyName = modPartMacIdCompNameTextBox.Text;

                // Update the Outsourced part in the inventory
                Inventory.UpdatePart(outsourcedPart.PartId, outsourcedPart);
            }
        }

        // Save button click event
        private void ModPartSaveButton_Click(object sender, System.EventArgs e)
        {
            if (IsModPartFormVaild() && IsModPartFormComplete())
            {
                UpdateModPartForm();
                this.Close();
            }

        }

        // Cancel button click event
        private void ModPartCancelButton_Click(object sender, System.EventArgs e)
        {
            // Close the ModifyPartForm
            this.Close();
        }

        private void ModPartPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModPartInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModifyPartForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
