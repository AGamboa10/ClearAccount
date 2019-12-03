using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Image
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public byte[] ImageUrl { get; set; }

        //Crear relaciones entre tablas
            //ICollection
        public virtual ICollection<Client> Clients { get; set; }

    }
}
