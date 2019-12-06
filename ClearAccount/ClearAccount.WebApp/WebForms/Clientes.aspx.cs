using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClearAccount.BussinessLogicLayer;
using ClearAccount.BussinessEntities;
using System.Data.Odbc;
using System.Data;
using System.Configuration;

namespace ClearAccount.WebApp
{
    public partial class Clientes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Metodo para deshabilitar los inputs
            Page.LoadComplete += DeshabilitarInputs_ServerClick;
            
            //Metodo que llena el DropDown
            DropClient.Load += dropdownClientes_ServerClick;
            
            

        }
        
        public void Modificar_ServerClick(object e, EventArgs eventArgs)
        {
            int idClienteActual = Convert.ToInt32(DropClient.SelectedValue.ToString());

            
        }

        //Metodo para desactivar los inputs.
        public void DeshabilitarInputs_ServerClick(object e, EventArgs eventArgs)
        {
            
            inputNombre.Disabled = true;
            inputApellido.Disabled = true;
            inputCorreo.Disabled = true;
            inputDireccion.Disabled = true;
            inputTelefono.Disabled = true;
        }
        //Metodo encargado de llenar el DropDown
        public void dropdownClientes_ServerClick(object e, EventArgs args)
        {
            Client client = new Client();

            //Variable de session
            int IdUsuario = Convert.ToInt32(Session["Usuario"]);
            //Carga de informacion de mi dropdown
            DropClient.DataValueField = "Id";
            DropClient.DataTextField = "Cliente";
            DropClient.DataSource = ClientBLL.BuscarClienteBLL(IdUsuario);
            DropClient.DataBind();

        }




    }
}