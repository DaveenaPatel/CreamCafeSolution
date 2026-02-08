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
    internal class Merch
    {
        public int UsersId { get; set; }
        public int MerchId { get; set; }
        public string MerchName { get; set; }
        public int MerchQuantity { get; set; }
        public int MerchCost { get; set; }
        

        public static string connection = ConfigurationManager.ConnectionStrings["CreamCafeSolution"].ConnectionString;

        public DataTable getMerch()
        {
            var datatable = new DataTable();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from Merch Where UsersId=@UsersId", con))
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

        public bool addMerch(Merch merch)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Insert into Merch (MerchId, MerchName, MerchQuantity, MerchCost, UsersId) Values " +
                    "(@MerchId, @MerchName, @MerchQuantity, @MerchCost, @UsersId)", con))
                {
                    cmd.Parameters.AddWithValue("@MerchId", merch.MerchId);
                    cmd.Parameters.AddWithValue("@MerchName", merch.MerchName);
                    cmd.Parameters.AddWithValue("@MerchQuantity", merch.MerchQuantity);
                    cmd.Parameters.AddWithValue("@MerchCost", merch.MerchCost);
                    cmd.Parameters.AddWithValue("@UsersId", merch.UsersId);
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

        public bool deleteMerch(Merch merch)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Delete From Merch Where MerchId=@MerchId AND UsersId=@UsersId", con))

                {
                    cmd.Parameters.AddWithValue("@MerchId", merch.MerchId);
                    cmd.Parameters.AddWithValue("@UsersId", merch.UsersId);
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

        public bool editMerch(Merch merch)
        {
            int row;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand
                    ("Update Merch set MerchId=@MerchId, MerchName=@MerchName, MerchQuantity=@MerchQuantity, MerchCost=@MerchCost " +
                    "Where MerchId=@MerchId AND UsersId=@UsersId", con))
                {
                    cmd.Parameters.AddWithValue("@MerchId", merch.MerchId);
                    cmd.Parameters.AddWithValue("@MerchName", merch.MerchName);
                    cmd.Parameters.AddWithValue("@MerchQuantity", merch.MerchQuantity);
                    cmd.Parameters.AddWithValue("@MerchCost", merch.MerchCost);
                    cmd.Parameters.AddWithValue("@UsersId", merch.UsersId);
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
