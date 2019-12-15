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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInLogInButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            iJewelryOnlineShopForm f1 = new iJewelryOnlineShopForm();
            f1.ShowDialog();
            this.Close();

        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1iJewelryShop f1 = new Form1iJewelryShop();
            f1.ShowDialog();
            this.Close();
        }
    }
}
