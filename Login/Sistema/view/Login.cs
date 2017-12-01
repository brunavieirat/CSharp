using Sistema.dao;
using Sistema.model;
using Sistema.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() { Email = txtUsuario.Text, Senha = txtSenha.Text };
            VerificaLogin(usuario);

        }

        void VerificaLogin(Usuario usuario)
        {
            UsuarioDao dao = new UsuarioDao();
            if (dao.Consultar(usuario))
            {
                MessageBox.Show("Seja Bem-Vindo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Uusário ou senha inválidos !", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
