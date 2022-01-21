using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace DOC_Projeto.Nascimento
{
    public partial class relatorio : Form
    {
        Conexao con = new Conexao();

        
        public relatorio()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {



        }

        private void Dado()
        {
            Console.WriteLine("teste");
            /*con.AbrirCon();
            sql = "SELECT nome_registrado, nome_mae, data_registro, data_nascimento_registrado FROM nascimento WHERE data_registro BETWEEN '2022-01-10' AND '2022-01-20'";
            cmd = new MySqlCommand(sql, con.con);*/
        }

        private void BtnXML_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
        }
    }
}
