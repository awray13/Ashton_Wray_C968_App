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

                // Set the Name attribute to the value in the text box
                newInHousePart.Name = addPartNameTextBox.Text;

                // Set the Inventory attribute to the value in the text box
                newInHousePart.Inventory = Convert.ToInt32(addPartInventoryTextBox.Text);

                // Set the Price attribute to the value in the text box
                newInHousePart.Price = Convert.ToDecimal(addPartPriceTextBox.Text);

                // Set the Min attribute to the value in the text box
                newInHousePart.Min = Convert.ToInt32(addPartMinTextBox.Text);

                // Set the Max attribute to the value in the text box
                newInHousePart.Max = Convert.ToInt32(addPartMaxTextBox.Text);

                // Set the MachineId attribute to the value in the text box
                newInHousePart.MachineId = Convert.ToInt32(addPartMacIdCompNameTextBox.Text);

                // Add the new InHouse object to the AllParts BindingList and close the AddPartForm
                Inventory.AddPart(newInHousePart);
                this.Close();
            }
            // else if Outsourced radio button is selected
            else if (addPartOutsourcedRadioButton.Checked)
            {
                // Create a new Outsourced object
                Outsourced newOutsourcedPart = new Outsourced();

                // Set the PartId attribute to the auto-generated value
                newOutsourcedPart.PartId = Inventory.AllParts.Count + 1;

                // Set the Name attribute to the value in the text box
                newOutsourcedPart.Name = addPartNameTextBox.Text;

                // Set the Inventory attribute to the value in the text box
                newOutsourcedPart.Inventory = Convert.ToInt32(addPartInventoryTextBox.Text);

                // Set the Price attribute to the value in the text box
                newOutsourcedPart.Price = Convert.ToDecimal(addPartPriceTextBox.Text);

                // Set the Min attribute to the value in the text box
                newOutsourcedPart.Min = Convert.ToInt32(addPartMinTextBox.Text);

                // Set the Max attribute to the value in the text box
                newOutsourcedPart.Max = Convert.ToInt32(addPartMaxTextBox.Text);

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
    }
}
