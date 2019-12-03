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
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnAgregarCliente.ServerClick += btnAgregarCliente_ServerClick;

        }

        private void btnAgregarCliente_ServerClick(object sender, EventArgs e)
        {
            Client client = new Client();

            client.Name = inputNombre.Value.Trim().ToUpper().ToString();
            client.Apellido = inputApellido.Value.Trim().ToUpper().ToString();
            client.Phone = inputTelefono.Value.Trim().ToUpper().ToString();
            client.Mail = inputCorreo.Value.Trim().ToUpper().ToString();
            client.Address = inputDireccion.Value.Trim().ToUpper().ToString();
            client.IdUser = Convert.ToInt32(Session["Usuario"]);

            //Envio de la informacion obtenida
            string message = ClientBLL.addClient(client);
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
    }
}