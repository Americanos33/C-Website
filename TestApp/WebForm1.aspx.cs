using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double a, b, c;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Changed";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBox1.Text);
            b = Convert.ToDouble(TextBox2.Text);
            c = a + b;
            TextBox3.Text = Convert.ToString(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBox1.Text);
            b = Convert.ToDouble(TextBox2.Text);
            c = a - b;
            TextBox3.Text = Convert.ToString(c);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBox1.Text);
            b = Convert.ToDouble(TextBox2.Text);
            c = a * b;
            TextBox3.Text = Convert.ToString(c);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(TextBox1.Text);
            b = Convert.ToDouble(TextBox2.Text);
            c = a / b;
            TextBox3.Text = Convert.ToString(c);
        }

        protected void textChange(object sender, EventArgs e)
        {
            String t = DropDownList1.Text;
            Label2.Text = t;
        }
    }
}