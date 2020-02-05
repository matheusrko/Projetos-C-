using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void faleConoscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaleConosco Tela = new FaleConosco();
            //Tela.Show();
            //this.Hide(); ASSIM OU
            Tela.ShowDialog();

        }

        private void sobreMimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobremim Tela = new Sobremim();
            //Tela.Show();
            //this.Hide(); ASSIM OU
            Tela.ShowDialog();
        }

        private void item01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos Tela = new Cursos();
            //Tela.Show();
            //this.Hide(); ASSIM OU
            Tela.ShowDialog();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar Tela = new Cadastrar();
            //Tela.Show();
            //this.Hide(); ASSIM OU
            Tela.ShowDialog();

        }
    }
}
