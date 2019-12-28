using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace NewCURD.Dal
{
    public class Dal
    {
        public DataTable getAllEmployees()
        {
            DataTable dataTable = new DataTable("Employee");

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["IEMConStr"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllEmployee1";
                MySqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                dr.Close();
                cn.Close();
            }
            return dataTable;
        }
        public DataTable GetEmployeeById(int eventid)
        {
            DataTable dataTable = new DataTable("Employee");

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["IEMConStr"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmployeeByID1";
                cmd.Parameters.AddWithValue("p_EmployeeId", eventid);
                MySqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                dr.Close();
                cn.Close();
            }
            return dataTable;
        }

        public DataTable DelEmployeeById(int empid)
        {
            DataTable dataTable = new DataTable("Employee");

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["IEMConStr"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteEmployee1";
                cmd.Parameters.AddWithValue("p_EmployeeId", empid);
                MySqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                dr.Close();
                cn.Close();
            }
            return dataTable;
        }

    }
}