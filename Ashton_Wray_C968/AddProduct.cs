using System.ComponentModel;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class AddProductForm : Form
    {
        // Constructor for the AddProductForm
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();
            addProductCandidateGridView.DataSource = Inventory.AllParts;
            addProductAssociatedPartsGridView.DataSource = product.AssociatedParts;
            addProductInventoryTextBox.KeyPress += new KeyPressEventHandler(AddProductInventoryTextBox_KeyPress);
            addProductPriceTextBox.KeyPress += new KeyPressEventHandler(AddProductPriceTextBox_KeyPress);
            addProductMaxTextBox.KeyPress += new KeyPressEventHandler(AddProductMaxTextBox_KeyPress);
            addProductMinTextBox.KeyPress += new KeyPressEventHandler(AddProductMinTextBox_KeyPress);


        }

        // Add product search button click event
        private void AddProductSearchButton_Click(object sender, System.EventArgs e)
        {
            // try catch block to catch any exceptions and search for a part in the candidate parts list
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
                else
                {
                    MessageBox.Show("Part not found.");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("An error occurred.");
            }
        }

        // Add associated part button click event
        private void AddAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            // when add associated part button is clicked, add the selected part to the associated parts list
            Part part = (Part)addProductCandidateGridView.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(part);


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
            // if statement to check if the product fields are empty
            if (string.IsNullOrWhiteSpace(addProductNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductInventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMinTextBox.Text) ||
                string.IsNullOrWhiteSpace(addProductMaxTextBox.Text))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }
            // if statement to check if the add product form is valid
            if (int.Parse(addProductMinTextBox.Text) > int.Parse(addProductMaxTextBox.Text))
            {
                MessageBox.Show("Min must be less than Max.");
                return;
            }
            // if statement to check if the inventory is between the min and max
            if (int.Parse(addProductInventoryTextBox.Text) < int.Parse(addProductMinTextBox.Text) ||
                int.Parse(addProductInventoryTextBox.Text) > int.Parse(addProductMaxTextBox.Text))
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }
            // if statement to check if price is a decimal
            if (!decimal.TryParse(addProductPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price must be a decimal.");
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
                    this.Close();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("An error occurred.");
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
    }
}
