using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Account
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }

        //Llaves foraneas
        [Required]
        public int IdClient { get; set; }
        public Client Client { get; set; }


    }
}
