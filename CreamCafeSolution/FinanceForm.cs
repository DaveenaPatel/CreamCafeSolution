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
    public partial class FinanceForm : Form
    {
        private Form MenuForm;

        public FinanceForm(Form menuForm)
        {
            InitializeComponent();
            MenuForm = menuForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuForm.Show();
            this.Close();
        }


        private void grossProfitButton_Click(object sender, EventArgs e)
        {
            double revenue = Double.Parse(revenueTextBox.Text);
            double costOfGoods = Double.Parse(costOfGoodsTextBox.Text);
            double operatingExpenses = Double.Parse(operatingExpensesTextBox.Text);

            double totalCost = costOfGoods + operatingExpenses;

            totalCostTextBox.Text = totalCost.ToString("C");

            double result = revenue - costOfGoods;
            resultTextBox.Text = result.ToString("C");
        }

        private void netProfitbutton_Click(object sender, EventArgs e)
        {
            double revenue = Double.Parse(revenueTextBox.Text);
            double costOfGoods = Double.Parse(costOfGoodsTextBox.Text);
            double operatingExpenses = Double.Parse(operatingExpensesTextBox.Text);

            double totalCost = costOfGoods + operatingExpenses;

            totalCostTextBox.Text = totalCost.ToString("C");

            double result = revenue - totalCost;
            resultTextBox.Text= result.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            revenueTextBox.Clear();
            costOfGoodsTextBox.Clear();
            operatingExpensesTextBox.Clear();
            totalCostTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
