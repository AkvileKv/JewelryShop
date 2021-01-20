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
    public partial class ItemsUserForm : Form
    {
        List<Item> itemsList = new List<Item>();
        Bag bag = new Bag();

        public ItemsUserForm()
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
            MenuListBox.DisplayMember = "ShowItemsList"; //parodys  liste esancia info
        }

        private void ItemsUser_Load(object sender, EventArgs e)
        {

        }

        private void ShowBagButton_Click(object sender, EventArgs e)
        {
          
        }

        private void AddToBagButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)MenuListBox.SelectedItem; //selectedItem- mano pazymeta preke

            if (QuantityNumericUpDown.Value == 1)
            {
                bag.AddItem(selectedItem); // pazymeta patiekala pridedu i bag kintamaji
                textBox1.Text = bag.totalPrice + " Eur"; //pakeiciu reiksme

                ShoppingBagListBox.Items.Add(MenuListBox.SelectedItem); //I shopping bag prideda pasirinkta irasa is Menu
                ShoppingBagListBox.DisplayMember = "ShowNameAndPrice";
            }
            else
            {
                for (int i = 0; i < QuantityNumericUpDown.Value; i++)
                {
                    bag.AddItem(selectedItem);
                    textBox1.Text = bag.totalPrice + " Eur";

                    ShoppingBagListBox.Items.Add(MenuListBox.SelectedItem);
                    ShoppingBagListBox.DisplayMember = "ShowNameAndPrice";
                }
            }

            if (MenuListBox.SelectedItem != null)
            {
                MessageBox.Show("Added to your shopping bag");
                return;
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ShoppingBagListBox.SelectedItem;
            bag.RemoveItem(selectedItem);
            textBox1.Text = bag.totalPrice + " Eur"; //pakeiciu reiksme
            ShoppingBagListBox.Items.Remove(ShoppingBagListBox.SelectedItem);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ShoppingBagListBox.SelectedItem; // Reikalingas bag.vatPrice gavimui
            bag.calculateVatPrice(selectedItem);

            StreamWriter File = new StreamWriter("Receipt_File.txt"); //kiekviena karta istrina ir is naujo iraso
            DateTime time = DateTime.Now;
            File.Write("          ***RECEIPT***            \r\n\n");
            File.Write("Date:        ");
            File.Write(time.ToString("dd/MM/yyyy hh:mm:ss\r\n\n"));
            File.Write("---------------------------------\r\n");

            for (int i = 0; i < ShoppingBagListBox.Items.Count; i++)
            {
                Item d = (Item)ShoppingBagListBox.Items[i];  //STRINGA
                File.Write(d.Name + "    " + d.Price + "Eur\r\n");
            }
            File.Write("---------------------------------\r\n");
            File.Write("\r\n");
            File.Write("Sub Total:             " + bag.totalPrice + "  Eur\r\n");
            File.Write("Grand TOTAL (VAT 21%): " + bag.vatPrice + "Eur\r\n");
            File.Write("\r\n");

            File.Close();

            ShoppingBagListBox.Items.Clear();
            textBox1.Clear();


            MessageBox.Show("Your payment receipt was successfully formed");
            return;
        }
    }
}
