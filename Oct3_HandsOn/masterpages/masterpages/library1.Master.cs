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
    public partial class Site1 : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Products p = new Products();
            //p.Prodid = Convert.ToInt32(txtprodid0.Text);
            //p.ProdName = txtprodname0.Text;
            //p.Price = Convert.ToInt32(txtprice0.Text);
            //c.Open();
            //SqlCommand cmd = new SqlCommand("insert into products values('" + p.Prodid + "','" + p.ProdName + "','" + p.Price + "')", c);
            //cmd.ExecuteNonQuery();
            //lbl0.Text = "record added succesfully";

            //c.Close();
            //userlogin use=new userlogin();
            //use.userid = Convert.ToInt32(TextBox1.Text);
            //use.userpassword=TextBox2.Text;
            //c.Open();
            //SqlCommand cmd = new SqlCommand("insert into products values('" + p.Prodid + "','" + p.ProdName + "','" + p.Price + "')", c);
            //cmd.ExecuteNonQuery();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //userlogin use = new userlogin();
            //use.userid = Convert.ToInt32(TextBox1.Text);
            //use.userpassword = TextBox2.Text;
            //c.Open();
            //SqlCommand cmd = new SqlCommand("insert into userlogin values('" + use.userid + "','" + use.userpassword+" ')", c);
            //cmd.ExecuteNonQuery();
            //lbl0.Text = "record added succesfully";

            //c.Close();
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }
    }
}