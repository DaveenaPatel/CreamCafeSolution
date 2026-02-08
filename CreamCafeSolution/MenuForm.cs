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
    public partial class MenuForm : Form
    {
        int UserId;
        public MenuForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm(this, UserId);
            this.Hide();
            employeesForm.ShowDialog();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            FinanceForm financeForm = new FinanceForm(this);
            this.Hide();
            financeForm.ShowDialog();
        }

        private void merchButton_Click(object sender, EventArgs e)
        {
            MerchForm merchForm = new MerchForm(this ,UserId);
            this.Hide();
            merchForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingredienceButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(this, UserId);
            this.Hide();
            inventoryForm.ShowDialog();
        }

        private void recipesButton_Click(object sender, EventArgs e)
        {
            RecipesForm recipesForm = new RecipesForm(this);
            this.Hide();
            recipesForm.ShowDialog();
        }
    }
}
