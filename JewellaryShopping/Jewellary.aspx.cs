using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class Jewellary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClicks(Object sender, EventArgs e)
        {
            User users = new User(userId.Text, password.Text, ButtonRadio.SelectedItem.ToString());
            SqlConnection sqlConnection = Connection.getDetails();
            Repositary repositary = new Repositary();
            int retRows = repositary.Login(sqlConnection, users);
            if (retRows == 1)
            {
                string message = "Login successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
            }
            else
            {
                Response.Write("Login failed...");
            }
        }
    }
}