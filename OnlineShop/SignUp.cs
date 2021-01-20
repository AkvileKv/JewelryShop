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
    public partial class SignUpForm : Form
    {
        List<Customer> customersList = new List<Customer>();
       
       // public string passwordText;
        //public string cipherText; //užšifruotas tekstas

        public SignUpForm()
        {
            InitializeComponent();
        }

        // Cikliškai generuoja raktą, kol jo ilgis nėra lygus įvesto password ilgiui
        public string GenerateKey(string passwordText, string key)
        {
            int passwordLength = passwordText.Length;

            for (int i = 0; ; i++)
            {
                if (passwordLength == i)
                    i = 0;
                if (key.Length == passwordText.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

        // grąžina užkoduotą tekstą, sugeneruotą rakto pagalba 
        public string CipherText(string passwordText, string key)
        {
            string cipherText = "";

            for (int i = 0; i < passwordText.Length; i++)
            {
                // konvertavimo diapazonas 0-127 
                int x = (passwordText[i] + key[i]) % 128;

                // konvertuojam i simbolius (ASCII)             
                x += '!'; // pradedam nuo !

                cipherText += (char)(x);
            }
            return cipherText;
        }

        private void GetStartedButton_Click(object sender, EventArgs e)
        { 
            if (UserNameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty || FirstNameTextBox.Text == string.Empty || LastNameTextBox.Text == string.Empty || EmailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            { //------tikrinimui, ar DB Customer lentelej jau yra ivestas username---------------
                string query = "SELECT * FROM Customer WHERE Username=@Username";
                SQLiteConnection conn = new SQLiteConnection("Data Source=iShopDB.db;Version=3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", UserNameTextBox.Text);
            //-----------------------------------------------------------------------------------
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0) //jei randa mano ieskoma username, igauna verte didesne nei 0
                {
                    MessageBox.Show("Username already exist");
                }
                else //sukuria nauja naudotoja-------------------------------
                {         
                    string keyword = "cat"; //slaptazodis turi buti ne trumpesnis uz key
                    string str = PasswordTextBox.Text;

                    string key = GenerateKey(str, keyword);
                    string cipherText = CipherText(str, key);

                    Customer c = new Customer();

                c.Username = UserNameTextBox.Text;
                c.Password = cipherText;  //  =PasswordTextBox.Text;
                c.Name = FirstNameTextBox.Text;
                c.Surname = LastNameTextBox.Text;
                c.Email = EmailTextBox.Text;

                SqliteDataAccess.SaveCustomer(c);

                MessageBox.Show("New User created"); 
                    
                    this.Hide(); 
                    Form1iJewelryShop f3 = new Form1iJewelryShop(); 
                    f3.ShowDialog(); 
                    this.Close() ;
                }                
            }          
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
