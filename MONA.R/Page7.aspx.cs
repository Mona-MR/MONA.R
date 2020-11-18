﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MONA.R
{
    public partial class Page7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = TextBox1.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookie Created";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                TextBox2.Text = "No cookie found";
            }
            else
            {
                TextBox2.Text = Request.Cookies["name"].Value;
            }
        }
    }
}