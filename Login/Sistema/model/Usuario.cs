using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.model
{
    class Usuario
    {
        public long ID { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

    }
}
