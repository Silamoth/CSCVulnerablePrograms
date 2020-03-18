using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace VulnerableLogin
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == String.Empty)
            {
                Response.Write("<script>alert('Error: Please enter your username')</script>");
                return;
            }

            if (passwordTextBox.Text == String.Empty)
            {
                Response.Write("<script>alert('Error: Please enter your password')</script>");
                return;
            }

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            connection.Open();

            String query = "SELECT pswd FROM LoginTable WHERE uname = @username";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            List<String> passwords = new List<String>();

            while (reader.Read())
                passwords.Add(reader[0].ToString());

            if (passwords.Contains(passwordTextBox.Text))
                Response.Write("<script>alert('You Are In!')</script>");
            else
                Response.Write("<script>alert('Incorrect Password...')</script>");

            connection.Close();
        }
    }
}