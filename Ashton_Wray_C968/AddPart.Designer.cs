namespace Ashton_Wray_C968
{
    partial class AddPartForm
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
            this.addPartFormLabel = new System.Windows.Forms.Label();
            this.addPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartIdLabel = new System.Windows.Forms.Label();
            this.addPartIdTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMacIdCompNameLabel = new System.Windows.Forms.Label();
            this.addPartMacIdCompNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartFormLabel
            // 
            this.addPartFormLabel.AutoSize = true;
            this.addPartFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartFormLabel.Location = new System.Drawing.Point(10, 11);
            this.addPartFormLabel.Name = "addPartFormLabel";
            this.addPartFormLabel.Size = new System.Drawing.Size(82, 24);
            this.addPartFormLabel.TabIndex = 0;
            this.addPartFormLabel.Text = "Add Part";
            // 
            // addPartInHouseRadioButton
            // 
            this.addPartInHouseRadioButton.AutoSize = true;
            this.addPartInHouseRadioButton.Location = new System.Drawing.Point(143, 7);
            this.addPartInHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPartInHouseRadioButton.Name = "addPartInHouseRadioButton";
            this.addPartInHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.addPartInHouseRadioButton.TabIndex = 1;
            this.addPartInHouseRadioButton.TabStop = true;
            this.addPartInHouseRadioButton.Text = "In-House";
            this.addPartInHouseRadioButton.UseVisualStyleBackColor = true;
            this.addPartInHouseRadioButton.CheckedChanged += new System.EventHandler(this.AddPartInHouseRadioButton_CheckedChanged);
            // 
            // addPartOutsourcedRadioButton
            // 
            this.addPartOutsourcedRadioButton.AutoSize = true;
            this.addPartOutsourcedRadioButton.Location = new System.Drawing.Point(242, 7);
            this.addPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPartOutsourcedRadioButton.Name = "addPartOutsourcedRadioButton";
            this.addPartOutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.addPartOutsourcedRadioButton.TabIndex = 2;
            this.addPartOutsourcedRadioButton.TabStop = true;
            this.addPartOutsourcedRadioButton.Text = "Outsourced";
            this.addPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.AddPartOutsourcedRadioButton_CheckedChanged);
            // 
            // addPartIdLabel
            // 
            this.addPartIdLabel.AutoSize = true;
            this.addPartIdLabel.Location = new System.Drawing.Point(61, 54);
            this.addPartIdLabel.Name = "addPartIdLabel";
            this.addPartIdLabel.Size = new System.Drawing.Size(18, 13);
            this.addPartIdLabel.TabIndex = 3;
            this.addPartIdLabel.Text = "ID";
            // 
            // addPartIdTextBox
            // 
            this.addPartIdTextBox.Enabled = false;
            this.addPartIdTextBox.Location = new System.Drawing.Point(97, 50);
            this.addPartIdTextBox.Name = "addPartIdTextBox";
            this.addPartIdTextBox.ReadOnly = true;
            this.addPartIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartIdTextBox.TabIndex = 4;
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Location = new System.Drawing.Point(43, 93);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addPartNameLabel.TabIndex = 5;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartNameTextBox.Location = new System.Drawing.Point(97, 89);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartNameTextBox.TabIndex = 6;
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(27, 132);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addPartInventoryLabel.TabIndex = 7;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(97, 128);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartInventoryTextBox.TabIndex = 8;
            this.addPartInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartInventoryTextBox_KeyPress);
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Location = new System.Drawing.Point(16, 176);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.addPartPriceLabel.TabIndex = 9;
            this.addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartPriceTextBox.Location = new System.Drawing.Point(97, 172);
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartPriceTextBox.TabIndex = 10;
            this.addPartPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartPriceTextBox_KeyPress);
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Location = new System.Drawing.Point(52, 220);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addPartMaxLabel.TabIndex = 11;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartMaxTextBox.Location = new System.Drawing.Point(97, 216);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(76, 20);
            this.addPartMaxTextBox.TabIndex = 12;
            this.addPartMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMaxTextBox_KeyPress);
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(206, 220);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addPartMinLabel.TabIndex = 13;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartMinTextBox.Location = new System.Drawing.Point(238, 218);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(76, 20);
            this.addPartMinTextBox.TabIndex = 14;
            this.addPartMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMinTextBox_KeyPress);
            // 
            // addPartMacIdCompNameLabel
            // 
            this.addPartMacIdCompNameLabel.AutoSize = true;
            this.addPartMacIdCompNameLabel.Location = new System.Drawing.Point(17, 258);
            this.addPartMacIdCompNameLabel.Name = "addPartMacIdCompNameLabel";
            this.addPartMacIdCompNameLabel.Size = new System.Drawing.Size(62, 13);
            this.addPartMacIdCompNameLabel.TabIndex = 15;
            this.addPartMacIdCompNameLabel.Text = "Machine ID";
            // 
            // addPartMacIdCompNameTextBox
            // 
            this.addPartMacIdCompNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartMacIdCompNameTextBox.Location = new System.Drawing.Point(97, 256);
            this.addPartMacIdCompNameTextBox.Name = "addPartMacIdCompNameTextBox";
            this.addPartMacIdCompNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPartMacIdCompNameTextBox.TabIndex = 16;
            this.addPartMacIdCompNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMacIdCompNameTextBox_KeyPress);
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(172, 321);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(56, 22);
            this.addPartSaveButton.TabIndex = 17;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.AddPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(262, 321);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(56, 22);
            this.addPartCancelButton.TabIndex = 18;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.AddPartCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 366);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.addPartMacIdCompNameTextBox);
            this.Controls.Add(this.addPartMacIdCompNameLabel);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIdTextBox);
            this.Controls.Add(this.addPartIdLabel);
            this.Controls.Add(this.addPartOutsourcedRadioButton);
            this.Controls.Add(this.addPartInHouseRadioButton);
            this.Controls.Add(this.addPartFormLabel);
            this.Name = "AddPartForm";
            this.Text = "Add Part Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartFormLabel;
        private System.Windows.Forms.RadioButton addPartInHouseRadioButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioButton;
        private System.Windows.Forms.Label addPartIdLabel;
        private System.Windows.Forms.TextBox addPartIdTextBox;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.Label addPartMacIdCompNameLabel;
        private System.Windows.Forms.TextBox addPartMacIdCompNameTextBox;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
    }
}