namespace OnlineShop
{
    partial class iJewelryOnlineShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iJewelryOnlineShopForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddToBagButton = new System.Windows.Forms.Button();
            this.EditItemsListButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShoppingBagListBox = new System.Windows.Forms.ListBox();
            this.ShoppingBagLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(624, 93);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 37;
            this.PictureBox.TabStop = false;
            // 
            // MenuListBox
            // 
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.Location = new System.Drawing.Point(12, 111);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(498, 134);
            this.MenuListBox.TabIndex = 42;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(517, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 134);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(402, 253);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(52, 13);
            this.QuantityLabel.TabIndex = 44;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(460, 251);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.QuantityNumericUpDown.TabIndex = 45;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // AddToBagButton
            // 
            this.AddToBagButton.Location = new System.Drawing.Point(405, 277);
            this.AddToBagButton.Name = "AddToBagButton";
            this.AddToBagButton.Size = new System.Drawing.Size(105, 23);
            this.AddToBagButton.TabIndex = 46;
            this.AddToBagButton.Text = "Add to Bag";
            this.AddToBagButton.UseVisualStyleBackColor = true;
            this.AddToBagButton.Click += new System.EventHandler(this.AddToBagButton_Click);
            // 
            // EditItemsListButton
            // 
            this.EditItemsListButton.Location = new System.Drawing.Point(532, 442);
            this.EditItemsListButton.Name = "EditItemsListButton";
            this.EditItemsListButton.Size = new System.Drawing.Size(105, 23);
            this.EditItemsListButton.TabIndex = 48;
            this.EditItemsListButton.Text = "Edit Items List";
            this.EditItemsListButton.UseVisualStyleBackColor = true;
            this.EditItemsListButton.Click += new System.EventHandler(this.EditItemsListButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(144, 442);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(120, 23);
            this.ConfirmButton.TabIndex = 54;
            this.ConfirmButton.Text = "Confirm and Pay";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 442);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveButton.TabIndex = 53;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(149, 407);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 52;
            this.TotalLabel.Text = "Total: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShoppingBagListBox
            // 
            this.ShoppingBagListBox.FormattingEnabled = true;
            this.ShoppingBagListBox.Location = new System.Drawing.Point(12, 277);
            this.ShoppingBagListBox.Name = "ShoppingBagListBox";
            this.ShoppingBagListBox.Size = new System.Drawing.Size(252, 121);
            this.ShoppingBagListBox.TabIndex = 50;
            this.ShoppingBagListBox.SelectedIndexChanged += new System.EventHandler(this.ShoppingBagListBox_SelectedIndexChanged);
            // 
            // ShoppingBagLabel
            // 
            this.ShoppingBagLabel.AutoSize = true;
            this.ShoppingBagLabel.Location = new System.Drawing.Point(9, 258);
            this.ShoppingBagLabel.Name = "ShoppingBagLabel";
            this.ShoppingBagLabel.Size = new System.Drawing.Size(105, 13);
            this.ShoppingBagLabel.TabIndex = 49;
            this.ShoppingBagLabel.Text = "Your Shopping Bag: ";
            // 
            // iJewelryOnlineShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 487);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShoppingBagListBox);
            this.Controls.Add(this.ShoppingBagLabel);
            this.Controls.Add(this.EditItemsListButton);
            this.Controls.Add(this.AddToBagButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.PictureBox);
            this.Name = "iJewelryOnlineShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iJewelry Shop";
            this.Load += new System.EventHandler(this.iJewelryOnlineShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button AddToBagButton;
        private System.Windows.Forms.Button EditItemsListButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ShoppingBagListBox;
        private System.Windows.Forms.Label ShoppingBagLabel;
    }
}