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
    public partial class Form3 : Form
    {
        private const string connectionString = "Server=127.0.0.1;Port=3306;Database=user_passwords;Uid=root;Pwd=mypass;";

        public Form3()
        {
            InitializeComponent();

            this.AcceptButton = btn_save;
        }
        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_save.PerformClick();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            string website_link = txt_url.Text;
            string website_name = txt_wbsitname.Text;
            string username = txt_username.Text;
            string password = txt_pw.Text;
            bool is_social = chk_social.Checked;
            bool is_edu = chk_edu.Checked;

            if (!(chk_social.Checked || chk_edu.Checked|| txt_url == null || txt_wbsitname == null || txt_username == null || txt_pw == null))
            {
                MessageBox.Show("Fill everything then choose between Social Media and Education");
            }


            else { 


            // Save credentials to the database
            if (SaveCredentialsToDatabase(website_link, website_name, username, password, is_social, is_edu))
            {
                MessageBox.Show("Credentials saved successfully!");
                // You may choose to close the form or reset the input fields after saving
                this.Close();
                //ResetInputFields();
            }
            else
            {
                MessageBox.Show("Error saving credentials. Please try again.");
            }
        }
        }

        private bool SaveCredentialsToDatabase(string website_link,string website_name, string username, string password, bool is_social, bool is_edu)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO website_credentials (website_link,website_name, username, password,is_social,is_edu) VALUES (@website_link,@website_name, @username, @password,@is_social, @is_edu)", connection))
                {
                    cmd.Parameters.AddWithValue("@website_link", website_link);
                    cmd.Parameters.AddWithValue ("@website_name", website_name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@is_social", is_social);
                    cmd.Parameters.AddWithValue("@is_edu", is_edu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Optional: Add a method to reset input fields
        private void ResetInputFields()
        {
            txt_url.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_pw.Text = string.Empty;
            chk_edu.Checked = false;
            chk_social.Checked = false;


        }
    }
}
