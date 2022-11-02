using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using business;
using data;
namespace masterpages
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-LUAVTH3;Initial Catalog=kannan;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            userlogin use = new userlogin();
            use.name = TextBox3.Text;
            use.userid = Convert.ToInt32(TextBox1.Text);
            use.userpassword = TextBox2.Text;
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into userlogins values('" + use.name + "','" + use.userid + "','" + use.userpassword + " ')", c);
            cmd.ExecuteNonQuery();
            lbl0.Text = "register  succesfully";

            c.Close();
        }

        //protected void button1_click(object sender, eventargs e)
        //{

        //}

        //protected void button1_click1(object sender, eventargs e)
        //{
        //    userlogin use = new userlogin();
        //    use.userid = convert.toint32(textbox1.text);
        //    use.userpassword = textbox2.text;
        //    sqlcommand cmd = new sqlcommand("select count(*) from userlogins where user userid='" + use.userid + "',userpassword='" + use.userid + "'", c);
        //    int temp=convert.toint32(cmd.executescalar());
        //    if(temp==1)
        //    {
        //        response.write("succesful");
        //    }
        //    else
        //    {
        //        response.write("please enter coorect details");
        //    }
        //}

        //protected void textbox3_textchanged(object sender, eventargs e)
        //{

        //}
    }
}