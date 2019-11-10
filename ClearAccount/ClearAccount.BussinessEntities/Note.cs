using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Note
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string description { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        //Llaves foraneas
        [Required]
        public int IdClient { get; set; }
        public Client Client { get; set; }
    }
}
