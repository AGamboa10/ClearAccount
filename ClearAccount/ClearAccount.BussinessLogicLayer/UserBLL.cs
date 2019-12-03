using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using ClearAccount.BussinessEntities;

namespace ClearAccount.BussinessLogicLayer
{
    public class UserBLL
    {
        public static string addUser(User user)
        {
            ICollection<ValidationResult> results = null;
            string message = string.Empty;
            if(!validate(user, out results))
            {
                message = String.Join("\n", results.Select(o => o.ErrorMessage));
            }
            else
            {
                message = DataAccessLayer.UserDAL.addUsuarios(user);
            }
            return message;
        }

        public static int Loguearse(string usuario, string password)
        {
            if (string.IsNullOrEmpty(usuario))
            {
                return 0;
            }
            else
            {
                if (string.IsNullOrEmpty(password))
                {
                    return 0;
                }
                else
                {
                    return DataAccessLayer.UserDAL.Loguearse(usuario, password);
                }
            }
        }

        public static bool validate<T>(T obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }
    }
}
