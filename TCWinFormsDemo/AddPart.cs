using System;
using System.Windows.Forms;

namespace TCWinFormsDemo
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();

            // Set the PartId text box to the auto-generated value
            addPartIdTextBox.Text = Inventory.AllParts.Count + 1 + "";

        }

        // Save button click event
        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            // Auto-generate PartId
            addPartIdTextBox.Text = Inventory.AllParts.Count + 1 + "";

            // Check if In-House radio button is selected
            if (addPartInHouseRadioButton.Checked)
            {
                // Create a new InHouse object
                InHouse newInHousePart = new InHouse();

                // Set the PartId attribute to the auto-generated value
                newInHousePart.PartId = Inventory.AllParts.Count + 1;

                // Set the PartName attribute to the value in the text box
                newInHousePart.PartName = addPartNameTextBox.Text;

                // Set the PartInStock attribute to the value in the text box
                newInHousePart.PartInStock = Convert.ToInt32(addPartInventoryTextBox.Text);

                // Set the PartPrice attribute to the value in the text box
                newInHousePart.PartPrice = Convert.ToDecimal(addPartPriceTextBox.Text);

                // Set the PartMin attribute to the value in the text box
                newInHousePart.PartMin = Convert.ToInt32(addPartMinTextBox.Text);

                // Set the PartMax attribute to the value in the text box
                newInHousePart.PartMax = Convert.ToInt32(addPartMaxTextBox.Text);

                // Set the MachineId attribute to the value in the text box
                newInHousePart.MachineId = Convert.ToInt32(addPartMacIdCompNameTextBox.Text);

                // Add the new InHouse object to the AllParts BindingList and close the AddPartForm
                Inventory.AllParts.Add(newInHousePart);
                this.Close();
            }
            // else if Outsourced radio button is selected
            else if (addPartOutsourcedRadioButton.Checked)
            {
                // Create a new Outsourced object
                Outsourced newOutsourcedPart = new Outsourced();

                // Set the PartId attribute to the auto-generated value
                newOutsourcedPart.PartId = Inventory.AllParts.Count + 1;

                // Set the PartName attribute to the value in the text box
                newOutsourcedPart.PartName = addPartNameTextBox.Text;

                // Set the PartInStock attribute to the value in the text box
                newOutsourcedPart.PartInStock = Convert.ToInt32(addPartInventoryTextBox.Text);

                // Set the PartPrice attribute to the value in the text box
                newOutsourcedPart.PartPrice = Convert.ToDecimal(addPartPriceTextBox.Text);

                // Set the PartMin attribute to the value in the text box
                newOutsourcedPart.PartMin = Convert.ToInt32(addPartMinTextBox.Text);

                // Set the PartMax attribute to the value in the text box
                newOutsourcedPart.PartMax = Convert.ToInt32(addPartMaxTextBox.Text);

                // Set the CompanyName attribute to the value in the text box
                newOutsourcedPart.CompanyName = addPartMacIdCompNameTextBox.Text;

                // Add the new Outsourced object to the AllParts BindingList and close the AddPartForm
                Inventory.AllParts.Add(newOutsourcedPart);
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
    }
}
