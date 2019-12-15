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
            this.BraceletsButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.RingsButton = new System.Windows.Forms.Button();
            this.NecklacesButton = new System.Windows.Forms.Button();
            this.EarringsButton = new System.Windows.Forms.Button();
            this.CharmsButton = new System.Windows.Forms.Button();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddToBagButton = new System.Windows.Forms.Button();
            this.ShowBagButton = new System.Windows.Forms.Button();
            this.EditItemsListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BraceletsButton
            // 
            this.BraceletsButton.Location = new System.Drawing.Point(12, 116);
            this.BraceletsButton.Name = "BraceletsButton";
            this.BraceletsButton.Size = new System.Drawing.Size(120, 30);
            this.BraceletsButton.TabIndex = 35;
            this.BraceletsButton.Text = "Bracelets";
            this.BraceletsButton.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(624, 98);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 37;
            this.PictureBox.TabStop = false;
            // 
            // RingsButton
            // 
            this.RingsButton.Location = new System.Drawing.Point(516, 116);
            this.RingsButton.Name = "RingsButton";
            this.RingsButton.Size = new System.Drawing.Size(120, 30);
            this.RingsButton.TabIndex = 38;
            this.RingsButton.Text = "Rings";
            this.RingsButton.UseVisualStyleBackColor = true;
            // 
            // NecklacesButton
            // 
            this.NecklacesButton.Location = new System.Drawing.Point(390, 116);
            this.NecklacesButton.Name = "NecklacesButton";
            this.NecklacesButton.Size = new System.Drawing.Size(120, 30);
            this.NecklacesButton.TabIndex = 39;
            this.NecklacesButton.Text = "Necklaces";
            this.NecklacesButton.UseVisualStyleBackColor = true;
            // 
            // EarringsButton
            // 
            this.EarringsButton.Location = new System.Drawing.Point(264, 116);
            this.EarringsButton.Name = "EarringsButton";
            this.EarringsButton.Size = new System.Drawing.Size(120, 30);
            this.EarringsButton.TabIndex = 40;
            this.EarringsButton.Text = "Earrings";
            this.EarringsButton.UseVisualStyleBackColor = true;
            // 
            // CharmsButton
            // 
            this.CharmsButton.Location = new System.Drawing.Point(138, 116);
            this.CharmsButton.Name = "CharmsButton";
            this.CharmsButton.Size = new System.Drawing.Size(120, 30);
            this.CharmsButton.TabIndex = 41;
            this.CharmsButton.Text = "Charms";
            this.CharmsButton.UseVisualStyleBackColor = true;
            // 
            // MenuListBox
            // 
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.Location = new System.Drawing.Point(12, 161);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(498, 134);
            this.MenuListBox.TabIndex = 42;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(516, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 134);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(402, 303);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(52, 13);
            this.QuantityLabel.TabIndex = 44;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(460, 301);
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
            this.AddToBagButton.Location = new System.Drawing.Point(405, 327);
            this.AddToBagButton.Name = "AddToBagButton";
            this.AddToBagButton.Size = new System.Drawing.Size(105, 23);
            this.AddToBagButton.TabIndex = 46;
            this.AddToBagButton.Text = "Add to Bag";
            this.AddToBagButton.UseVisualStyleBackColor = true;
            this.AddToBagButton.Click += new System.EventHandler(this.AddToBagButton_Click);
            // 
            // ShowBagButton
            // 
            this.ShowBagButton.Location = new System.Drawing.Point(531, 327);
            this.ShowBagButton.Name = "ShowBagButton";
            this.ShowBagButton.Size = new System.Drawing.Size(105, 23);
            this.ShowBagButton.TabIndex = 47;
            this.ShowBagButton.Text = "Show Bag";
            this.ShowBagButton.UseVisualStyleBackColor = true;
            this.ShowBagButton.Click += new System.EventHandler(this.ShowBagButton_Click);
            // 
            // EditItemsListButton
            // 
            this.EditItemsListButton.Location = new System.Drawing.Point(12, 365);
            this.EditItemsListButton.Name = "EditItemsListButton";
            this.EditItemsListButton.Size = new System.Drawing.Size(105, 23);
            this.EditItemsListButton.TabIndex = 48;
            this.EditItemsListButton.Text = "Edit Items List";
            this.EditItemsListButton.UseVisualStyleBackColor = true;
            this.EditItemsListButton.Click += new System.EventHandler(this.EditItemsListButton_Click);
            // 
            // iJewelryOnlineShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 400);
            this.Controls.Add(this.EditItemsListButton);
            this.Controls.Add(this.ShowBagButton);
            this.Controls.Add(this.AddToBagButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.CharmsButton);
            this.Controls.Add(this.EarringsButton);
            this.Controls.Add(this.NecklacesButton);
            this.Controls.Add(this.RingsButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BraceletsButton);
            this.Name = "iJewelryOnlineShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iJewelry Online Shop";
            this.Load += new System.EventHandler(this.iJewelryOnlineShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BraceletsButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button RingsButton;
        private System.Windows.Forms.Button NecklacesButton;
        private System.Windows.Forms.Button EarringsButton;
        private System.Windows.Forms.Button CharmsButton;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button AddToBagButton;
        private System.Windows.Forms.Button ShowBagButton;
        private System.Windows.Forms.Button EditItemsListButton;
    }
}