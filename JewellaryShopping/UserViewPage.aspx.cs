﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class UserViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClick(Object sender, EventArgs e)
        {
            if (ID == "SignUp")
            {
                Response.Redirect("JewellaryShop.aspx");
            }
            else
            {
                Response.Redirect("Jewellary.aspx");
            }

        }
        
    }
}