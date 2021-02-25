using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.IO;

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

        protected void Upload(object sender, EventArgs e)
        {
            Label3.Text = "";
            if ( FileUpload1.HasFile == true)
            {
                string randomfilename;
                randomfilename = DateTime.Now.Ticks + FileUpload1.FileName;

                string virtualpath = "~/Images/";
                string physicalpath = Server.MapPath(virtualpath + randomfilename);

                FileUpload1.SaveAs(physicalpath);

                Image1.ImageUrl = virtualpath + randomfilename;
                Image1.Width = FileUpload1.Width;
                Image1.Height = FileUpload1.Height;

                Label3.Text = "The file has uploaded successfully";
                Label3.ForeColor = Color.Green;
            }
            else
            {
                Label3.Text = "Please select a file first.";
                Label3.ForeColor = Color.Red;
            }
        }
    }
}