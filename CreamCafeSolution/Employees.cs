using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreamCafeSolution
{
    internal class Employees
    {
        public int UsersId { get; set; }
        public int EmployeeId {  get; set; }
        public string EmployeeFName { get; set; }
        public string EmployeeLName { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public int EmployeeSalary { get; set; }
        public int EmployeeHoursWorked { get; set; }

        public static string connection = ConfigurationManager.ConnectionStrings["CreamCafeSolution"].ConnectionString;

        public DataTable getEmployees() 
        { 
            var datatable = new DataTable();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Employee Where UsersId=@UsersId", con)) 
                {
                    cmd.Parameters.AddWithValue("@UsersId", UsersId);

                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool addEmployees(Employees employees)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Insert into Employee (EmployeeId, EmployeeFName, EmployeeLName, EmployeeNumber, EmployeeEmail, " +
                    "EmployeeSalary, EmployeeHoursWorked, UsersId) Values (@EmployeeId, @EmployeeFName, " +
                    "@EmployeeLName, @EmployeeNumber, @EmployeeEmail, @EmployeeSalary, @EmployeeHoursWorked," +
                    " @UsersId)", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employees.EmployeeId);
                    cmd.Parameters.AddWithValue("@EmployeeFName", employees.EmployeeFName);
                    cmd.Parameters.AddWithValue("@EmployeeLName", employees.EmployeeLName);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", employees.EmployeeNumber);
                    cmd.Parameters.AddWithValue("@EmployeeEmail", employees.EmployeeEmail);
                    cmd.Parameters.AddWithValue("@EmployeeSalary", employees.EmployeeSalary);
                    cmd.Parameters.AddWithValue("@EmployeeHoursWorked", employees.EmployeeHoursWorked);
                    cmd.Parameters.AddWithValue("@UsersId", employees.UsersId);
                    row = cmd.ExecuteNonQuery();
                }
            }

            if (row > 0)
            {
                return true;
            }
            else 
            { 
                return false;
            }

        }

        public bool removeEmployee(Employees employees)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Delete From Employee Where EmployeeId=@EmployeeId AND UsersId=@UsersId", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employees.EmployeeId);
                    cmd.Parameters.AddWithValue("@UsersId", employees.UsersId);
                    row = cmd.ExecuteNonQuery();
                }
            }

            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editEmployee(Employees employees) 
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Update Employee set EmployeeId=@EmployeeId, EmployeeFName=@EmployeeFName, EmployeeLName=@EmployeeLName, EmployeeNumber=@EmployeeNumber, EmployeeEmail=@EmployeeEmail, EmployeeSalary=@EmployeeSalary, EmployeeHoursWorked=@EmployeeHoursWorked " +
                    "Where EmployeeId=@EmployeeId AND UsersId=@UsersId", con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employees.EmployeeId);
                    cmd.Parameters.AddWithValue("@EmployeeFName", employees.EmployeeFName);
                    cmd.Parameters.AddWithValue("@EmployeeLName", employees.EmployeeLName);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", employees.EmployeeNumber);
                    cmd.Parameters.AddWithValue("@EmployeeEmail", employees.EmployeeEmail);
                    cmd.Parameters.AddWithValue("@EmployeeSalary", employees.EmployeeSalary);
                    cmd.Parameters.AddWithValue("@EmployeeHoursWorked", employees.EmployeeHoursWorked);
                    cmd.Parameters.AddWithValue("@UsersId", employees.UsersId);
                    row = cmd.ExecuteNonQuery();
                }
            }

            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
