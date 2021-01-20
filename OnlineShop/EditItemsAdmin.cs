using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
            MenuListBox.DisplayMember = "ShowItemsList"; //parodys  dishesList'e esancia info
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
            if (UserNameTextBox.Text == string.Empty || DetailsTextBox.Text == string.Empty || PriceTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            {     
                  Item i = new Item();

                i.Name = UserNameTextBox.Text;
                i.Details = DetailsTextBox.Text;
                i.Price = double.Parse(PriceTextBox.Text); // string convert to double
                i.CategoryID = (int)CategoryNumericBox.Value;

                SqliteDataAccess.SaveItem(i);

                LoadItemsList();
                UserNameTextBox.Clear();
                DetailsTextBox.Clear();
                PriceTextBox.Clear();

                MessageBox.Show("New record added");
            }
            }


        private void RemoveItemButton_Click(object sender, EventArgs e) //naikinu irasa
        {  
            Item selectedItem = (Item)MenuListBox.SelectedItem;
            SqliteDataAccess.DeleteItem(selectedItem);
            LoadItemsList();

            MessageBox.Show("Record deleted");

        }

        private void SaveNewItemButton_Click(object sender, EventArgs e)  //Pakeicia kaina
        {
            Item selectedItem = (Item)MenuListBox.SelectedItem;
            selectedItem.Price = double.Parse(NewPriceTextBox.Text);
            SqliteDataAccess.UpdateItem(selectedItem);
            LoadItemsList();

            NewPriceTextBox.Clear();

            MessageBox.Show("Record updateded");              

        }

        private void NewPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
