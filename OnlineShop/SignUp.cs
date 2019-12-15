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
    public partial class SignUpForm : Form
    {
        List<Customer> customersList = new List<Customer>(); // ar reikia?

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();

            c.Username = UserNameTextBox.Text;
            c.Password = PasswordTextBox.Text;
            c.Name = FirstNameTextBox.Text;
            c.Surname = LastNameTextBox.Text;
            c.Email = EmailTextBox.Text;

            SqliteDataAccess.SaveCustomer(c);
            
            //-----------------------------------------------
            this.Hide();
            Form1iJewelryShop f3 = new Form1iJewelryShop();
            f3.ShowDialog();
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1iJewelryShop f1 = new Form1iJewelryShop();
            f1.ShowDialog();
            this.Close();
        }
    }
}
