using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClearAccount.BussinessLogicLayer;
using ClearAccount.BussinessEntities;

namespace ClearAccount.WebApp.WebForms
{
    public partial class LoginWEB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnIngresar.ServerClick += BtnIngresar_ServerClick;
        }

        public void BtnIngresar_ServerClick(object e, EventArgs args)
        {
            string user = inputUsuario.Value.Trim().ToUpper().ToString();
            string password = inputContraseña.Value.Trim().ToUpper().ToString();
            //Capturar ID
            

            //bool isLogin = false;
            int guardarIdU = UserBLL.Loguearse(user, password);
            

            if (guardarIdU > 0)
            {
                //Crea variable de sesion 
                Session.Add("Usuario", guardarIdU);
                Response.Redirect("/WebForms/AgregarCliente.aspx");
            }
        }
    }
}