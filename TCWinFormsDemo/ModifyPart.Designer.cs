namespace TCWinFormsDemo
{
    partial class ModifyPartForm
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
            this.modPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.modPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.modPartIdLabel = new System.Windows.Forms.Label();
            this.modPartIdTextBox = new System.Windows.Forms.TextBox();
            this.modPartNameLabel = new System.Windows.Forms.Label();
            this.modPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modPartInventoryLabel = new System.Windows.Forms.Label();
            this.modPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modPartPriceLabel = new System.Windows.Forms.Label();
            this.modPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.modPartMaxLabel = new System.Windows.Forms.Label();
            this.modPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modPartMinLabel = new System.Windows.Forms.Label();
            this.modPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modPartMacIdCompNameLabel = new System.Windows.Forms.Label();
            this.modPartMacIdCompNameTextBox = new System.Windows.Forms.TextBox();
            this.modPartSaveButton = new System.Windows.Forms.Button();
            this.modPartCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modPartInHouseRadioButton
            // 
            this.modPartInHouseRadioButton.AutoSize = true;
            this.modPartInHouseRadioButton.Checked = true;
            this.modPartInHouseRadioButton.Location = new System.Drawing.Point(95, 25);
            this.modPartInHouseRadioButton.Name = "modPartInHouseRadioButton";
            this.modPartInHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.modPartInHouseRadioButton.TabIndex = 0;
            this.modPartInHouseRadioButton.TabStop = true;
            this.modPartInHouseRadioButton.Text = "In-House";
            this.modPartInHouseRadioButton.UseVisualStyleBackColor = true;
            this.modPartInHouseRadioButton.CheckedChanged += new System.EventHandler(this.ModPartInHouseRadioButton_CheckedChanged);
            // 
            // modPartOutsourcedRadioButton
            // 
            this.modPartOutsourcedRadioButton.AutoSize = true;
            this.modPartOutsourcedRadioButton.Location = new System.Drawing.Point(200, 25);
            this.modPartOutsourcedRadioButton.Name = "modPartOutsourcedRadioButton";
            this.modPartOutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.modPartOutsourcedRadioButton.TabIndex = 1;
            this.modPartOutsourcedRadioButton.TabStop = true;
            this.modPartOutsourcedRadioButton.Text = "Outsourced";
            this.modPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.modPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.ModPartOutsourcedRadioButton_CheckedChanged);
            // 
            // modPartIdLabel
            // 
            this.modPartIdLabel.AutoSize = true;
            this.modPartIdLabel.Location = new System.Drawing.Point(46, 90);
            this.modPartIdLabel.Name = "modPartIdLabel";
            this.modPartIdLabel.Size = new System.Drawing.Size(18, 13);
            this.modPartIdLabel.TabIndex = 2;
            this.modPartIdLabel.Text = "ID";
            // 
            // modPartIdTextBox
            // 
            this.modPartIdTextBox.Enabled = false;
            this.modPartIdTextBox.Location = new System.Drawing.Point(95, 86);
            this.modPartIdTextBox.Name = "modPartIdTextBox";
            this.modPartIdTextBox.ReadOnly = true;
            this.modPartIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartIdTextBox.TabIndex = 3;
            // 
            // modPartNameLabel
            // 
            this.modPartNameLabel.AutoSize = true;
            this.modPartNameLabel.Location = new System.Drawing.Point(28, 128);
            this.modPartNameLabel.Name = "modPartNameLabel";
            this.modPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modPartNameLabel.TabIndex = 4;
            this.modPartNameLabel.Text = "Name";
            // 
            // modPartNameTextBox
            // 
            this.modPartNameTextBox.Location = new System.Drawing.Point(95, 124);
            this.modPartNameTextBox.Name = "modPartNameTextBox";
            this.modPartNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartNameTextBox.TabIndex = 5;
            // 
            // modPartInventoryLabel
            // 
            this.modPartInventoryLabel.AutoSize = true;
            this.modPartInventoryLabel.Location = new System.Drawing.Point(19, 166);
            this.modPartInventoryLabel.Name = "modPartInventoryLabel";
            this.modPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.modPartInventoryLabel.TabIndex = 6;
            this.modPartInventoryLabel.Text = "Inventory";
            // 
            // modPartInventoryTextBox
            // 
            this.modPartInventoryTextBox.Location = new System.Drawing.Point(95, 163);
            this.modPartInventoryTextBox.Name = "modPartInventoryTextBox";
            this.modPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartInventoryTextBox.TabIndex = 7;
            this.modPartInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModPartInventoryTextBox_KeyPress);
            // 
            // modPartPriceLabel
            // 
            this.modPartPriceLabel.AutoSize = true;
            this.modPartPriceLabel.Location = new System.Drawing.Point(6, 206);
            this.modPartPriceLabel.Name = "modPartPriceLabel";
            this.modPartPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.modPartPriceLabel.TabIndex = 8;
            this.modPartPriceLabel.Text = "Price / Cost";
            // 
            // modPartPriceTextBox
            // 
            this.modPartPriceTextBox.Location = new System.Drawing.Point(95, 203);
            this.modPartPriceTextBox.Name = "modPartPriceTextBox";
            this.modPartPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartPriceTextBox.TabIndex = 9;
            this.modPartPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModPartPriceTextBox_KeyPress);
            // 
            // modPartMaxLabel
            // 
            this.modPartMaxLabel.AutoSize = true;
            this.modPartMaxLabel.Location = new System.Drawing.Point(39, 250);
            this.modPartMaxLabel.Name = "modPartMaxLabel";
            this.modPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modPartMaxLabel.TabIndex = 10;
            this.modPartMaxLabel.Text = "Max";
            // 
            // modPartMaxTextBox
            // 
            this.modPartMaxTextBox.Location = new System.Drawing.Point(95, 246);
            this.modPartMaxTextBox.Name = "modPartMaxTextBox";
            this.modPartMaxTextBox.Size = new System.Drawing.Size(76, 20);
            this.modPartMaxTextBox.TabIndex = 11;
            this.modPartMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModPartMaxTextBox_KeyPress);
            // 
            // modPartMinLabel
            // 
            this.modPartMinLabel.AutoSize = true;
            this.modPartMinLabel.Location = new System.Drawing.Point(190, 250);
            this.modPartMinLabel.Name = "modPartMinLabel";
            this.modPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modPartMinLabel.TabIndex = 12;
            this.modPartMinLabel.Text = "Min";
            // 
            // modPartMinTextBox
            // 
            this.modPartMinTextBox.Location = new System.Drawing.Point(235, 246);
            this.modPartMinTextBox.Name = "modPartMinTextBox";
            this.modPartMinTextBox.Size = new System.Drawing.Size(76, 20);
            this.modPartMinTextBox.TabIndex = 13;
            this.modPartMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModPartMinTextBox_KeyPress);
            // 
            // modPartMacIdCompNameLabel
            // 
            this.modPartMacIdCompNameLabel.AutoSize = true;
            this.modPartMacIdCompNameLabel.Location = new System.Drawing.Point(21, 292);
            this.modPartMacIdCompNameLabel.Name = "modPartMacIdCompNameLabel";
            this.modPartMacIdCompNameLabel.Size = new System.Drawing.Size(62, 13);
            this.modPartMacIdCompNameLabel.TabIndex = 14;
            this.modPartMacIdCompNameLabel.Text = "Machine ID";
            // 
            // modPartMacIdCompNameTextBox
            // 
            this.modPartMacIdCompNameTextBox.Location = new System.Drawing.Point(116, 288);
            this.modPartMacIdCompNameTextBox.Name = "modPartMacIdCompNameTextBox";
            this.modPartMacIdCompNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartMacIdCompNameTextBox.TabIndex = 15;
            // 
            // modPartSaveButton
            // 
            this.modPartSaveButton.Location = new System.Drawing.Point(220, 317);
            this.modPartSaveButton.Name = "modPartSaveButton";
            this.modPartSaveButton.Size = new System.Drawing.Size(56, 22);
            this.modPartSaveButton.TabIndex = 16;
            this.modPartSaveButton.Text = "Save";
            this.modPartSaveButton.UseVisualStyleBackColor = true;
            this.modPartSaveButton.Click += new System.EventHandler(this.ModPartSaveButton_Click);
            // 
            // modPartCancelButton
            // 
            this.modPartCancelButton.Location = new System.Drawing.Point(286, 317);
            this.modPartCancelButton.Name = "modPartCancelButton";
            this.modPartCancelButton.Size = new System.Drawing.Size(56, 22);
            this.modPartCancelButton.TabIndex = 17;
            this.modPartCancelButton.Text = "Cancel";
            this.modPartCancelButton.UseVisualStyleBackColor = true;
            this.modPartCancelButton.Click += new System.EventHandler(this.ModPartCancelButton_Click);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 366);
            this.Controls.Add(this.modPartCancelButton);
            this.Controls.Add(this.modPartSaveButton);
            this.Controls.Add(this.modPartMacIdCompNameTextBox);
            this.Controls.Add(this.modPartMacIdCompNameLabel);
            this.Controls.Add(this.modPartMinTextBox);
            this.Controls.Add(this.modPartMinLabel);
            this.Controls.Add(this.modPartMaxTextBox);
            this.Controls.Add(this.modPartMaxLabel);
            this.Controls.Add(this.modPartPriceTextBox);
            this.Controls.Add(this.modPartPriceLabel);
            this.Controls.Add(this.modPartInventoryTextBox);
            this.Controls.Add(this.modPartInventoryLabel);
            this.Controls.Add(this.modPartNameTextBox);
            this.Controls.Add(this.modPartNameLabel);
            this.Controls.Add(this.modPartIdTextBox);
            this.Controls.Add(this.modPartIdLabel);
            this.Controls.Add(this.modPartOutsourcedRadioButton);
            this.Controls.Add(this.modPartInHouseRadioButton);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part Form";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton modPartInHouseRadioButton;
        private System.Windows.Forms.RadioButton modPartOutsourcedRadioButton;
        private System.Windows.Forms.Label modPartIdLabel;
        private System.Windows.Forms.TextBox modPartIdTextBox;
        private System.Windows.Forms.Label modPartNameLabel;
        private System.Windows.Forms.TextBox modPartNameTextBox;
        private System.Windows.Forms.Label modPartInventoryLabel;
        private System.Windows.Forms.TextBox modPartInventoryTextBox;
        private System.Windows.Forms.Label modPartPriceLabel;
        private System.Windows.Forms.TextBox modPartPriceTextBox;
        private System.Windows.Forms.Label modPartMaxLabel;
        private System.Windows.Forms.TextBox modPartMaxTextBox;
        private System.Windows.Forms.Label modPartMinLabel;
        private System.Windows.Forms.TextBox modPartMinTextBox;
        private System.Windows.Forms.Label modPartMacIdCompNameLabel;
        private System.Windows.Forms.TextBox modPartMacIdCompNameTextBox;
        private System.Windows.Forms.Button modPartSaveButton;
        private System.Windows.Forms.Button modPartCancelButton;
    }
}