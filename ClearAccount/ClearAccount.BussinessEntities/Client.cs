using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Client
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "Error")]
        public string name { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, ErrorMessage ="Error")]
        public string phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(30, ErrorMessage ="Error")]
        public string mail { get; set; }
        [DataType(DataType.Text)]
        [StringLength(40, ErrorMessage ="Error")]
        public string address { get; set; }

        //Crear relaicones entre tablas
            //ICollection
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
            //Llaves foraneas
        [Required]
        public int idImg{ get; set; }
        public Image Image { get; set; }

       


    }
}
