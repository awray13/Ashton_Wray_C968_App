using System.ComponentModel;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class AddProductForm : Form
    {
        // TODO: Constants for the max values allowed in text boxes: wire them up
        private const int MAX_INVENTORY = 999999999;
        private const int MAX_MAX = 999999999;
        private const decimal MAX_PRICE = 999999999.99m;


        // Constructor for the AddProductForm
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();

            // Set the ProductId text box to the auto-generated value
            addProductIdTextBox.Text = Inventory.CalculateProductId().ToString();

            addProductCandidateGridView.DataSource = Inventory.AllParts;
            addProductAssociatedPartsGridView.DataSource = product.AssociatedParts;

            addProductInventoryTextBox.KeyPress += new KeyPressEventHandler(AddProductInventoryTextBox_KeyPress);
            addProductPriceTextBox.KeyPress += new KeyPressEventHandler(AddProductPriceTextBox_KeyPress);
            addProductMaxTextBox.KeyPress += new KeyPressEventHandler(AddProductMaxTextBox_KeyPress);
            addProductMinTextBox.KeyPress += new KeyPressEventHandler(AddProductMinTextBox_KeyPress);


        }

        // TODO: AddProductSearchButton_Click: seems to be working as expected
        // Add product search button click event
        private void AddProductSearchButton_Click(object sender, System.EventArgs e)
        {
            // Search for the candidate part in the candidate parts list by part ID
            if (string.IsNullOrWhiteSpace(addProductSearchTextBox.Text) == false)
            {
                try
                {
                    Part part = Inventory.LookupPart(int.Parse(addProductSearchTextBox.Text));

                    if (part != null)
                    {
                        addProductCandidateGridView.ClearSelection();
                        foreach (DataGridViewRow row in addProductCandidateGridView.Rows)
                        {
                            Part candidatePart = (Part)row.DataBoundItem;
                            if (candidatePart.PartId == part.PartId)
                            {
                                row.Selected = true;
                                addProductCandidateGridView.CurrentCell = row.Cells[0];
                                break;
                            }
                        }
                    }
                    else if (int.Parse(addProductSearchTextBox.Text) > Inventory.AllParts.Count)
                    {
                        MessageBox.Show("Part not found.");
                        addProductSearchTextBox.Text = "";
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Invalid entry. Please enter a valid part ID.");
                    addProductSearchTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a Part ID.");
            }
        }

        //TODO: AddAssociatedPartButton_Click: only adds the part if it is not already associated - tested and working
        // Add associated part button click event
        private void AddAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            // when add associated part button is clicked, add the selected part to the associated parts list only once
            Part part = (Part)addProductCandidateGridView.CurrentRow.DataBoundItem;
            if (!product.AssociatedParts.Contains(part))
            {
                product.AddAssociatedPart(part);
            }
            else
            {
                MessageBox.Show("Part already associated.");
            }
        }

        // Delete associated part button click event
        private void DeleteAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            // when delete associated part button is clicked, remove the selected part from the associated parts list with confirmation dialog box
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Part part = (Part)addProductAssociatedPartsGridView.CurrentRow.DataBoundItem;
                product.AssociatedParts.Remove(part);
            }
            else return;
        }

        // Save button click event
        private void AddProductSaveButton_Click(object sender, System.EventArgs e)
        {
            // Auto-generate the ProductId
            addProductIdTextBox.Text = Inventory.CalculateProductId() + "";

            // if statement to check if the product fields are empty
            if (string.IsNullOrWhiteSpace(addProductNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductInventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMinTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMaxTextBox.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inventory validation: check if the inventory is a valid number and within maximum range
            if (!int.TryParse(addProductInventoryTextBox.Text, out int inventory) || inventory < 0 || inventory > MAX_INVENTORY)
            {
                MessageBox.Show("Inventory cannot exceed " + MAX_INVENTORY.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Price validation: check if price is a decimal and within maximum range
            if (!decimal.TryParse(addProductPriceTextBox.Text, out decimal price) || price < 0 || price > MAX_PRICE)
            {
                MessageBox.Show("Price cannot exceed " + MAX_PRICE.ToString("C") + " and must be a valid decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if Max is within the maximum range
            if (!int.TryParse(addProductMaxTextBox.Text, out int max) || max > MAX_MAX)
            {
                string errorMessage = "Maximum cannot exceed " + MAX_MAX.ToString();
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if Min is less than Max
            if (!int.TryParse(addProductMinTextBox.Text, out int min) || min > max)
            {
                string errorMessage = "Your minimum exceeds your maximum. Please try again.";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if inventory is greater than Max or less than Min
            if (inventory > int.Parse(addProductMaxTextBox.Text) || inventory < int.Parse(addProductMinTextBox.Text))
            {
                MessageBox.Show("Inventory cannot be greater than Max or less than Min", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // try catch block to catch any exceptions and create a new product
                try
                {
                    Product newProduct = new Product();
                    newProduct.ProductId = Inventory.CalculateProductId();
                    newProduct.ProductName = addProductNameTextBox.Text;
                    newProduct.ProductPrice = decimal.Parse(addProductPriceTextBox.Text);
                    newProduct.ProductInStock = int.Parse(addProductInventoryTextBox.Text);
                    newProduct.ProductMin = int.Parse(addProductMinTextBox.Text);
                    newProduct.ProductMax = int.Parse(addProductMaxTextBox.Text);
                    foreach (DataGridViewRow row in addProductAssociatedPartsGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        newProduct.AddAssociatedPart(part);
                    }

                    Inventory.AddProduct(newProduct);
                    Close();
                    {

                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Product could not be added. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Cancel button click event
        private void AddProductCancelButton_Click(object sender, System.EventArgs e)
        {
            // Close the AddProductForm
            this.Close();
        }

        // This method is used to validate the input for the AddProductInventoryTextBox is a digit
        private void AddProductInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a digit or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Set e.Handled to true to cancel the key press
                e.Handled = true;
            }

        }

        // This method is used to validate the input for the AddProductPriceTextBox is a decimal
        private void AddProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a digit, the backspace key, or a decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                // Set e.Handled to true to cancel the key press
                e.Handled = true;
            }

        }

        // This method is used to validate the input for the AddProductMaxTextBox is a digit
        private void AddProductMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a digit or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Set e.Handled to true to cancel the key press
                e.Handled = true;
            }

        }

        // This method is used to validate the input for the AddProductMinTextBox is a digit
        private void AddProductMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a digit or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Set e.Handled to true to cancel the key press
                e.Handled = true;
            }

        }

        // Loads event for the AddProductForm
        private void AddProductForm_Load(object sender, System.EventArgs e)
        {
            // Loads the AddProductForm with next available Product ID
            addProductIdTextBox.Text = Inventory.CalculateProductId().ToString();

            // Creates a new BindingSource of Candidate Parts
            var candidatePartLoad = new BindingSource();
            candidatePartLoad.DataSource = Inventory.AllParts;
            addProductCandidateGridView.DataSource = candidatePartLoad;
            addProductCandidateGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            // Creates a new BindingSource of Associated Parts
            var associatedPartLoad = new BindingSource();
            associatedPartLoad.DataSource = product.AssociatedParts;
            addProductAssociatedPartsGridView.DataSource = associatedPartLoad;
            addProductAssociatedPartsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Loads all Associated Parts into the associatedPartLoad BindingList
            foreach (Part part in product.AssociatedParts)
            {
                associatedPartLoad.Add(part);
            }

            // Sets the DataSource of the addProductAssociatedPartsGridView to the associatedPartLoad BindingList
            addProductAssociatedPartsGridView.DataSource = associatedPartLoad;
        }

        private void AddProductCandidateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProductAssociatedPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCandidateBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductCandidateGridView.ClearSelection();
        }

        private void AddAssociatedBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductAssociatedPartsGridView.ClearSelection();
        }
    }
}
