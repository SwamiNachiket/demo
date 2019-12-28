using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewCURD.CURD
{
    public partial class INSERT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empid.Text);
            string name = employeename.Text;
            string password = City.Text;
            DataTable eventstable = new DataTable("infowayemp");
            int res = 0;
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["IEMConStr"].ConnectionString))
            {
                CN.Open();
                MySqlCommand CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "InsertEmployee1";
                CMD.Parameters.AddWithValue("EmployeeId", id);
                CMD.Parameters.AddWithValue("EmployeeName", name);
                CMD.Parameters.AddWithValue("EmployeeCity", password);
                res = CMD.ExecuteNonQuery();
                CN.Close();
            }
        }
    }
}