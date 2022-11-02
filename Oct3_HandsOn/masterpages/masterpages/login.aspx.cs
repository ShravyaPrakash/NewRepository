using business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data;
using System.Drawing;
using System.Data;
using System.Globalization;

namespace masterpages
{
    public partial class login1 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=kannan;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                userlogin use = new userlogin();
                 use.userid = Convert.ToInt32(TextBox1.Text);
                 use.userpassword = TextBox2.Text;
            /*    c.Open();
                 SqlCommand cmd = new SqlCommand("select * from userlogins where user userid='" + use.userid + "', userpassword='" + use.userid + "'", c);
                  int temp = Convert.ToInt32(cmd.ExecuteScalar());
                  if (temp == 1)
                  {
                      Response.Redirect("~/list.aspx");
                  }
                  else
                  {
                      Label4.Text = "please check userid and password";
                  }
                c.Close();

             /*   SqlDataAdapter cmd = new SqlDataAdapter("select * from userlogins where user userid='" + use.userid + "', userpassword='" + use.userid + "'", c);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if (dt.Rows.Count>1)
                {


                        Response.Redirect("~/list.aspx");

                }
                else
                {
                    Label4.Text = "please check userid and password";
                } */
            try
            {
               
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", use.userid.ToString());
                cmd.Parameters.AddWithValue("@Password", use.userpassword.ToString());
                cmd.Connection = c;
                c.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                   
                    
                    c.Close();

                    Response.Redirect("~/list.aspx");
                }
                else
                {
                    Label4.Text = "Invalid credentials";
                }

              
                c.Close();

            }
            catch (Exception ex)
            {

            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/register.aspx");
        }
    }
    }
