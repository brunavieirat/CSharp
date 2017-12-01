using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Util().BuscaCep(txtCep.Text);
            //BuscaCep(txtCep.Text);

            txtLogradouro.Text = endereco.Logradouro;
            txtBairro.Text = endereco.Bairro;
            txtCidade.Text = endereco.Cidade;
            txtUF.Text = endereco.UF;

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            Endereco endereco = new Util().BuscaCep(txtCep.Text);
            //BuscaCep(txtCep.Text);

            txtLogradouro.Text = endereco.Logradouro;
            txtBairro.Text = endereco.Bairro;
            txtCidade.Text = endereco.Cidade;
            txtUF.Text = endereco.UF;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/buscaCepEndereco.cfm");
        }
    }

       
    }

