namespace Ashton_Wray_C968
{
    partial class ModifyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modProductSaveButton = new System.Windows.Forms.Button();
            this.modProductCancelButton = new System.Windows.Forms.Button();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.addAssociatedPartButton = new System.Windows.Forms.Button();
            this.modProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.modProductSearchButton = new System.Windows.Forms.Button();
            this.modProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modProductMinLabel = new System.Windows.Forms.Label();
            this.modProductMaxLabel = new System.Windows.Forms.Label();
            this.modProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modProductPriceLabel = new System.Windows.Forms.Label();
            this.modProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modProductInventoryLabel = new System.Windows.Forms.Label();
            this.modProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modProductNameLabel = new System.Windows.Forms.Label();
            this.modProductIdTextBox = new System.Windows.Forms.TextBox();
            this.modProductIdLabel = new System.Windows.Forms.Label();
            this.modProductAssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.modProductCandidateGridView = new System.Windows.Forms.DataGridView();
            this.modProductAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.modProductCandidatePartsLabel = new System.Windows.Forms.Label();
            this.modProductFormLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modProductAssociatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProductCandidateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modProductSaveButton
            // 
            this.modProductSaveButton.Location = new System.Drawing.Point(698, 477);
            this.modProductSaveButton.Name = "modProductSaveButton";
            this.modProductSaveButton.Size = new System.Drawing.Size(56, 22);
            this.modProductSaveButton.TabIndex = 45;
            this.modProductSaveButton.Text = "Save";
            this.modProductSaveButton.UseVisualStyleBackColor = true;
            this.modProductSaveButton.Click += new System.EventHandler(this.ModProductSaveButton_Click);
            // 
            // modProductCancelButton
            // 
            this.modProductCancelButton.Location = new System.Drawing.Point(760, 477);
            this.modProductCancelButton.Name = "modProductCancelButton";
            this.modProductCancelButton.Size = new System.Drawing.Size(56, 22);
            this.modProductCancelButton.TabIndex = 44;
            this.modProductCancelButton.Text = "Cancel";
            this.modProductCancelButton.UseVisualStyleBackColor = true;
            this.modProductCancelButton.Click += new System.EventHandler(this.ModProductCancelButton_Click);
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(760, 449);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(56, 22);
            this.deleteAssociatedPartButton.TabIndex = 43;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // addAssociatedPartButton
            // 
            this.addAssociatedPartButton.Location = new System.Drawing.Point(760, 245);
            this.addAssociatedPartButton.Name = "addAssociatedPartButton";
            this.addAssociatedPartButton.Size = new System.Drawing.Size(56, 22);
            this.addAssociatedPartButton.TabIndex = 42;
            this.addAssociatedPartButton.Text = "Add";
            this.addAssociatedPartButton.UseVisualStyleBackColor = true;
            this.addAssociatedPartButton.Click += new System.EventHandler(this.AddAssociatedPartButton_Click);
            // 
            // modProductSearchTextBox
            // 
            this.modProductSearchTextBox.Location = new System.Drawing.Point(651, 38);
            this.modProductSearchTextBox.Name = "modProductSearchTextBox";
            this.modProductSearchTextBox.Size = new System.Drawing.Size(165, 20);
            this.modProductSearchTextBox.TabIndex = 41;
            // 
            // modProductSearchButton
            // 
            this.modProductSearchButton.Location = new System.Drawing.Point(594, 36);
            this.modProductSearchButton.Name = "modProductSearchButton";
            this.modProductSearchButton.Size = new System.Drawing.Size(56, 22);
            this.modProductSearchButton.TabIndex = 40;
            this.modProductSearchButton.Text = "Search";
            this.modProductSearchButton.UseVisualStyleBackColor = true;
            this.modProductSearchButton.Click += new System.EventHandler(this.ModProductSearchButton_Click);
            // 
            // modProductMinTextBox
            // 
            this.modProductMinTextBox.Location = new System.Drawing.Point(190, 339);
            this.modProductMinTextBox.Name = "modProductMinTextBox";
            this.modProductMinTextBox.Size = new System.Drawing.Size(41, 20);
            this.modProductMinTextBox.TabIndex = 39;
            this.modProductMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModProductMinTextBox_KeyPress);
            // 
            // modProductMaxTextBox
            // 
            this.modProductMaxTextBox.Location = new System.Drawing.Point(92, 339);
            this.modProductMaxTextBox.Name = "modProductMaxTextBox";
            this.modProductMaxTextBox.Size = new System.Drawing.Size(41, 20);
            this.modProductMaxTextBox.TabIndex = 38;
            this.modProductMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModProductMaxTextBox_KeyPress);
            // 
            // modProductMinLabel
            // 
            this.modProductMinLabel.AutoSize = true;
            this.modProductMinLabel.Location = new System.Drawing.Point(153, 342);
            this.modProductMinLabel.Name = "modProductMinLabel";
            this.modProductMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modProductMinLabel.TabIndex = 37;
            this.modProductMinLabel.Text = "Min";
            // 
            // modProductMaxLabel
            // 
            this.modProductMaxLabel.AutoSize = true;
            this.modProductMaxLabel.Location = new System.Drawing.Point(53, 342);
            this.modProductMaxLabel.Name = "modProductMaxLabel";
            this.modProductMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modProductMaxLabel.TabIndex = 36;
            this.modProductMaxLabel.Text = "Max";
            // 
            // modProductPriceTextBox
            // 
            this.modProductPriceTextBox.Location = new System.Drawing.Point(92, 288);
            this.modProductPriceTextBox.Name = "modProductPriceTextBox";
            this.modProductPriceTextBox.Size = new System.Drawing.Size(118, 20);
            this.modProductPriceTextBox.TabIndex = 35;
            this.modProductPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModProductPriceTextBox_KeyPress);
            // 
            // modProductPriceLabel
            // 
            this.modProductPriceLabel.AutoSize = true;
            this.modProductPriceLabel.Location = new System.Drawing.Point(48, 295);
            this.modProductPriceLabel.Name = "modProductPriceLabel";
            this.modProductPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.modProductPriceLabel.TabIndex = 34;
            this.modProductPriceLabel.Text = "Price";
            // 
            // modProductInventoryTextBox
            // 
            this.modProductInventoryTextBox.Location = new System.Drawing.Point(92, 247);
            this.modProductInventoryTextBox.Name = "modProductInventoryTextBox";
            this.modProductInventoryTextBox.Size = new System.Drawing.Size(118, 20);
            this.modProductInventoryTextBox.TabIndex = 33;
            this.modProductInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModProductInventoryTextBox_KeyPress);
            // 
            // modProductInventoryLabel
            // 
            this.modProductInventoryLabel.AutoSize = true;
            this.modProductInventoryLabel.Location = new System.Drawing.Point(32, 250);
            this.modProductInventoryLabel.Name = "modProductInventoryLabel";
            this.modProductInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.modProductInventoryLabel.TabIndex = 32;
            this.modProductInventoryLabel.Text = "Inventory";
            // 
            // modProductNameTextBox
            // 
            this.modProductNameTextBox.Location = new System.Drawing.Point(92, 207);
            this.modProductNameTextBox.Name = "modProductNameTextBox";
            this.modProductNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.modProductNameTextBox.TabIndex = 31;
            // 
            // modProductNameLabel
            // 
            this.modProductNameLabel.AutoSize = true;
            this.modProductNameLabel.Location = new System.Drawing.Point(44, 210);
            this.modProductNameLabel.Name = "modProductNameLabel";
            this.modProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modProductNameLabel.TabIndex = 30;
            this.modProductNameLabel.Text = "Name";
            // 
            // modProductIdTextBox
            // 
            this.modProductIdTextBox.Location = new System.Drawing.Point(92, 163);
            this.modProductIdTextBox.Name = "modProductIdTextBox";
            this.modProductIdTextBox.ReadOnly = true;
            this.modProductIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.modProductIdTextBox.TabIndex = 29;
            // 
            // modProductIdLabel
            // 
            this.modProductIdLabel.AutoSize = true;
            this.modProductIdLabel.Location = new System.Drawing.Point(62, 166);
            this.modProductIdLabel.Name = "modProductIdLabel";
            this.modProductIdLabel.Size = new System.Drawing.Size(18, 13);
            this.modProductIdLabel.TabIndex = 28;
            this.modProductIdLabel.Text = "ID";
            // 
            // modProductAssociatedPartsGridView
            // 
            this.modProductAssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProductAssociatedPartsGridView.Location = new System.Drawing.Point(316, 281);
            this.modProductAssociatedPartsGridView.MultiSelect = false;
            this.modProductAssociatedPartsGridView.Name = "modProductAssociatedPartsGridView";
            this.modProductAssociatedPartsGridView.ReadOnly = true;
            this.modProductAssociatedPartsGridView.RowHeadersVisible = false;
            this.modProductAssociatedPartsGridView.Size = new System.Drawing.Size(500, 162);
            this.modProductAssociatedPartsGridView.TabIndex = 27;
            // 
            // modProductCandidateGridView
            // 
            this.modProductCandidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProductCandidateGridView.Location = new System.Drawing.Point(316, 74);
            this.modProductCandidateGridView.MultiSelect = false;
            this.modProductCandidateGridView.Name = "modProductCandidateGridView";
            this.modProductCandidateGridView.ReadOnly = true;
            this.modProductCandidateGridView.RowHeadersVisible = false;
            this.modProductCandidateGridView.Size = new System.Drawing.Size(500, 162);
            this.modProductCandidateGridView.TabIndex = 26;
            this.modProductCandidateGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModCandidateBindingComplete);
            // 
            // modProductAssociatedPartsLabel
            // 
            this.modProductAssociatedPartsLabel.AutoSize = true;
            this.modProductAssociatedPartsLabel.Location = new System.Drawing.Point(313, 265);
            this.modProductAssociatedPartsLabel.Name = "modProductAssociatedPartsLabel";
            this.modProductAssociatedPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.modProductAssociatedPartsLabel.TabIndex = 25;
            this.modProductAssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // modProductCandidatePartsLabel
            // 
            this.modProductCandidatePartsLabel.AutoSize = true;
            this.modProductCandidatePartsLabel.Location = new System.Drawing.Point(313, 58);
            this.modProductCandidatePartsLabel.Name = "modProductCandidatePartsLabel";
            this.modProductCandidatePartsLabel.Size = new System.Drawing.Size(96, 13);
            this.modProductCandidatePartsLabel.TabIndex = 24;
            this.modProductCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // modProductFormLabel
            // 
            this.modProductFormLabel.AutoSize = true;
            this.modProductFormLabel.Location = new System.Drawing.Point(28, 4);
            this.modProductFormLabel.Name = "modProductFormLabel";
            this.modProductFormLabel.Size = new System.Drawing.Size(78, 13);
            this.modProductFormLabel.TabIndex = 23;
            this.modProductFormLabel.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 502);
            this.Controls.Add(this.modProductSaveButton);
            this.Controls.Add(this.modProductCancelButton);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.addAssociatedPartButton);
            this.Controls.Add(this.modProductSearchTextBox);
            this.Controls.Add(this.modProductSearchButton);
            this.Controls.Add(this.modProductMinTextBox);
            this.Controls.Add(this.modProductMaxTextBox);
            this.Controls.Add(this.modProductMinLabel);
            this.Controls.Add(this.modProductMaxLabel);
            this.Controls.Add(this.modProductPriceTextBox);
            this.Controls.Add(this.modProductPriceLabel);
            this.Controls.Add(this.modProductInventoryTextBox);
            this.Controls.Add(this.modProductInventoryLabel);
            this.Controls.Add(this.modProductNameTextBox);
            this.Controls.Add(this.modProductNameLabel);
            this.Controls.Add(this.modProductIdTextBox);
            this.Controls.Add(this.modProductIdLabel);
            this.Controls.Add(this.modProductAssociatedPartsGridView);
            this.Controls.Add(this.modProductCandidateGridView);
            this.Controls.Add(this.modProductAssociatedPartsLabel);
            this.Controls.Add(this.modProductCandidatePartsLabel);
            this.Controls.Add(this.modProductFormLabel);
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.modProductAssociatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProductCandidateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modProductSaveButton;
        private System.Windows.Forms.Button modProductCancelButton;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.Button addAssociatedPartButton;
        private System.Windows.Forms.TextBox modProductSearchTextBox;
        private System.Windows.Forms.Button modProductSearchButton;
        private System.Windows.Forms.TextBox modProductMinTextBox;
        private System.Windows.Forms.TextBox modProductMaxTextBox;
        private System.Windows.Forms.Label modProductMinLabel;
        private System.Windows.Forms.Label modProductMaxLabel;
        private System.Windows.Forms.TextBox modProductPriceTextBox;
        private System.Windows.Forms.Label modProductPriceLabel;
        private System.Windows.Forms.TextBox modProductInventoryTextBox;
        private System.Windows.Forms.Label modProductInventoryLabel;
        private System.Windows.Forms.TextBox modProductNameTextBox;
        private System.Windows.Forms.Label modProductNameLabel;
        private System.Windows.Forms.TextBox modProductIdTextBox;
        private System.Windows.Forms.Label modProductIdLabel;
        private System.Windows.Forms.DataGridView modProductAssociatedPartsGridView;
        private System.Windows.Forms.DataGridView modProductCandidateGridView;
        private System.Windows.Forms.Label modProductAssociatedPartsLabel;
        private System.Windows.Forms.Label modProductCandidatePartsLabel;
        private System.Windows.Forms.Label modProductFormLabel;
    }
}