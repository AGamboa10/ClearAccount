using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Cuenta
    {
        public int Id { get; set; }

        public decimal monto { get; set; }

        public int IdClient { get; set; }


    }
}
