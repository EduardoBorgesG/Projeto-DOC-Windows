using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOC_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes){
                Close();
            }
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nascimento.Nascimento form = new Nascimento.Nascimento();
            form.Show();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Casamento.Casamento form = new Casamento.Casamento();
            form.Show();
        }

        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Obito.Obito form = new Obito.Obito();
            form.Show();    

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nascimento.relatorio form = new Nascimento.relatorio();
            form.Show();
        }
    }
}
