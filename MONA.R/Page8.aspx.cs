using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MONA.R
{
    public partial class Page8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hdnfldCurrentDateTime.Value = DateTime.Now.ToString();
            lblCurrentDateTime.Text = Convert.ToString(hdnfldCurrentDateTime.Value);
        }
    }
}