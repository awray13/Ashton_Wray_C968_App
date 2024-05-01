using System.ComponentModel;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class ModifyProductForm : Form
    {
        // TODO: Add constants for the max values of the text boxes
        private const int MAX_INVENTORY = 999999999;
        private const int MAX_MAX = 999999999;
        private const int MAX_PRICE = 999999999;


        // Constructor for the AddProductForm
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        Product product = new Product();

        public ModifyProductForm(Product prod)
        {
            InitializeComponent();
            ModifyProductFormLoad(prod);
        }

        private void ModifyProductFormLoad(Product product)
        {
            // Set the product to the product passed in
            this.product = product;

            // Populate the form with the product data
            modProductIdTextBox.Text = product.ProductId.ToString();
            modProductNameTextBox.Text = product.ProductName;
            modProductInventoryTextBox.Text = product.ProductInStock.ToString();
            modProductPriceTextBox.Text = product.ProductPrice.ToString();
            modProductMinTextBox.Text = product.ProductMin.ToString();
            modProductMaxTextBox.Text = product.ProductMax.ToString();

            // Populate the associated parts grid view with the product's associated parts
            var associatedPartBindingSource = new BindingSource();
            associatedPartBindingSource.DataSource = product.AssociatedParts;
            modProductAssociatedPartsGridView.DataSource = associatedPartBindingSource;
            modProductAssociatedPartsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Populate the candidate parts grid view with all parts that are not associated with the product
            var candidatePartBindingSource = new BindingSource();
            candidatePartBindingSource.DataSource = Inventory.AllParts;
            modProductCandidateGridView.DataSource = candidatePartBindingSource;
            modProductCandidateGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // This loop is used to populate the associated parts grid view with the product's associated parts
            foreach (Part part in product.AssociatedParts)
            {
                foreach (DataGridViewRow row in modProductCandidateGridView.Rows)
                {
                    Part candidatePart = (Part)row.DataBoundItem;
                    if (candidatePart.PartId == part.PartId)
                    {
                        row.Selected = true;
                        modProductCandidateGridView.CurrentCell = row.Cells[0];
                        break;
                    }
                }


            }

        }

        private void ModProductSearchButton_Click(object sender, System.EventArgs e)
        {
            // Search for the candidate part in the candidate part list by part ID
            if (string.IsNullOrWhiteSpace(modProductSearchTextBox.Text) == false)
            {
                try
                {
                    Part part = Inventory.LookupPart(int.Parse(modProductSearchTextBox.Text));

                    if (part != null)
                    {
                        modProductCandidateGridView.ClearSelection();
                        foreach (DataGridViewRow row in modProductCandidateGridView.Rows)
                        {
                            Part candidatePart = (Part)row.DataBoundItem;
                            if (candidatePart.PartId == part.PartId)
                            {
                                row.Selected = true;
                                modProductCandidateGridView.CurrentCell = row.Cells[0];
                                break;
                            }
                        }
                    }
                    else if (int.Parse(modProductSearchTextBox.Text) > Inventory.AllParts.Count)
                    {
                        MessageBox.Show("Part not found.");
                        modProductSearchTextBox.Text = "";
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Invalid entry. Please enter a valid part ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Part ID.");
            }
        }

        private void AddAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            // when add associated part button is clicked, add the selected part to the associated parts list
            Part part = (Part)modProductCandidateGridView.CurrentRow.DataBoundItem;
            if (!product.AssociatedParts.Contains(part))
            {
                product.AddAssociatedPart(part);
            }
            else
            {
                MessageBox.Show("Part already associated.");
            }


        }

        private void DeleteAssociatedPartButton_Click(object sender, System.EventArgs e)
        {
            // when delete associated part button is clicked, remove the selected part from the associated parts list with confirmation dialog box
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Part part = (Part)modProductAssociatedPartsGridView.CurrentRow.DataBoundItem;
                product.AssociatedParts.Remove(part);
            }
            else return;

        }

        private void ModProductSaveButton_Click(object sender, System.EventArgs e)
        {
            // if statement to check if the product fields are empty
            if (string.IsNullOrWhiteSpace(modProductNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(modProductInventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(modProductPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(modProductMinTextBox.Text) ||
                string.IsNullOrWhiteSpace(modProductMaxTextBox.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // if statement to check if the add product form is valid
            if (int.Parse(modProductMinTextBox.Text) > int.Parse(modProductMaxTextBox.Text))
            {
                MessageBox.Show("Min must be less than Max.");
                return;
            }
            // if statement to check if the inventory is between the min and max
            if (int.Parse(modProductInventoryTextBox.Text) < int.Parse(modProductMinTextBox.Text) ||
                int.Parse(modProductInventoryTextBox.Text) > int.Parse(modProductMaxTextBox.Text))
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }
            // if statement to check if price is a decimal
            if (!decimal.TryParse(modProductPriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price must be a decimal.");
                return;
            }
            else
            {
                // try catch block to catch any exceptions and update the product
                try
                {
                    product.ProductName = modProductNameTextBox.Text;
                    product.ProductInStock = int.Parse(modProductInventoryTextBox.Text);
                    product.ProductPrice = price;
                    product.ProductMin = int.Parse(modProductMinTextBox.Text);
                    product.ProductMax = int.Parse(modProductMaxTextBox.Text);
                    Inventory.UpdateProduct(product.ProductId, product);
                    this.Close();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("An error occurred.");
                }
            }

        }

        private void ModProductCancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // This method is used to validate the inventory text bax is a number
        private void ModProductInventoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the price text box is a decimal
        private void ModProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number, the backspace key, or a decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the max text box is a number
        private void ModProductMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        // This method is used to validate the min text box is a number
        private void ModProductMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a number or the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
    }
}
