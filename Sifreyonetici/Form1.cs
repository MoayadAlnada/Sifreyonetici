using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sifreyonetici
{
    public partial class Form1 : Form
    {
        private string loggedInUsername;


        private const string connectionString = "Server=127.0.0.1;Port=3306;Database=user_passwords;Uid=root;Pwd=mypass;";
        private string oneTimePassword;


        public Form1()
        {


            InitializeComponent();
            InitializeSearchBox();
            btn_item1.Click += Btn_Item_Click;
            btn_item2.Click += Btn_Item_Click;
            btn_item3.Click += Btn_Item_Click;
            btn_item4.Click += Btn_Item_Click;
            btn_item5.Click += Btn_Item_Click;
            btn_item6.Click += Btn_Item_Click;

            // Set up timer
            Timer timer = new Timer();
            timer.Interval = 10000; // 10 seconds
            timer.Tick += Timer_Tick;
            timer.Start();



        }

        public Form1(string username) : this()
        {
            // Store the logged-in username
            loggedInUsername = username;

            // Update the leb_accname label
            leb_accname.Text = loggedInUsername;
        }



        private void Btn_Item_Click(object sender, EventArgs e)
        {
            UpdateOneTimePassword();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateOneTimePassword();
        }

        private void UpdateOneTimePassword()
        {
            // Generate a new one-time password
            oneTimePassword = GenerateOneTimePassword();

            // Update the label with the new one-time password
            leb_onetimepw.Text = oneTimePassword;
        }

        private string GenerateOneTimePassword()
        {
            // Generate three random digits
            Random random = new Random();
            int firstThreeDigits = random.Next(100, 999);
            int lastThreeDigits = random.Next(100, 999);

            // Create the formatted password
            string formattedPassword = $"{firstThreeDigits}*{lastThreeDigits}";

            return formattedPassword;
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_dshbrd.Visible = false;
            pnl_show.Visible = false;
            pnl_data.Visible = false;


        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnDashboard.Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(26, 85, 120);

            pnl_dshbrd.Visible = true;
            pnl_show.Visible = false;
            pnl_data.Visible = false;
            // Fetch and display the number of items
            int itemCount = GetItemCountFromDatabase();
            txt_itemsayisi.Text = "You have " + itemCount.ToString() + " Items :)";
        }



        private int GetItemCountFromDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM website_credentials", connection))
                {
                    // Replace 'your_table_name' with the actual name of your table

                    // ExecuteScalar returns the first column of the first row
                    // which is the count in this case
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void BtnSocMed_Click(object sender, EventArgs e)
        {
            pnl_dshbrd.Visible = false;
            pnl_show.Visible = false;
            pnl_data.Visible = true;
            pnlNav.Height = Btn_Soc.Height;
            pnlNav.Top = Btn_Soc.Top;
            pnlNav.Left = BtnDashboard.Left;
            Btn_Soc.BackColor = Color.FromArgb(26, 85, 120);
            Btn_Soc.BackColor = Color.FromArgb(0, 102, 204);
            DataTable socialData = GetSocialUserData();

            // Update labels based on the retrieved data
            UpdateSocialLabels(socialData);

        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_signout.Height;
            pnlNav.Top = btn_signout.Top;
            pnlNav.Left = BtnDashboard.Left;
            btn_signout.BackColor = Color.FromArgb(26, 85, 120);
            this.Close();

            // Open a new instance of Form2
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void BtnEdu_Click(object sender, EventArgs e)
        {
            // Hide the dashboard panel
            pnl_dshbrd.Visible = false;
            pnl_show.Visible = false;
            pnl_data.Visible = true;

            // Retrieve education-related data from the database
            DataTable eduData = GetEducationUserData();

            // Update labels based on the retrieved data
            UpdateEducationLabels(eduData); 
            pnl_dshbrd.Visible = false;
            pnlNav.Height = BtnEdu.Height;
            pnlNav.Top = BtnEdu.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnEdu.BackColor = Color.FromArgb(26, 85, 120);
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(0, 102, 204);
        }
        private void BtnSocMed_Leave(object sender, EventArgs e)
        {

        }
        private void BtnEdu_Leave(object sender, EventArgs e)
        {
            BtnEdu.BackColor = Color.FromArgb(0, 102, 204);
        }
        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_signout.BackColor = Color.FromArgb(0, 102, 204);
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            GenerateOneTimePassword();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void round1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeSearchBox()
        {

        }
        private void txt_srch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_srch_Clicked(object sender, EventArgs e)
        {
            txt_srch.Text = "";
            txt_srch.Focus(); // Set focus to the textbox
        }

        private void btn_newitem_Leave(object sender, EventArgs e)
        {

        }

        private void btn_newitem_Click(object sender, EventArgs e)
        {
            
            btn_newitem.BackColor = Color.Blue;
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_dshbrd_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_item1_Click(object sender, EventArgs e)
        {
            pnl_show.Visible = true;
            string websiteName = lab_item1.Text;
            string username = lab_username1.Text;

            if (string.IsNullOrEmpty(websiteName) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Website name or username is empty.");
                return;
            }

            // Access database to get password and website link
            var credentials = GetCredentialsFromDatabase(websiteName, username);

            if (credentials != null)
            {
                // Update labels with retrieved data
                lab_showusername.Text = credentials.Username;
                lab_showpw.Text = credentials.Password;
                lab_showapplink.Text = credentials.WebsiteLink;
                lab_showappname.Text = websiteName;
                pnl_show.Visible = true;
            }
            else
            {
                MessageBox.Show("Credentials not found in the database.");
            }
        }

        private Credentials GetCredentialsFromDatabase(string websiteName, string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT password, website_link FROM website_credentials WHERE website_name = @websiteName AND username = @username", connection))
                {
                    cmd.Parameters.AddWithValue("@websiteName", websiteName);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read password and website link from the database
                            string password = reader["password"].ToString();
                            string websiteLink = reader["website_link"].ToString();

                            return new Credentials
                            {
                                Password = password,
                                WebsiteLink = websiteLink,
                                Username = username
                            };
                        }
                    }
                }
            }

            return null; // Return null if credentials are not found
        }

        // Define a class to hold credentials
        private class Credentials
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string WebsiteLink { get; set; }
        }


        private void btn_item1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_item1_Leave(object sender, EventArgs e)
        {
           
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_item2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item2_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btn_item3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item3_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btn_item4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item4_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btn_item5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item5_MouseLeave(object sender, EventArgs e)
        {

        }
        private void btn_item6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_item6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetSocialUserData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT `website_name`, `username` FROM `user_passwords`.`website_credentials` WHERE `is_social` = true", connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving social user data: {ex.Message}");
            }

            return dataTable;
        }


        private void UpdateSocialLabels(DataTable socialData)
        {
            // Clear existing labels
            ClearSocialLabels();

            // Update labels based on the retrieved data
            for (int i = 0; i < 6; i++)
            {
                if (i < socialData.Rows.Count)
                {
                    string websiteName = socialData.Rows[i]["website_name"].ToString();
                    string username = socialData.Rows[i]["username"].ToString();

                    Label websiteLabel = Controls.Find($"lab_item{i + 1}", true)[0] as Label;
                    Label usernameLabel = Controls.Find($"lab_username{i + 1}", true)[0] as Label;

                    if (websiteLabel != null && usernameLabel != null)
                    {
                        websiteLabel.Text = string.IsNullOrEmpty(websiteName) ? "--" : websiteName;
                        usernameLabel.Text = string.IsNullOrEmpty(username) ? "--" : username;
                    }
                }
                else
                {
                    // If there is no data for the current index, set labels to "--"
                    Label websiteLabel = Controls.Find($"lab_item{i + 1}", true)[0] as Label;
                    Label usernameLabel = Controls.Find($"lab_username{i + 1}", true)[0] as Label;

                    if (websiteLabel != null && usernameLabel != null)
                    {
                        websiteLabel.Text = "--";
                        usernameLabel.Text = "--";
                    }
                }
            }
        }



        private void ClearSocialLabels()
        {
            // Clear existing labels
            for (int i = 1; i <= 6; i++)
            {
                Label websiteLabel = Controls.Find($"lab_item{i}", true)[0] as Label;
                Label usernameLabel = Controls.Find($"lab_username{i}", true)[0] as Label;

                if (websiteLabel != null && usernameLabel != null)
                {
                    websiteLabel.Text = string.Empty;
                    usernameLabel.Text = string.Empty;
                }
            }
        }

        private void btn_item2_Click(object sender, EventArgs e)
        {
             HandleButtonClick(lab_item2, lab_username2);
             pnl_show.Visible = true;
        }

        private void btn_item3_Click(object sender, EventArgs e)
        {
            
            HandleButtonClick(lab_item3, lab_username3);
            pnl_show.Visible = true;
        }

        private void btn_item4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(lab_item4, lab_username4);
            pnl_show.Visible = true;
        }

        private void btn_item5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(lab_item5, lab_username5);
            pnl_show.Visible = true;
        }

        private void btn_item6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(lab_item6, lab_username6);
            pnl_show.Visible = true;
        }

        private void HandleButtonClick(Label websiteLabel, Label usernameLabel)
        {
            // Get website name and username from labels
            string websiteName = websiteLabel.Text;
            string username = usernameLabel.Text;

            if (string.IsNullOrEmpty(websiteName) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Website name or username is empty.");
                return;
            }

            // Access database to get password and website link
            var credentials = GetCredentialsFromDatabase(websiteName, username);

            if (credentials != null)
            {
                // Update labels with retrieved data
                lab_showusername.Text = credentials.Username;
                lab_showpw.Text = credentials.Password;
                lab_showapplink.Text = credentials.WebsiteLink;
                lab_showappname.Text = websiteName;
            }
            else
            {
                MessageBox.Show("Credentials not found in the database.");
            }

        }


        private DataTable GetEducationUserData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT website_name, username FROM website_credentials WHERE is_edu = true", connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void UpdateEducationLabels(DataTable eduData)
        {
            // Clear existing labels
            ClearEducationLabels();

            // Update labels based on the retrieved data
            for (int i = 0; i < eduData.Rows.Count && i < 6; i++)
            {
                string websiteName = eduData.Rows[i]["website_name"].ToString();
                string username = eduData.Rows[i]["username"].ToString();

                Label websiteLabel = Controls.Find($"lab_item{i + 1}", true)[0] as Label;
                Label usernameLabel = Controls.Find($"lab_username{i + 1}", true)[0] as Label;

                if (websiteLabel != null && usernameLabel != null)
                {
                    websiteLabel.Text = string.IsNullOrEmpty(websiteName) ? "--" : websiteName;
                    usernameLabel.Text = string.IsNullOrEmpty(username) ? "--" : username;
                }
            }
        }

        private void ClearEducationLabels()
        {
            // Clear existing labels
            for (int i = 1; i <= 6; i++)
            {
                Label websiteLabel = Controls.Find($"lab_item{i}", true)[0] as Label;
                Label usernameLabel = Controls.Find($"lab_username{i}", true)[0] as Label;

                if (websiteLabel != null && usernameLabel != null)
                {
                    websiteLabel.Text = "--";
                    usernameLabel.Text = "--";
                }
            }
        }

        private void lab_timer_Click(object sender, EventArgs e)
        {

        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            pnl_show.Visible= true;
            pnl_data.Visible= true;
            pnl_dshbrd.Visible= false;
            string searchTerm = txt_srch.Text.Trim();

            // Clear existing data
            ClearSearchResults();

            // Check if the search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Execute the search and fill the results
            SearchDatabase(searchTerm);
        }

        private void SearchDatabase(string searchTerm)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Perform a search query on the database
                    string query = "SELECT website_name, username FROM website_credentials " +
                                   $"WHERE website_name LIKE '%{searchTerm}%' OR " +
                                   $"username LIKE '%{searchTerm}%' OR " +
                                   $"password LIKE '%{searchTerm}%' OR " +
                                   $"website_link LIKE '%{searchTerm}%'";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Fill the search results into the labels
                            for (int i = 0; i < Math.Min(dataTable.Rows.Count, 6); i++)
                            {
                                Label websiteLabel = Controls.Find($"lab_item{i + 1}", true).FirstOrDefault() as Label;
                                Label usernameLabel = Controls.Find($"lab_username{i + 1}", true).FirstOrDefault() as Label;

                                if (websiteLabel != null && usernameLabel != null)
                                {
                                    websiteLabel.Text = dataTable.Rows[i]["website_name"].ToString();
                                    usernameLabel.Text = dataTable.Rows[i]["username"].ToString();
                                }
                            }

                            // Fill "--" for remaining labels if there are less than 6 results
                            for (int i = dataTable.Rows.Count; i < 6; i++)
                            {
                                Label websiteLabel = Controls.Find($"lab_item{i + 1}", true).FirstOrDefault() as Label;
                                Label usernameLabel = Controls.Find($"lab_username{i + 1}", true).FirstOrDefault() as Label;

                                if (websiteLabel != null && usernameLabel != null)
                                {
                                    websiteLabel.Text = "--";
                                    usernameLabel.Text = "--";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching the database: " + ex.Message);
            }
        }

        private void ClearSearchResults()
        {
            // Clear existing data in labels
            for (int i = 1; i <= 6; i++)
            {
                Label websiteLabel = Controls.Find($"lab_item{i}", true).FirstOrDefault() as Label;
                Label usernameLabel = Controls.Find($"lab_username{i}", true).FirstOrDefault() as Label;

                if (websiteLabel != null && usernameLabel != null)
                {
                    websiteLabel.Text = "--";
                    usernameLabel.Text = "--";
                }
            }
        }

        private void txt_srch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pressing Enter key triggers the search button
                btn_srch.PerformClick();
            }
        }

        private void txt_itemsayisi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }
    }
}
