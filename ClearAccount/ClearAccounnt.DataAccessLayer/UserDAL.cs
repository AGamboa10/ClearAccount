using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mandar llamar nuestras importaciones
using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.Entity;
using System.Data.Entity;
using ClearAccount.BussinessEntities;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace ClearAccount.DataAccessLayer
{
    public class UserDAL
    {

        #region InsetarUsuarios
        static ClearAccountDbContext dbCtx = new ClearAccountDbContext();
        public static string addUsuarios(User user)
        {

            String message = string.Empty;
            using (var dbCtxTran = dbCtx.Database.BeginTransaction())
            {
                try
                {
                    //Para guardar erroes que vayan saliendo
                   
                    //Aqui va la consulta
                    dbCtx.Users.Add(user);
                    int rowAffected = dbCtx.SaveChanges(); //Actualiza la base de datos

                    if (rowAffected <= 0)
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

        public static int Loguearse(string user, string paswword)
        {
            bool isLogin;
            int guardarIdU = 0;

            isLogin = dbCtx.Users.Where(x => x.NameUser == user && x.Password == paswword).Count() > 0;
            if (isLogin)
            {
                guardarIdU = dbCtx.Users.Where(x => x.NameUser == user && x.Password == paswword).FirstOrDefault().Id;
            }
            

            return guardarIdU;

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
