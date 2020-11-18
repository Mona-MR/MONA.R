using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MONA.R
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != " ") { TextBox2.Text = " "; }
            TextBox2.Text =TextBox1.Text;
            TextBox1.Text=" ";
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx?name=" + Button2.Text);
        }
    }
}