using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearAccount.BussinessEntities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string usuario { get; set; }

        public string contraseña { get; set; }

        public int IdClient { get; set; }
    }
}
