using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MONA.R
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["FirstName"] = TextBox1.Text;
            ViewState["LastName"] = TextBox2.Text;

            TextBox1.Text = TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["FirstName"].ToString();
            TextBox2.Text = ViewState["LastName"].ToString();
        }
    }
}