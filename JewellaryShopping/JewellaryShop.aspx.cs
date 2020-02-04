using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellaryShopping
{
    public partial class JewellaryShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public virtual void OnClick(Object sender,EventArgs e)
        {
            User user = new User(userId.Text, password.Text, phone.Text, mail.Text, ButtonRadio.SelectedItem.ToString());
            SqlConnection sqlConnection = Connection.getDetails();
            Repositary repositary = new Repositary();
            int retRows = repositary.AddAdmin(sqlConnection, user);
            if (retRows >= 1)
            {
                Response.Redirect("Jewellary.aspx");
            }
            else
            {
                Response.Write("Not Registered...");
            }
        }
    }
}