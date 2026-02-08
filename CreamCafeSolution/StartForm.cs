using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreamCafeSolution
{
    public partial class StartForm : Form
    {
        int userId;
        public StartForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("D");
            timeLabel.Text = DateTime.Now.ToString("t");
        }

        public static string connection = ConfigurationManager.ConnectionStrings["CreamCafeSolution"].ConnectionString;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;


            if (userName == String.Empty || password == String.Empty) 
            {
                if(userName == String.Empty)
                {
                    MessageBox.Show("Enter username to login ");
                }
                else 
                {
                    MessageBox.Show("Enter password to login ");
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select (UsersId) from Users Where UsersName=@UsersName AND UsersPassword= @UsersPassword", con))
                    {
                        cmd.Parameters.AddWithValue("@UsersName", userName);
                        cmd.Parameters.AddWithValue("@UsersPassword", password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            userId = (int)reader["UsersId"];
                            reader.Close();
                            MenuForm menu = new MenuForm(userId);
                            this.Hide();
                            menu.ShowDialog();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Try again");
                        }

                    }
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm(this);
            reg.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changedLanguage = new ChangeLanguage();
            switch (comboBox1.SelectedIndex) 
            {
                case 0: changedLanguage.updateConfig("language", "en");
                    Application.Restart();
                    break;
                case 1:
                    changedLanguage.updateConfig("language", "fr-CA");
                    Application.Restart();
                    break;
                case 2:
                    changedLanguage.updateConfig("language", "es");
                    Application.Restart();
                    break;
                case 3:
                    changedLanguage.updateConfig("language", "gu-IN");
                    Application.Restart();
                    break;
            }
        }
    }
}
