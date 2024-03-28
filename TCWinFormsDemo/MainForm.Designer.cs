﻿namespace TCWinFormsDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.partLabel = new System.Windows.Forms.Label();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productLabel = new System.Windows.Forms.Label();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.exitMainFormButton = new System.Windows.Forms.Button();
            this.productBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outsourcedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.AutoSize = true;
            this.mainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabel.Location = new System.Drawing.Point(9, 7);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(268, 24);
            this.mainFormLabel.TabIndex = 0;
            this.mainFormLabel.Text = "Inventory Management System";
            // 
            // partGridView
            // 
            this.partGridView.AutoGenerateColumns = false;
            this.partGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.partPriceDataGridViewTextBoxColumn,
            this.partInStockDataGridViewTextBoxColumn,
            this.partMinDataGridViewTextBoxColumn,
            this.partMaxDataGridViewTextBoxColumn});
            this.partGridView.DataSource = this.partBindingSource;
            this.partGridView.Location = new System.Drawing.Point(31, 94);
            this.partGridView.Margin = new System.Windows.Forms.Padding(2);
            this.partGridView.Name = "partGridView";
            this.partGridView.RowTemplate.Height = 24;
            this.partGridView.Size = new System.Drawing.Size(471, 210);
            this.partGridView.TabIndex = 1;
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLabel.Location = new System.Drawing.Point(31, 72);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(41, 17);
            this.partLabel.TabIndex = 2;
            this.partLabel.Text = "Parts";
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(324, 310);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(56, 22);
            this.addPartButton.TabIndex = 3;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(385, 310);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(56, 22);
            this.modifyPartButton.TabIndex = 4;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(446, 310);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(56, 22);
            this.deletePartButton.TabIndex = 5;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(335, 72);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(56, 22);
            this.searchPartButton.TabIndex = 6;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(396, 72);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(107, 20);
            this.partSearchTextBox.TabIndex = 7;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            // 
            // partPriceDataGridViewTextBoxColumn
            // 
            this.partPriceDataGridViewTextBoxColumn.DataPropertyName = "PartPrice";
            this.partPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.partPriceDataGridViewTextBoxColumn.Name = "partPriceDataGridViewTextBoxColumn";
            // 
            // partInStockDataGridViewTextBoxColumn
            // 
            this.partInStockDataGridViewTextBoxColumn.DataPropertyName = "PartInStock";
            this.partInStockDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.partInStockDataGridViewTextBoxColumn.Name = "partInStockDataGridViewTextBoxColumn";
            // 
            // partMinDataGridViewTextBoxColumn
            // 
            this.partMinDataGridViewTextBoxColumn.DataPropertyName = "PartMin";
            this.partMinDataGridViewTextBoxColumn.HeaderText = "Min";
            this.partMinDataGridViewTextBoxColumn.Name = "partMinDataGridViewTextBoxColumn";
            // 
            // partMaxDataGridViewTextBoxColumn
            // 
            this.partMaxDataGridViewTextBoxColumn.DataPropertyName = "PartMax";
            this.partMaxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.partMaxDataGridViewTextBoxColumn.Name = "partMaxDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(TCWinFormsDemo.Part);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(551, 72);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(64, 17);
            this.productLabel.TabIndex = 8;
            this.productLabel.Text = "Products";
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(855, 72);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(56, 22);
            this.productSearchButton.TabIndex = 9;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(917, 72);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(106, 20);
            this.productSearchTextBox.TabIndex = 10;
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(551, 94);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(471, 210);
            this.productGridView.TabIndex = 11;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(825, 310);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(56, 22);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(886, 310);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(56, 22);
            this.modifyProductButton.TabIndex = 13;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(946, 310);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(56, 22);
            this.deleteProductButton.TabIndex = 14;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // exitMainFormButton
            // 
            this.exitMainFormButton.Location = new System.Drawing.Point(946, 333);
            this.exitMainFormButton.Name = "exitMainFormButton";
            this.exitMainFormButton.Size = new System.Drawing.Size(56, 22);
            this.exitMainFormButton.TabIndex = 15;
            this.exitMainFormButton.Text = "Exit";
            this.exitMainFormButton.UseVisualStyleBackColor = true;
            // 
            // productBindingSouce
            // 
            this.productBindingSouce.DataSource = typeof(TCWinFormsDemo.Product);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(TCWinFormsDemo.Inventory);
            // 
            // inHouseBindingSource
            // 
            this.inHouseBindingSource.DataSource = typeof(TCWinFormsDemo.InHouse);
            // 
            // outsourcedBindingSource
            // 
            this.outsourcedBindingSource.DataSource = typeof(TCWinFormsDemo.Outsourced);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 466);
            this.Controls.Add(this.exitMainFormButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.productSearchTextBox);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.partSearchTextBox);
            this.Controls.Add(this.searchPartButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.partGridView);
            this.Controls.Add(this.mainFormLabel);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button exitMainFormButton;
        private System.Windows.Forms.BindingSource productBindingSouce;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource inHouseBindingSource;
        private System.Windows.Forms.BindingSource outsourcedBindingSource;
    }
}

