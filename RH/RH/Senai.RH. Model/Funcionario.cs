using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Senai.RH._Model
{
    class Funcionario
    {
        private long id;

        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string rg;

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        // construtores
        public Funcionario()
        {

        }

        public Funcionario(long id, string nome, string cpf, string rg, string email, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.telefone = telefone;
        }
    }
}
