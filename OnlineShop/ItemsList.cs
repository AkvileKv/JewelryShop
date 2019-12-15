using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OnlineShop
{
    public partial class iJewelryOnlineShopForm : Form
    {
        List<Item> itemsList = new List<Item>();
        Bag bag = new Bag();

        public iJewelryOnlineShopForm()
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

        private void ShowBagButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingBagForm f1 = new ShoppingBagForm();
            f1.ShowDialog();
            this.Close();
        }

        private void EditItemsListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditItemsAdminForm f1 = new EditItemsAdminForm();
            f1.ShowDialog();
            this.Close();
        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iJewelryOnlineShopForm_Load(object sender, EventArgs e)
        {

        }

        private void AddToBagButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)MenuListBox.SelectedItem; //selectedItem- mano pazymeta preke
            /*

            if (QuantityNumericUpDown.Value == 1)
            {
                bag.addItem(selectedItem); // pazymeta patiekala pridedu i bag kintamaji

                TotalTextBox.Text = bag.totalPrice + " Eur"; //pakeiciu reiksme

                ShoppingBagListBox.Items.Add(MenuListBox.SelectedItem); //I shopping bag prideda pasirinkta irasa is Menu
                ShoppingBagListBox.DisplayMember = "ShowNameAndPrice";
            }
            else
            {
                for (int i = 0; i < QuantityNumericUpDown.Value; i++)
                {
                    bag.addDish(selectedDish);

                    textBox1.Text = bag.totalPrice + " Eur";

                    ShoppingBagListBox.Items.Add(MenuListBox.SelectedItem);
                    ShoppingBagListBox.DisplayMember = "ShowNameAndPrice";
                }
            }
            */

            if (MenuListBox.SelectedItem != null)
            {
                MessageBox.Show("Added to your shopping bag");
                return;
            }
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
