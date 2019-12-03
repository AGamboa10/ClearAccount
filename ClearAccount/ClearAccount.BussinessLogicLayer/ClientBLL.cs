using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Se agregan estas librerias
using ClearAccount.BussinessEntities;
using System.ComponentModel.DataAnnotations;

namespace ClearAccount.BussinessLogicLayer
{
    public class ClientBLL
    {
        #region AñadirCliente
        public static string addClient(Client client)
        {
            ICollection<ValidationResult> results = null;
            string message = string.Empty;
            if(!validate(client, out results))
            {
                message = string.Join("\n", results.Select(o => o.ErrorMessage));
            }
            else
            {
                message = DataAccessLayer.ClientDAL.addCliente(client);
            }
            return message;
        }
        #endregion

        #region BuscarCliente

        public static DataTable BuscarCliente(int idUsuario)
        {
            //List<string> ClienteNombre = new List<string>();
            DataTable dt = new DataTable();
            dt = DataAccessLayer.ClientDAL.BuscarCliente(idUsuario);
            return dt;


        }

        #endregion


        public static bool validate<T>(T obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }

    }
}
