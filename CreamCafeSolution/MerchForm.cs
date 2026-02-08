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
    public partial class MerchForm : Form
    {
        Merch Merch = new Merch();
        private Form MenuForm;
        public MerchForm(Form menuForm, int userId)
        {
            InitializeComponent();
            Merch.UsersId = userId;
            merchDataGridView.DataSource = Merch.getMerch();
            MenuForm = menuForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuForm.Show();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == string.Empty || nameTextBox.Text == string.Empty || quantityTextBox.Text == string.Empty
                || costTextBox.Text == string.Empty)
            {
                MessageBox.Show("Add all inofrmation");

            }
            else
            {
                Merch.MerchId = int.Parse(idTextBox.Text);
                Merch.MerchName = nameTextBox.Text;
                Merch.MerchQuantity = int.Parse(quantityTextBox.Text);
                Merch.MerchCost = int.Parse(costTextBox.Text);

                var added = Merch.addMerch(Merch);

                if (added == true)
                {
                    MessageBox.Show("Merch succesfully added");
                    merchDataGridView.DataSource = Merch.getMerch();
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    quantityTextBox.Clear();
                    costTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Merch was not added");
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == string.Empty || nameTextBox.Text == string.Empty || quantityTextBox.Text == string.Empty
                || costTextBox.Text == string.Empty)
            {
                MessageBox.Show("Add all inofrmation");

            }
            else
            {
                Merch.MerchId = int.Parse(idTextBox.Text);
                Merch.MerchName = nameTextBox.Text;
                Merch.MerchQuantity = int.Parse(quantityTextBox.Text);
                Merch.MerchCost = int.Parse(costTextBox.Text);

                var edited = Merch.editMerch(Merch);

                if (edited == true)
                {
                    MessageBox.Show("Merch succesfully edited");
                    merchDataGridView.DataSource = Merch.getMerch();
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    quantityTextBox.Clear();
                    costTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Merch was not edited");
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Merch.MerchId = int.Parse(idTextBox.Text);

            var deleted = Merch.deleteMerch(Merch);

            if (deleted == true)
            {
                MessageBox.Show("Merch succesfully deleted");
                merchDataGridView.DataSource = Merch.getMerch();
                idTextBox.Clear();
                nameTextBox.Clear();
                quantityTextBox.Clear();
                costTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Merch was not deleted");
            }
        }
    }
}
