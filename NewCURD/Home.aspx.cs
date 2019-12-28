using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
//using NewCURD.Dal;
using NewCURD.CURD;

namespace NewCURD
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          String s = GridView1.SelectedRow.Cells[0].Text;
            int id = int.Parse(s);
            DataTable dataTable = new DataTable("Employee");

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["IEMConStr"].ConnectionString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteEmployee1";
                cmd.Parameters.AddWithValue("p_EmployeeId", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                dr.Close();
                cn.Close();
            }
            
        }
    }
}