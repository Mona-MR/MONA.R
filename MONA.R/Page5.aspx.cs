﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MONA.R
{
    public partial class Page5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                tbUserName.Text = Session["UserName"].ToString();
            }
            if (Session["Pwd"] != null)
            {
                tbpwd.Text = Session["Pwd"].ToString();
            }
        }
    }
}