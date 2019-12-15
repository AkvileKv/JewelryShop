using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class EditItemsAdminForm : Form
    { 
        List<Item> itemsList = new List<Item>();

        public EditItemsAdminForm()
        {
            InitializeComponent(); 
            LoadItemsList();
        }

        private void LoadItemsList() //parodo mano turima sarasa
        {
            itemsList = SqliteDataAccess.LoadItems();
            WireUpItemsList();
        }

        private void WireUpItemsList()
        {
            MenuListBox.DataSource = null;
            MenuListBox.DataSource = itemsList;
            MenuListBox.DisplayMember = "ShowMenu"; //parodys  dishesList'e esancia info
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            iJewelryOnlineShopForm f1 = new iJewelryOnlineShopForm();
            f1.ShowDialog();
            this.Close();
        }

        private void EditItemsAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e) //irasau nauja irasa
        {
            Item i = new Item();

            i.Name = UserNameTextBox.Text;
            i.Details = DetailsTextBox.Text;
            i.Price = double.Parse(PriceTextBox.Text); // string convert to double
            i.CategoryID = (int)CategoryNumericBox.Value;

            SqliteDataAccess.SaveItem(i);
        

        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveItemButton_Click(object sender, EventArgs e) //naikinu irasa
        {
            Item i = new Item();

            RemoveNameTextBox.Text = i.Name;

            SqliteDataAccess.DeleteItem(i);
        }

        private void SaveNewItemButton_Click(object sender, EventArgs e)
        {
            Item u = new Item();

            UpdateItemNameTextBox.Text = u.Name;
            u.Price = double.Parse(NewPriceTextBox.Text);


            SqliteDataAccess.UpdateItem(u);
        }
    }
}
