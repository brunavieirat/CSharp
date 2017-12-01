using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cep
{
    class Endereco
    {
        private string cep;

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        private string tipoLogradouro;
        public string TipoLogradouro
        {
            get { return tipoLogradouro; }
            set { tipoLogradouro = value; }
        }

        private string logradouro;

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

               

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string uf;

        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        
    }
}
