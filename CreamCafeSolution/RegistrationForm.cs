using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreamCafeSolution
{
    public partial class RegistrationForm : Form
    {
        Users user = new Users();
        StartForm StartForm;
        public RegistrationForm(StartForm startForm)
        {
            InitializeComponent();
            StartForm = startForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartForm.Show();
            this.Close();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string fname = fNameTextBox.Text;
            string lname = lNameTextBox.Text;
            string cafeName = cafeNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string userName = userNameTextBox.Text;
            string password = passwrodTextBox.Text;

            if (passwrodTextBox.Text == string.Empty || conformPasswordTextBox.Text == string.Empty || userNameTextBox.Text == string.Empty
                || phoneNumberTextBox.Text == string.Empty || emailTextBox.Text == string.Empty || cafeNameTextBox.Text == string.Empty
                || lNameTextBox.Text == string.Empty || fNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Add all informtaion", "Inforamtion error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (email.Contains("@") != true)
                {
                    MessageBox.Show("Enter Valid Email", "Inforamtion error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (passwrodTextBox.Text.Length < 8)
                    {
                        MessageBox.Show("Password needs to be 8 characters or longer");
                    }
                    else
                    {
                        if (password.Contains(fname) || password.Contains(lname) || password.Contains(cafeName))
                        {
                            MessageBox.Show("Password CAN NOT contian your name or cafe name");

                        }
                        else
                        {

                            if (passwrodTextBox.Text == conformPasswordTextBox.Text)
                            {
                                user.UsersName = userName;
                                user.UsersPassword = password;
                                user.UsersCafeName = cafeName;
                                user.UsersFName = fname;
                                user.UsersLName = lname;
                                user.UsersEmail = email;
                                user.PhoneNumber = phoneNumber;



                                bool added = user.addUser(user);
                                if (added == true)
                                {
                                    MessageBox.Show("Account has been created. You may now login");
                                    StartForm.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Try again. Account has not been created");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Password Confimation not successful");
                            }
                        }

                    }

                }
            }
        }

    }
}
