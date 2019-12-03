using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClearAccount.BussinessLogicLayer;
using ClearAccount.BussinessEntities;
using System.Data.Odbc;

namespace ClearAccount.WebApp
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga de informacion de mi dropdown
            int IdUsuario = Convert.ToInt32(Session["Usuario"]);
            DropClient.Load += dropdownClientes_ServerClick;

            DropClient.DataSource = ClientBLL.BuscarCliente(IdUsuario);
            DropClient.DataBind();

        }

        public void dropdownClientes_ServerClick(object e, EventArgs args)
        {
            //Client client = new Client();

            //int IdUsuario = Convert.ToInt32(Session["Usuario"]);


            ////NombreUsuario = ClientBLL.BuscarCliente(IdUsuario); 
            //List<string> listitem = new List<string>();

            //listitem = (ClientBLL.BuscarCliente(IdUsuario));
            //DropClient.Items.Add(listitem);
            //DropClient.DataSource = ClientBLL.BuscarCliente(IdUsuario);
            //DropClient.DataBind();

        }


    }
}