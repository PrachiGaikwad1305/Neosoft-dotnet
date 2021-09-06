using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class user_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand("AddDetails", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", tbName.Text);
                cmd.Parameters.AddWithValue("@Zipcode", tbZipcode.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@UserName", tbUsername.Text);
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                SqlParameter outputpara = new SqlParameter();
                outputpara.ParameterName = "@Id";
                outputpara.SqlDbType = SqlDbType.Int;
                outputpara.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputpara);

                SqlParameter outputpara1 = new SqlParameter();
                outputpara1.ParameterName = "@loginId";
                outputpara1.SqlDbType = SqlDbType.Int;
                outputpara1.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputpara1);

                con.Open();
                cmd.ExecuteNonQuery();

                tbName.Text = "";
                tbEmail.Text = "";
                tbZipcode.Text = "";
                tbUsername.Text = "";
                tbPassword.Text = "";
                tbName.Focus();

            }

        }

        
    }
}