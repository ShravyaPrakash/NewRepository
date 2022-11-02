using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data;
using business;
namespace masterpages
{
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bookdetails b = new bookdetails();
            List<books> products = new List<books>();
            products = b.GetProducts();

            GridView1.DataSource = products;
            GridView1.DataBind();

        }
    }
}