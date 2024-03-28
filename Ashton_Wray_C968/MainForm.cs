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

        }

        // Search part button click event
        private void SearchPartButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
