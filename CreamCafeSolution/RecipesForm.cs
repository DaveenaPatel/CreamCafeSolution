using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreamCafeSolution
{
    public partial class RecipesForm : Form
    {
        private Form MenuForm;

        public RecipesForm(Form menuForm)
        {
            InitializeComponent();
            MenuForm = menuForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuForm.Show();
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string eProfit = expectedProfitTextBox.Text;
            string cost = costTextBox.Text;
            string ingredients = ingredientTextBox.Text;

            string filePath = "C:\\Users\\Public\\Documents\\Recipe.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath)) 
                {
                    sw.WriteLine("Recipe Id: " + id);
                    sw.WriteLine("Name: " + name);
                    sw.WriteLine("Expected Profit: " + eProfit);
                    sw.WriteLine("Ingredients: " + ingredients);
                }
                MessageBox.Show("Recipe was printed");

            }
            catch 
            {
                MessageBox.Show("There was an error");
            }

        }
    }
}
