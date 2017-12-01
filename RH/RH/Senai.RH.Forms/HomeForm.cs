using RH.Senai.RH.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string mensagem = "Sistema de RH v1.0\nDesenvolvido por: Jorge Rabello";
            string titulo = "Sobre...";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o form de cadastro de funcionários

            // cria uma instância do form
            FuncionarioForm form = new FuncionarioForm();

            // chama o método ShowDialog()
            form.ShowDialog();
        }
    }
}
