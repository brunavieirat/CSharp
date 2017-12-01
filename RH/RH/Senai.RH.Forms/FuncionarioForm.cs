using RH.Senai.RH._Model;
using RH.Senai.RH.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH.Senai.RH.Forms
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
        }



        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            // instancia um funcionário
            Funcionario funcionario = new Funcionario();

            // atribui dados ao funcionário
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.CPF = txtCpfFuncionario.Text;
            funcionario.RG = txtRgFuncionario.Text;
            funcionario.Email = txtEmailFuncionario.Text;
            funcionario.Telefone = txtTelefoneFuncionario.Text;

            // instancia o dao de funcionários
            FuncionarioDao dao = new FuncionarioDao();

            // salva o funcionário no banco de dados
            dao.Salvar(funcionario);

            PreencheDados();

            LimparFormulario();

        } // fim do evento de click

        // métodos do programador
        private void LimparFormulario()
        {
            txtNomeFuncionario.Clear();
            txtCpfFuncionario.Clear();
            txtRgFuncionario.Clear();
            txtEmailFuncionario.Clear();
            txtTelefoneFuncionario.Clear();
            txtCpfFuncionario.Focus();
        }

        private void FuncionarioForm_Load(object sender, EventArgs e)
        {
            PreencheDados();
        }

        private void PreencheDados()
        {
            FuncionarioDao dao = new FuncionarioDao();

            dgvFuncionarios.DataSource = dao.Consultar();

            dgvFuncionarios.Columns["ID"].Visible = false;
            dgvFuncionarios.Columns["Rg"].Visible = false;
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            // se alguma linha for selecionada
            if(dgvFuncionarios.CurrentRow != null)
            {
                // pega o id e coloca no textbox de id
                txtIDFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
                txtNomeFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
                txtCpfFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[2].Value.ToString();
                txtRgFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[3].Value.ToString();
                txtEmailFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[4].Value.ToString();
                txtTelefoneFuncionario.Text = dgvFuncionarios.CurrentRow.Cells[5].Value.ToString();

            }
        }
    } // fim da classe
}
