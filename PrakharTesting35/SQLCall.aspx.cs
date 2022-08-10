using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting35
{
    public partial class SQLCall : System.Web.UI.Page
    {
        public SqlConnection Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
                Conn = new SqlConnection(ConnStr);
                string SqlString = "SELECT * FROM TR_Agent WHERE ID = 1;";

                SqlDataAdapter sda = new SqlDataAdapter(SqlString, Conn);

                DataTable dt = new DataTable();

                Conn.Open();
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}