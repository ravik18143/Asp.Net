﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmButton : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        lblMsg.Text = "you clicked OK button at " + DateTime.Now.ToString(); 
    }
}