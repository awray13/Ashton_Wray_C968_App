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

            // Populate the part grid view using BindingSource
            var partBindingSource = new BindingSource();
            partBindingSource.DataSource = Inventory.AllParts;
            partGridView.DataSource = partBindingSource;

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

            // Check if a part is selected
            if (partGridView.CurrentRow != null)
            {
                // Pop up confirmation message
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part?", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                else if (dialogResult == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in partGridView.SelectedRows)
                    {
                        partGridView.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Part deleted successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please select a part to delete!");
            }

        }

        // Search part button click event
        private void SearchPartButton_Click(object sender, System.EventArgs e)
        {
            // Check if the search box is empty
            partGridView.ClearSelection();
            if (string.IsNullOrWhiteSpace(searchPartButton.Text) && partGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in partGridView.Rows)
                {
                    // Select the first row if the search box is empty
                    if (row.Cells[0].Value.ToString().Contains(searchPartButton.Text) || row.Cells[1].Value.ToString().Contains(searchPartButton.Text))
                    {
                        partGridView.CurrentCell = row.Cells[0];
                        row.Selected = true;
                    }

                    if (row.Selected)
                    {
                        break;
                    }

                }

                if (partGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("ERROR: Part not found!");
                }
            }



        }

        // Add product button click event
        private void AddProductButton_Click(object sender, System.EventArgs e)
        {

        }

        // Modify product button click event
        private void ModifyProductButton_Click(object sender, System.EventArgs e)
        {

        }

        // Delete product button click event
        private void DeleteProductButton_Click(object sender, System.EventArgs e)
        {

        }

        // Search product button click event
        private void ProductSearchButton_Click(object sender, System.EventArgs e)
        {

        }

        // Exit main form button click event
        private void ExitMainFormButton_Click(object sender, System.EventArgs e)
        {
            // Close the main form
            this.Close();
        }
    }
}
