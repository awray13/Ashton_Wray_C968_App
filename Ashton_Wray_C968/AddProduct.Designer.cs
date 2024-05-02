namespace Ashton_Wray_C968
{
    partial class AddProductForm
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
            this.addProductFormLabel = new System.Windows.Forms.Label();
            this.addProductCandidatePartsLabel = new System.Windows.Forms.Label();
            this.addProductAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.addProductCandidateGridView = new System.Windows.Forms.DataGridView();
            this.addProductAssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.addProductIdLabel = new System.Windows.Forms.Label();
            this.addProductIdTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductMinLabel = new System.Windows.Forms.Label();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            this.addProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.addAssociatedPartButton = new System.Windows.Forms.Button();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProductCandidateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssociatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductFormLabel
            // 
            this.addProductFormLabel.AutoSize = true;
            this.addProductFormLabel.Location = new System.Drawing.Point(0, 0);
            this.addProductFormLabel.Name = "addProductFormLabel";
            this.addProductFormLabel.Size = new System.Drawing.Size(66, 13);
            this.addProductFormLabel.TabIndex = 0;
            this.addProductFormLabel.Text = "Add Product";
            // 
            // addProductCandidatePartsLabel
            // 
            this.addProductCandidatePartsLabel.AutoSize = true;
            this.addProductCandidatePartsLabel.Location = new System.Drawing.Point(285, 54);
            this.addProductCandidatePartsLabel.Name = "addProductCandidatePartsLabel";
            this.addProductCandidatePartsLabel.Size = new System.Drawing.Size(96, 13);
            this.addProductCandidatePartsLabel.TabIndex = 1;
            this.addProductCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // addProductAssociatedPartsLabel
            // 
            this.addProductAssociatedPartsLabel.AutoSize = true;
            this.addProductAssociatedPartsLabel.Location = new System.Drawing.Point(285, 261);
            this.addProductAssociatedPartsLabel.Name = "addProductAssociatedPartsLabel";
            this.addProductAssociatedPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.addProductAssociatedPartsLabel.TabIndex = 2;
            this.addProductAssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // addProductCandidateGridView
            // 
            this.addProductCandidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductCandidateGridView.Location = new System.Drawing.Point(288, 70);
            this.addProductCandidateGridView.MultiSelect = false;
            this.addProductCandidateGridView.Name = "addProductCandidateGridView";
            this.addProductCandidateGridView.ReadOnly = true;
            this.addProductCandidateGridView.RowHeadersVisible = false;
            this.addProductCandidateGridView.Size = new System.Drawing.Size(500, 162);
            this.addProductCandidateGridView.TabIndex = 3;
            this.addProductCandidateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddProductCandidateGridView_CellContentClick);
            this.addProductCandidateGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddCandidateBindingComplete);
            // 
            // addProductAssociatedPartsGridView
            // 
            this.addProductAssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductAssociatedPartsGridView.Location = new System.Drawing.Point(288, 277);
            this.addProductAssociatedPartsGridView.MultiSelect = false;
            this.addProductAssociatedPartsGridView.Name = "addProductAssociatedPartsGridView";
            this.addProductAssociatedPartsGridView.ReadOnly = true;
            this.addProductAssociatedPartsGridView.RowHeadersVisible = false;
            this.addProductAssociatedPartsGridView.Size = new System.Drawing.Size(500, 162);
            this.addProductAssociatedPartsGridView.TabIndex = 4;
            this.addProductAssociatedPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddProductAssociatedPartsGridView_CellContentClick);
            this.addProductAssociatedPartsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AddAssociatedBindingComplete);
            // 
            // addProductIdLabel
            // 
            this.addProductIdLabel.AutoSize = true;
            this.addProductIdLabel.Location = new System.Drawing.Point(34, 162);
            this.addProductIdLabel.Name = "addProductIdLabel";
            this.addProductIdLabel.Size = new System.Drawing.Size(18, 13);
            this.addProductIdLabel.TabIndex = 5;
            this.addProductIdLabel.Text = "ID";
            // 
            // addProductIdTextBox
            // 
            this.addProductIdTextBox.Location = new System.Drawing.Point(64, 159);
            this.addProductIdTextBox.Name = "addProductIdTextBox";
            this.addProductIdTextBox.ReadOnly = true;
            this.addProductIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.addProductIdTextBox.TabIndex = 6;
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Location = new System.Drawing.Point(16, 206);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addProductNameLabel.TabIndex = 7;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(64, 203);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.addProductNameTextBox.TabIndex = 8;
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Location = new System.Drawing.Point(4, 246);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addProductInventoryLabel.TabIndex = 9;
            this.addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(64, 243);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(118, 20);
            this.addProductInventoryTextBox.TabIndex = 10;
            this.addProductInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductInventoryTextBox_KeyPress);
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Location = new System.Drawing.Point(20, 291);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.addProductPriceLabel.TabIndex = 11;
            this.addProductPriceLabel.Text = "Price";
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Location = new System.Drawing.Point(64, 284);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(118, 20);
            this.addProductPriceTextBox.TabIndex = 12;
            this.addProductPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductPriceTextBox_KeyPress);
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Location = new System.Drawing.Point(25, 338);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addProductMaxLabel.TabIndex = 13;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductMinLabel
            // 
            this.addProductMinLabel.AutoSize = true;
            this.addProductMinLabel.Location = new System.Drawing.Point(125, 338);
            this.addProductMinLabel.Name = "addProductMinLabel";
            this.addProductMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addProductMinLabel.TabIndex = 14;
            this.addProductMinLabel.Text = "Min";
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Location = new System.Drawing.Point(64, 335);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(41, 20);
            this.addProductMaxTextBox.TabIndex = 15;
            this.addProductMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductMaxTextBox_KeyPress);
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Location = new System.Drawing.Point(162, 335);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(41, 20);
            this.addProductMinTextBox.TabIndex = 16;
            this.addProductMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProductMinTextBox_KeyPress);
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Location = new System.Drawing.Point(566, 32);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(56, 22);
            this.addProductSearchButton.TabIndex = 17;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            this.addProductSearchButton.Click += new System.EventHandler(this.AddProductSearchButton_Click);
            // 
            // addProductSearchTextBox
            // 
            this.addProductSearchTextBox.Location = new System.Drawing.Point(623, 34);
            this.addProductSearchTextBox.Name = "addProductSearchTextBox";
            this.addProductSearchTextBox.Size = new System.Drawing.Size(165, 20);
            this.addProductSearchTextBox.TabIndex = 18;
            // 
            // addAssociatedPartButton
            // 
            this.addAssociatedPartButton.Location = new System.Drawing.Point(732, 241);
            this.addAssociatedPartButton.Name = "addAssociatedPartButton";
            this.addAssociatedPartButton.Size = new System.Drawing.Size(56, 22);
            this.addAssociatedPartButton.TabIndex = 19;
            this.addAssociatedPartButton.Text = "Add";
            this.addAssociatedPartButton.UseVisualStyleBackColor = true;
            this.addAssociatedPartButton.Click += new System.EventHandler(this.AddAssociatedPartButton_Click);
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(732, 445);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(56, 22);
            this.deleteAssociatedPartButton.TabIndex = 20;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(732, 473);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(56, 22);
            this.addProductCancelButton.TabIndex = 21;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.AddProductCancelButton_Click);
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(670, 473);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(56, 22);
            this.addProductSaveButton.TabIndex = 22;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.AddProductSaveButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 502);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.addAssociatedPartButton);
            this.Controls.Add(this.addProductSearchTextBox);
            this.Controls.Add(this.addProductSearchButton);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductMinLabel);
            this.Controls.Add(this.addProductMaxLabel);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductPriceLabel);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductIdTextBox);
            this.Controls.Add(this.addProductIdLabel);
            this.Controls.Add(this.addProductAssociatedPartsGridView);
            this.Controls.Add(this.addProductCandidateGridView);
            this.Controls.Add(this.addProductAssociatedPartsLabel);
            this.Controls.Add(this.addProductCandidatePartsLabel);
            this.Controls.Add(this.addProductFormLabel);
            this.Name = "AddProductForm";
            this.Text = "Add Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addProductCandidateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssociatedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductFormLabel;
        private System.Windows.Forms.Label addProductCandidatePartsLabel;
        private System.Windows.Forms.Label addProductAssociatedPartsLabel;
        private System.Windows.Forms.DataGridView addProductCandidateGridView;
        private System.Windows.Forms.DataGridView addProductAssociatedPartsGridView;
        private System.Windows.Forms.Label addProductIdLabel;
        private System.Windows.Forms.TextBox addProductIdTextBox;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.Label addProductMinLabel;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.Button addProductSearchButton;
        private System.Windows.Forms.TextBox addProductSearchTextBox;
        private System.Windows.Forms.Button addAssociatedPartButton;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button addProductSaveButton;
    }
}