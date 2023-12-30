using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreyonetici
{
    public partial class Form2 : Form
    {
        private const string connectionString = "Server=127.0.0.1;Port=3306;Database=user_passwords;Uid=root;Pwd=mypass;";

        public Form2()
        {
            InitializeComponent();
            txt_username.KeyPress += TextBoxes_KeyPress;
            txt_pw.KeyPress += TextBoxes_KeyPress;
        }

        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_pw.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                Form1 form1 = new Form1(username);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string username = txt_pw.Text;
            string password = txt_username.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (SignUp(username, password))
            {
                MessageBox.Show("Sign up successful!");
            }
            else
            {
                MessageBox.Show("Error during sign up. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        private bool SignUp(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
