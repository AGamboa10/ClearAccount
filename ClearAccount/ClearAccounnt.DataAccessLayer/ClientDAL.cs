using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mandar llamar nuestras importaciones
using System.Configuration;
using System.Data;
using System.Data.Entity;
using ClearAccount.BussinessEntities;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;


namespace ClearAccount.DataAccessLayer
{
    //Definimos la clase como publica para que los otros proyectos tengan acceso
    public class ClientDAL
    {
        //primero y siguiendo el orden de las acciones CRUD
        //Crearemos un metodo que se encargue de insertar un nuevo cliente
        #region Insertar cliente

        static ClearAccountDbContext dbContext = new ClearAccountDbContext();

        public static string addCliente(Client client)

        {
            string message = string.Empty;
            using (var dbCtxTran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    //Para guardar errores que vayan saliendo
                    //Aqui va la consulta
                    dbContext.Clients.Add(client);
                    int rowAffected = dbContext.SaveChanges(); //Actualiza la base de datos
                    if(rowAffected <= 0)
                    {
                        message = "Hubo un error en el insertado";
                    }
                    else
                    {
                        dbCtxTran.Commit();
                    }

                }

                catch (DbEntityValidationException ex)
                {
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", errorMessages);
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);
                    message = exceptionMessage + "\n" + ex.EntityValidationErrors;

                    dbCtxTran.Rollback();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var entityObj = ex.Entries.Single().GetDatabaseValues();

                    if (entityObj == null)
                        message = "The entity being updated is already deleted by another user";
                    else
                        message = "The entity being updated has already been updated by another user";

                    dbCtxTran.Rollback();
                }
                catch (DbUpdateException ex)
                {
                    var exception = HandleDbUpdateException(ex);
                    message = exception.Message;

                    dbCtxTran.Rollback();
                }
                catch (Exception ex)
                {
                    message = ex.Message;

                    dbCtxTran.Rollback();
                }
            }
            return message;

        }


        #endregion

        #region BuscarCliente

        public static DataTable BuscarClienteDAL(int idUsuario)
        {
            
            bool isExistente = false;
            DataTable dt = new DataTable();
            Client client = new Client();
            
            
            isExistente = Database.Exists(dbContext.Database.Connection);

            if (isExistente)
            {
                var query = (from c in dbContext.Clients
                             where c.IdUser == idUsuario
                             select new
                             {
                                 c.Id,
                                 c.Name,
                                 c.Apellido
                             }).ToList();
                dt.Columns.Add("Cliente");
                dt.Columns.Add("Id");
                foreach (var item in query)
                {
                    //crea un nuevo row
                    DataRow row = dt.NewRow();

                    //Asignar el dato a cada columna  de la row
                    row["Cliente"] = item.Name + " " + item.Apellido;

                    row["Id"] = item.Id;

                    dt.Rows.Add(row);
                }
                
            }
            
            return dt;
        }

        #endregion

        #region HandleDbUpdateException
        private static Exception HandleDbUpdateException(DbUpdateException dbu) 
        {
            var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

            try
            {
                foreach (var result in dbu.Entries)
                {
                    builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                }
            }
            catch (Exception e)
            {
                builder.Append("Error parsing DbUpdateException: " + e.ToString());
            }

            string message = builder.ToString();
            return new Exception(message, dbu);
        }
        #endregion


    }
}
