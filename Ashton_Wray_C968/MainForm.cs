using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormLoad();
        }

        public void MainFormLoad()
        {
            // Populate the main form with sample data
            Inventory.PopulateInventory();

            DataGridViewSelectionMode Row = DataGridViewSelectionMode.FullRowSelect;

            // Populate the part grid view with sample data using BindingSource
            var partBindingSource = new BindingSource();
            partBindingSource.DataSource = Inventory.AllParts;
            partGridView.DataSource = partBindingSource;
            partGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Populate the product grid view with sample data using BindingSource
            var productBindingSource = new BindingSource();
            productBindingSource.DataSource = Inventory.Products;
            productGridView.DataSource = productBindingSource;
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // Add part button click event
        private void AddPartButton_Click(object sender, System.EventArgs e)
        {
            // Open the AddPartForm
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();

        }

        // Modify part button click event
        private void ModifyPartButton_Click(object sender, System.EventArgs e)
        {
            // Check if the selected part is InHouse or Outsourced
            if (partGridView.CurrentRow != null && partGridView.CurrentRow.DataBoundItem != null && partGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHousePart = (InHouse)partGridView.CurrentRow.DataBoundItem;
                ModifyPartForm modifyPartForm = new ModifyPartForm(inHousePart);
                modifyPartForm.ShowDialog();
            }
            else if (partGridView.CurrentRow != null && partGridView.CurrentRow.DataBoundItem != null && partGridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPart = (Outsourced)partGridView.CurrentRow.DataBoundItem;
                ModifyPartForm modifyPartForm = new ModifyPartForm(outsourcedPart);
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: Part not found!");
            }
        }

        // Delete part button click event
        private void DeletePartButton_Click(object sender, System.EventArgs e)
        {
            // Display a confirmation dialog to confirm the deletion
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                // Get the selected part from the grid view
                Part part = (Part)partGridView.CurrentRow.DataBoundItem;

                // Check if the part is associated with any product
                bool isPartAssociated = Inventory.IsPartAssociatedWithProduct(part);

                if (isPartAssociated)
                {
                    MessageBox.Show("ERROR: This part is associated with a product and cannot be deleted!");
                }
                else
                {
                    // Call the DeletePart method from the Inventory class
                    bool deleted = Inventory.DeletePart(part);

                    if (deleted)
                    {
                        MessageBox.Show("Part deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Failed to delete the part!");
                    }
                }
            }
            else
            {
                return;
            }
        }

        // Search part button click event
        private void SearchPartButton_Click(object sender, System.EventArgs e)
        {
            // Code to search for a part in partGridView
            if (partSearchTextBox.Text != "")
            {
                bool found = false;
                for (int i = 0; i < partGridView.Rows.Count; i++)
                {
                    partGridView.Rows[i].Selected = false;
                    for (int j = 0; j < partGridView.Columns.Count; j++)
                    {
                        if (partGridView.Rows[i].Cells[j].Value != null && partGridView.Rows[i].Cells[j].Value
                                .ToString().ToLower().Contains(partSearchTextBox.Text.ToLower()))
                        {
                            partGridView.Rows[i].Selected = true;
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show("ERROR: Part not found!");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please enter a part to search!");
            }
        }

        // Add product button click event
        private void AddProductButton_Click(object sender, System.EventArgs e)
        {
            // Open the Add Product Form
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

        }

        // Modify product button click event
        private void ModifyProductButton_Click(object sender, System.EventArgs e)
        {
            // Check if a product is selected
            if (productGridView.CurrentRow != null)
            {
                Product product = (Product)productGridView.CurrentRow.DataBoundItem;
                ModifyProductForm modifyProductForm = new ModifyProductForm(product);
                modifyProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: Product not found!");
            }
        }

        // Delete product button click event
        private void DeleteProductButton_Click(object sender, System.EventArgs e)
        {
            // Display a confirmation dialog to confirm the deletion
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product?", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                // Get the selected product from the grid view
                Product product = (Product)productGridView.CurrentRow.DataBoundItem;

                // Check if the product has any associated parts
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("ERROR: This product has associated parts and cannot be deleted!");
                }
                else
                {
                    // Call the RemoveProduct method from the Inventory class
                    bool deleted = Inventory.RemoveProduct(product.ProductId);

                    if (deleted)
                    {
                        MessageBox.Show("Product deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Failed to delete the product!");
                    }
                }
            }


        }

        // Search product button click event
        private void SearchProductButton_Click(object sender, System.EventArgs e)
        {
            // Code to search for a product in productGridView
            if (productSearchTextBox.Text != "")
            {
                bool found = false;
                for (int i = 0; i < productGridView.Rows.Count; i++)
                {
                    productGridView.Rows[i].Selected = false;
                    for (int j = 0; j < productGridView.Columns.Count; j++)
                    {
                        if (productGridView.Rows[i].Cells[j].Value != null && productGridView.Rows[i].Cells[j].Value
                                .ToString().ToLower().Contains(productSearchTextBox.Text.ToLower()))
                        {
                            productGridView.Rows[i].Selected = true;
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show("ERROR: Product not found!");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please enter a product to search!");
            }

        }

        // Exit main form button click event
        private void ExitMainFormButton_Click(object sender, System.EventArgs e)
        {
            // Close the main form
            this.Close();
        }

        // TODO: Part Grid View Cell formatting: format the "Price" column as currency
        private void PartGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the "Price" column
            //if (e.ColumnIndex == partGridView.Columns["Price"].Index && e.Value != null)
            //{
            //    // Format the cell value as currency
            //    e.Value = ((decimal)e.Value).ToString("C");
            //}
        }

        // TODO: Product Grid View Cell formatting: format the "Price" column as currency
        private void ProductGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the "Price" column
            //if (e.ColumnIndex == productGridView.Columns["Price"].Index && e.Value != null)
            //{
            //    // Format the cell value as currency
            //    e.Value = ((decimal)e.Value).ToString("C");
            //}
        }
    }
}
