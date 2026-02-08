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
    public partial class InventoryForm : Form
    {
        Inventory Inventory = new Inventory();
        Form MenuForm;
        public InventoryForm(Form menuForm, int userId)
        {
            InitializeComponent();
            Inventory.UsersId = userId; 
            inventoryDataGridView.DataSource = Inventory.getInventory();
            this.inventoryDataGridView.RowsDefaultCellStyle.BackColor = Color.Ivory;
            inventoryDataGridView.BackgroundColor = Color.Cornsilk;
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
                Inventory.InventoryId = int.Parse(idTextBox.Text);
                Inventory.InventoryName = nameTextBox.Text;
                Inventory.InventoryQuantity = int.Parse(quantityTextBox.Text);
                Inventory.InventoryCost = int.Parse(costTextBox.Text);

                var added = Inventory.addInventory(Inventory);

                if (added == true)
                {
                    MessageBox.Show("Ingredient succesfully added");
                    inventoryDataGridView.DataSource = Inventory.getInventory();
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    quantityTextBox.Clear();
                    costTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ingredient was not added");
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
                Inventory.InventoryId = int.Parse(idTextBox.Text);
                Inventory.InventoryName = nameTextBox.Text;
                Inventory.InventoryQuantity = int.Parse(quantityTextBox.Text);
                Inventory.InventoryCost = int.Parse(costTextBox.Text);

                var edited = Inventory.editInventory(Inventory);

                if (edited == true)
                {
                    MessageBox.Show("Ingredient succesfully edited");
                    inventoryDataGridView.DataSource = Inventory.getInventory();
                    idTextBox.Clear();
                    nameTextBox.Clear();
                    quantityTextBox.Clear();
                    costTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ingredient was not edited");
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Inventory.InventoryId = int.Parse(idTextBox.Text);
            //Inventory.InventoryName = nameTextBox.Text;
            //Inventory.InventoryQuantity = int.Parse(quantityTextBox.Text);
            //Inventory.InventoryCost = int.Parse(costTextBox.Text);

            var deleted = Inventory.removeQuantity(Inventory);

            if (deleted == true)
            {
                MessageBox.Show("Ingredient succesfully deleted");
                inventoryDataGridView.DataSource = Inventory.getInventory();
                idTextBox.Clear();
                nameTextBox.Clear();
                quantityTextBox.Clear();
                costTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Ingredient was not deleted");
            }
        }
    }
}
