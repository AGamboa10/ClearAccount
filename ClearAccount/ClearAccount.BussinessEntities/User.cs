using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class User
    {
        //Entidades de mi base de datos
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string NameUser { get; set; }
        [Required]
        public string Password { get; set; }

        //Crear relaciones entre tablas
        //ICollections
        public virtual ICollection<Client> Clients { get; set; }

    }
}


