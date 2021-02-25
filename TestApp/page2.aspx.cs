using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApp
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["var1"] != null)
            {
                Label1.Text += Session["var1"];
            }

            if (Request.QueryString["ID"] != null)
            {
                Label2.Text += Request.QueryString["ID"].ToString();
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Response.Redirect("page1.aspx");
        }
    }
}