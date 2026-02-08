using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee;


namespace Menu
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            this.Hide();
            form.showDialogue();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {

        }

        private void merchButton_Click(object sender, EventArgs e)
        {

        }

        private void recipesButton_Click(object sender, EventArgs e)
        {

        }

        private void ingredienceButton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
