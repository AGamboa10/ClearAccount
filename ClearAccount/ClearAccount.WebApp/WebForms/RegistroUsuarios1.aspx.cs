using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using ClearAccount.BussinessEntities;
using ClearAccount.BussinessLogicLayer;

namespace ClearAccount.WebApp
{
    public partial class RegistroUsuarios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRegistrar.ServerClick += BtnRegistrar_ServerClick;
            btnLoguear.ServerClick += BtnLoguear_ServerClick;
        }

        private void BtnLoguear_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("/WebForms/LoginWEB.aspx");
        }

        private void BtnRegistrar_ServerClick(object sender, EventArgs e)
        {
            User user = new User();
            //Se le da valor a las entidades
            user.NameUser = inputUsuario.Value.Trim().ToUpper().ToString();
            user.Password = inputContraseña.Value.Trim().ToUpper().ToString();
            //Variable con confirmacion de contraseña
            string confirmPass = inputconfirmar_contraseña.Value.Trim().ToUpper().ToString();
            
            #region Envio de la informacion para atras

            if(confirmPass == user.Password)
            {
                string message = UserBLL.addUser(user);
                #endregion
                if (string.IsNullOrEmpty(message))
                {
                    Response.Write("<script>alert('Se inserto correctamente.')</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se inserto.')</script>");
                    Response.Write(message);
                }
                
                
            }
            else
            {
                Response.Write("<script>alert('No coinciden las contraseñas.')</script>");
            }




        }

       
    }
}