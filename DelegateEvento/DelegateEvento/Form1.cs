using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEvento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXEMPLO 01");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXEMPLO 02");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AGREGA UM EVENTO A MAIS NO EVENTO DE CLICK

            //  button1.Click += new EventHandler(metodo01);
            //  button2.Click += new EventHandler(metodo02);

            button1.Click += delegate (Object o, EventArgs ev)
            {
                MessageBox.Show("MEU DELEGATE");
            };
        }

        private void metodo01 (object sender, EventArgs e)
        {
            MessageBox.Show("EU SOU O MÉTODO 01");
        }

        private void metodo02 (object sender, EventArgs e)
        {
            MessageBox.Show("EU SOU O MÉTODO 02");
        }

        public delegate void MeuDelegate(object sender, EventArgs e);

    }
}
