namespace OnlineShop
{
    partial class EditItemsAdminForm
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
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.AddNewItemGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryIDLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UpdateItemGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveNewItemButton = new System.Windows.Forms.Button();
            this.NewPriceTextBox = new System.Windows.Forms.TextBox();
            this.NewPriceLabel = new System.Windows.Forms.Label();
            this.UpdateItemNameTextBox = new System.Windows.Forms.TextBox();
            this.NameUpdateItemLabel = new System.Windows.Forms.Label();
            this.RemoveItemGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.RemoveNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CategoryNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AddNewItemGroupBox.SuspendLayout();
            this.UpdateItemGroupBox.SuspendLayout();
            this.RemoveItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuListBox
            // 
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.Location = new System.Drawing.Point(12, 38);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(625, 108);
            this.MenuListBox.TabIndex = 43;
            // 
            // AddNewItemGroupBox
            // 
            this.AddNewItemGroupBox.Controls.Add(this.CategoryNumericBox);
            this.AddNewItemGroupBox.Controls.Add(this.SaveButton);
            this.AddNewItemGroupBox.Controls.Add(this.DetailsTextBox);
            this.AddNewItemGroupBox.Controls.Add(this.PriceTextBox);
            this.AddNewItemGroupBox.Controls.Add(this.CategoryIDLabel);
            this.AddNewItemGroupBox.Controls.Add(this.DetailsLabel);
            this.AddNewItemGroupBox.Controls.Add(this.PriceLabel);
            this.AddNewItemGroupBox.Controls.Add(this.UserNameTextBox);
            this.AddNewItemGroupBox.Controls.Add(this.NameLabel);
            this.AddNewItemGroupBox.Location = new System.Drawing.Point(12, 165);
            this.AddNewItemGroupBox.Name = "AddNewItemGroupBox";
            this.AddNewItemGroupBox.Size = new System.Drawing.Size(246, 223);
            this.AddNewItemGroupBox.TabIndex = 45;
            this.AddNewItemGroupBox.TabStop = false;
            this.AddNewItemGroupBox.Text = "Add New Item";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(103, 171);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 23);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Location = new System.Drawing.Point(92, 73);
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.Size = new System.Drawing.Size(135, 20);
            this.DetailsTextBox.TabIndex = 43;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(92, 109);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(135, 20);
            this.PriceTextBox.TabIndex = 42;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(580, 11);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(57, 20);
            this.CategoryTextBox.TabIndex = 40;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // CategoryIDLabel
            // 
            this.CategoryIDLabel.AutoSize = true;
            this.CategoryIDLabel.Location = new System.Drawing.Point(16, 147);
            this.CategoryIDLabel.Name = "CategoryIDLabel";
            this.CategoryIDLabel.Size = new System.Drawing.Size(72, 13);
            this.CategoryIDLabel.TabIndex = 38;
            this.CategoryIDLabel.Text = "Category_ID: ";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(41, 76);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(45, 13);
            this.DetailsLabel.TabIndex = 37;
            this.DetailsLabel.Text = "Details: ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(49, 112);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(37, 13);
            this.PriceLabel.TabIndex = 36;
            this.PriceLabel.Text = "Price: ";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(92, 37);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.UserNameTextBox.TabIndex = 35;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(45, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name: ";
            // 
            // UpdateItemGroupBox
            // 
            this.UpdateItemGroupBox.Controls.Add(this.SaveNewItemButton);
            this.UpdateItemGroupBox.Controls.Add(this.NewPriceTextBox);
            this.UpdateItemGroupBox.Controls.Add(this.NewPriceLabel);
            this.UpdateItemGroupBox.Controls.Add(this.UpdateItemNameTextBox);
            this.UpdateItemGroupBox.Controls.Add(this.NameUpdateItemLabel);
            this.UpdateItemGroupBox.Location = new System.Drawing.Point(316, 165);
            this.UpdateItemGroupBox.Name = "UpdateItemGroupBox";
            this.UpdateItemGroupBox.Size = new System.Drawing.Size(246, 116);
            this.UpdateItemGroupBox.TabIndex = 46;
            this.UpdateItemGroupBox.TabStop = false;
            this.UpdateItemGroupBox.Text = "Update Item";
            // 
            // SaveNewItemButton
            // 
            this.SaveNewItemButton.Location = new System.Drawing.Point(104, 79);
            this.SaveNewItemButton.Name = "SaveNewItemButton";
            this.SaveNewItemButton.Size = new System.Drawing.Size(105, 23);
            this.SaveNewItemButton.TabIndex = 34;
            this.SaveNewItemButton.Text = "Update";
            this.SaveNewItemButton.UseVisualStyleBackColor = true;
            this.SaveNewItemButton.Click += new System.EventHandler(this.SaveNewItemButton_Click);
            // 
            // NewPriceTextBox
            // 
            this.NewPriceTextBox.Location = new System.Drawing.Point(90, 53);
            this.NewPriceTextBox.Name = "NewPriceTextBox";
            this.NewPriceTextBox.Size = new System.Drawing.Size(135, 20);
            this.NewPriceTextBox.TabIndex = 43;
            // 
            // NewPriceLabel
            // 
            this.NewPriceLabel.AutoSize = true;
            this.NewPriceLabel.Location = new System.Drawing.Point(22, 56);
            this.NewPriceLabel.Name = "NewPriceLabel";
            this.NewPriceLabel.Size = new System.Drawing.Size(62, 13);
            this.NewPriceLabel.TabIndex = 37;
            this.NewPriceLabel.Text = "New Price: ";
            // 
            // UpdateItemNameTextBox
            // 
            this.UpdateItemNameTextBox.Location = new System.Drawing.Point(90, 19);
            this.UpdateItemNameTextBox.Name = "UpdateItemNameTextBox";
            this.UpdateItemNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.UpdateItemNameTextBox.TabIndex = 35;
            // 
            // NameUpdateItemLabel
            // 
            this.NameUpdateItemLabel.AutoSize = true;
            this.NameUpdateItemLabel.Location = new System.Drawing.Point(43, 22);
            this.NameUpdateItemLabel.Name = "NameUpdateItemLabel";
            this.NameUpdateItemLabel.Size = new System.Drawing.Size(41, 13);
            this.NameUpdateItemLabel.TabIndex = 34;
            this.NameUpdateItemLabel.Text = "Name: ";
            // 
            // RemoveItemGroupBox
            // 
            this.RemoveItemGroupBox.Controls.Add(this.RemoveItemButton);
            this.RemoveItemGroupBox.Controls.Add(this.RemoveNameTextBox);
            this.RemoveItemGroupBox.Controls.Add(this.label2);
            this.RemoveItemGroupBox.Location = new System.Drawing.Point(316, 309);
            this.RemoveItemGroupBox.Name = "RemoveItemGroupBox";
            this.RemoveItemGroupBox.Size = new System.Drawing.Size(246, 79);
            this.RemoveItemGroupBox.TabIndex = 47;
            this.RemoveItemGroupBox.TabStop = false;
            this.RemoveItemGroupBox.Text = "Remove Item";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(104, 45);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveItemButton.TabIndex = 34;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // RemoveNameTextBox
            // 
            this.RemoveNameTextBox.Location = new System.Drawing.Point(90, 19);
            this.RemoveNameTextBox.Name = "RemoveNameTextBox";
            this.RemoveNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.RemoveNameTextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name: ";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 23);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CategoryNumericBox
            // 
            this.CategoryNumericBox.Location = new System.Drawing.Point(92, 145);
            this.CategoryNumericBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CategoryNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CategoryNumericBox.Name = "CategoryNumericBox";
            this.CategoryNumericBox.Size = new System.Drawing.Size(135, 20);
            this.CategoryNumericBox.TabIndex = 49;
            this.CategoryNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EditItemsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 400);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemoveItemGroupBox);
            this.Controls.Add(this.UpdateItemGroupBox);
            this.Controls.Add(this.AddNewItemGroupBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.MenuListBox);
            this.Name = "EditItemsAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Items Admin";
            this.Load += new System.EventHandler(this.EditItemsAdminForm_Load);
            this.AddNewItemGroupBox.ResumeLayout(false);
            this.AddNewItemGroupBox.PerformLayout();
            this.UpdateItemGroupBox.ResumeLayout(false);
            this.UpdateItemGroupBox.PerformLayout();
            this.RemoveItemGroupBox.ResumeLayout(false);
            this.RemoveItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.GroupBox AddNewItemGroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DetailsTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryIDLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox UpdateItemGroupBox;
        private System.Windows.Forms.Button SaveNewItemButton;
        private System.Windows.Forms.TextBox NewPriceTextBox;
        private System.Windows.Forms.Label NewPriceLabel;
        private System.Windows.Forms.TextBox UpdateItemNameTextBox;
        private System.Windows.Forms.Label NameUpdateItemLabel;
        private System.Windows.Forms.GroupBox RemoveItemGroupBox;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.TextBox RemoveNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.NumericUpDown CategoryNumericBox;
    }
}