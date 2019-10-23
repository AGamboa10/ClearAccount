using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Nota
    {
        public int Id { get; set; }

        public string descripcion { get; set; }

        public DateTime date { get; set; }

        public int IdClient { get; set; }
    }
}
