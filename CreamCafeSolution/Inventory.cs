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
    internal class Inventory
    {
        public int UsersId { get; set; }
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public int InventoryQuantity { get; set; }
        public int InventoryCost { get; set; }

        public static string connection = ConfigurationManager.ConnectionStrings["CreamCafeSolution"].ConnectionString;

        public DataTable getInventory()
        {
            var datatable = new DataTable();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Inventory Where UsersId=@UsersId", con))
                {
                    cmd.Parameters.AddWithValue("@UsersId", UsersId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool addInventory(Inventory inventory)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Insert into Inventory (InventoryId, ProductName, ProductQuantity, ProductCost, UsersId) Values " +
                    "(@InventoryId, @ProductName, @ProductQuantity, @ProductCost, @UsersId)", con))
                {
                    cmd.Parameters.AddWithValue("@InventoryId", inventory.InventoryId);
                    cmd.Parameters.AddWithValue("@ProductName", inventory.InventoryName);
                    cmd.Parameters.AddWithValue("@ProductQuantity", inventory.InventoryQuantity);
                    cmd.Parameters.AddWithValue("@ProductCost", inventory.InventoryCost);
                    cmd.Parameters.AddWithValue("@UsersId", inventory.UsersId);

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

        public bool removeQuantity(Inventory inventory) 
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Delete From Inventory Where InventoryId=@InventoryId AND UsersId=@UsersId", con))

                {
                    cmd.Parameters.AddWithValue("@InventoryId", inventory.InventoryId);
                    cmd.Parameters.AddWithValue("@UsersId", inventory.UsersId);

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

        public bool editInventory(Inventory inventory)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Update Inventory set InventoryId=@InventoryId, ProductName=@ProductName, ProductQuantity=@ProductQuantity, ProductCost=@ProductCost " +
                    "Where InventoryId=@InventoryId AND UsersId=@UsersId", con))
                {
                    cmd.Parameters.AddWithValue("@InventoryId", inventory.InventoryId);
                    cmd.Parameters.AddWithValue("@ProductName", inventory.InventoryName);
                    cmd.Parameters.AddWithValue("@ProductQuantity", inventory.InventoryQuantity);
                    cmd.Parameters.AddWithValue("@ProductCost", inventory.InventoryCost);
                    cmd.Parameters.AddWithValue("@UsersId", inventory.UsersId);
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
