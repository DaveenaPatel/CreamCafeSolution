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
    public partial class EmployeesForm : Form
    {
        Employees employees = new Employees();
        private Form MenuForm;
        public EmployeesForm(Form menuForm, int userId)
        {
            InitializeComponent();
            employees.UsersId = userId;
            employeeDataGridView.DataSource = employees.getEmployees();
            MenuForm = menuForm;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == string.Empty || firstNameTextBox.Text == string.Empty || lastNameTextBox.Text == string.Empty ||
                numberTextBox.Text == string.Empty || emailTextBox.Text == string.Empty || salaryTextBox.Text == string.Empty || hoursWorkedTextBox.Text == string.Empty)
            {
                MessageBox.Show("Add all information");

            }
            else
            {
                employees.EmployeeId = int.Parse(idTextBox.Text);
                employees.EmployeeFName = firstNameTextBox.Text;
                employees.EmployeeLName = lastNameTextBox.Text;
                employees.EmployeeNumber = numberTextBox.Text;
                employees.EmployeeEmail = emailTextBox.Text;
                employees.EmployeeSalary = int.Parse(salaryTextBox.Text);
                employees.EmployeeHoursWorked = int.Parse(hoursWorkedTextBox.Text);

                var added = employees.addEmployees(employees);

                if (added == true)
                {
                    MessageBox.Show("Employee succesfully added");
                    employeeDataGridView.DataSource = employees.getEmployees();
                    idTextBox.Clear();
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    numberTextBox.Clear();
                    emailTextBox.Clear();
                    salaryTextBox.Clear();
                    hoursWorkedTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Employee was not added");
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == string.Empty || firstNameTextBox.Text == string.Empty || lastNameTextBox.Text == string.Empty ||
                numberTextBox.Text == string.Empty || emailTextBox.Text == string.Empty || salaryTextBox.Text == string.Empty || hoursWorkedTextBox.Text == string.Empty)
            {
                MessageBox.Show("Add all information");

            }
            else
            {
                employees.EmployeeId = int.Parse(idTextBox.Text);
                employees.EmployeeFName = firstNameTextBox.Text;
                employees.EmployeeLName = lastNameTextBox.Text;
                employees.EmployeeNumber = numberTextBox.Text;
                employees.EmployeeEmail = emailTextBox.Text;
                employees.EmployeeSalary = int.Parse(salaryTextBox.Text);
                employees.EmployeeHoursWorked = int.Parse(hoursWorkedTextBox.Text);

                var added = employees.editEmployee(employees);

                if (added == true)
                {
                    MessageBox.Show("Employee succesfully edited");
                    employeeDataGridView.DataSource = employees.getEmployees();
                    idTextBox.Clear();
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    numberTextBox.Clear();
                    emailTextBox.Clear();
                    salaryTextBox.Clear();
                    hoursWorkedTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Employee was not edited");
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            employees.EmployeeId = int.Parse(idTextBox.Text);

            var deleted = employees.removeEmployee(employees);


            if (deleted == true)
            {
                MessageBox.Show("Employee succesfully deleted");
                employeeDataGridView.DataSource = employees.getEmployees();
                idTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                numberTextBox.Clear();
                emailTextBox.Clear();
                salaryTextBox.Clear();
                hoursWorkedTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Employee was not deleted");
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuForm.Show();
            this.Close();
        }
    }
}
