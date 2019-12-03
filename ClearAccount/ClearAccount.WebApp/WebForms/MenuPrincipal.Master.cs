using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClearAccount.WebApp
{
    public partial class MenuPrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("LoginWEB.aspx");
            }
            
            bLo.ServerClick += BLo_ServerClick;
        }

        private void BLo_ServerClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("LoginWEB.aspx");

        }
    }
}