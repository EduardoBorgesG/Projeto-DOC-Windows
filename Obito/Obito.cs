using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOC_Projeto.Obito
{
    public partial class Obito : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        public Obito()
        {
            InitializeComponent();
            BtnSalvar.Enabled = false;
            BtnIncluirO.Enabled = true;
            dataGridView1.Visible = false;
        }

        private void FormatarDG()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data de Nascimento";
            dataGridView1.Columns[3].HeaderText = "Nome da Mãe";
            dataGridView1.Columns[4].HeaderText = "Data de Nascimento da Mae";
            dataGridView1.Columns[5].HeaderText = "Nome do Pai";
            dataGridView1.Columns[6].HeaderText = "Data de Nascimento do Pai";
            dataGridView1.Columns[7].HeaderText = "Data  Registro";
            dataGridView1.Columns[8].HeaderText = "Data  do Óbito";


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 450;
            dataGridView1.Columns[8].Width = 70;
        }

        
        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM obito WHERE nome_falecido LIKE @nome";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", TxtNomeO.Text + "%");
            /*cmd.Parameters.AddWithValue("@dataNascimentoF", MtxtDataO.Text);
            cmd.Parameters.AddWithValue("@nomeMae", TxtNomeMaeO.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoM", MtxtDataMaeO.Text);
            cmd.Parameters.AddWithValue("@nomePai", TxtNomePaiO.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoPai", MtxtDataPaiO.Text);
            cmd.Parameters.AddWithValue("@dataRegistro", MtxtDataRegistroO.Text);
            cmd.Parameters.AddWithValue("@dataObito", MtxtFalecimento.Text);*/
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            FormatarDG();
            con.FecharCon();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnIncluirO_Click(object sender, EventArgs e)
        {
            if (TxtNomeO.Text.ToString().Trim() == "" || MtxtDataO.Text.ToString().Trim() == "" || TxtNomePaiO.Text.ToString().Trim() == "" || MtxtDataPaiO.Text.ToString().Trim() == "" || TxtNomeMaeO.Text.ToString().Trim() == "" || MtxtDataMaeO.Text.ToString().Trim() == "" || MtxtDataRegistroO.Text.ToString().Trim() == "" || MtxtFalecimento.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Há algum campo que não foi preenchido.\n Por favor preencha-o.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                con.AbrirCon();
                sql = "INSERT INTO obito (nome_falecido, data_nascimento_f, nome_mae, data_nascimento_mae, nome_pai, data_nascimento_pai, data_registro, data_obito) VALUES (@nomeF, @dataNascimento, @nomeMae, @dataNascimentoM, @nomePai, @dataNascimentoPai, @dataRegistro, @dataObito)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nomeF", TxtNomeO.Text);
                DateTime Ndata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = Ndata;
                cmd.Parameters.AddWithValue("@nomeMae", TxtNomeMaeO.Text);
                DateTime Mdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimentoM", MySqlDbType.Date).Value = Mdata;
                cmd.Parameters.AddWithValue("@nomePai", TxtNomePaiO.Text);
                DateTime Pdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimentoPai", MySqlDbType.Date).Value = Pdata;
                DateTime Rdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = Rdata;
                DateTime Odata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataObito", MySqlDbType.Date).Value = Odata;
                cmd.ExecuteNonQuery();
                con.FecharCon();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var resultado = MessageBox.Show("Registro cadastrado com sucesso! \n Deseja incluir um novo registro ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                Close();
            }
            else if (resultado == DialogResult.Yes)
            {
                TxtNomeO.Text = "";
                TxtNomeMaeO.Text = "";
                TxtNomePaiO.Text = "";
                MtxtDataMaeO.Text = "";
                MtxtDataPaiO.Text = "";                           
                MtxtDataO.Text = "";
                MtxtFalecimento.Text = "";
                MtxtDataRegistroO.Text = "";

            }
        }

        private void BtnAjudaO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para pesquisar preencha somente o nome do Registrado e clica no botão ao lado", "Ajuda!", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirCon();
                sql = "UPDATE obito SET nome_falecido = @nome, data_nascimento_f = @dataNascimentoF, nome_mae = @nomeMae, data_nascimento_mae = @dataNascimentoM, nome_pai = @nomePai, data_nascimento_pai = @dataNascimentoPai, data_registro = @dataRegistro, data_obito = @dataObito WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("@nome", TxtNomeO.Text);
                DateTime Ndata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimentoF", MySqlDbType.Date).Value = Ndata;
                cmd.Parameters.AddWithValue("@nomeMae", TxtNomeMaeO.Text);
                DateTime Mdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimentoM", MySqlDbType.Date).Value = Mdata;
                cmd.Parameters.AddWithValue("@nomePai", TxtNomePaiO.Text);
                DateTime Pdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataNascimentoPai", MySqlDbType.Date).Value = Pdata;
                DateTime Rdata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = Rdata;
                DateTime Odata = Convert.ToDateTime(MtxtDataO.Text);
                cmd.Parameters.Add("@dataObito", MySqlDbType.Date).Value = Odata;
                cmd.ExecuteNonQuery();
                con.FecharCon();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var resultado = MessageBox.Show("Registro alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtNomeO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MtxtDataO.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtNomeMaeO.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MtxtDataMaeO.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtNomePaiO.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MtxtDataPaiO.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            MtxtDataRegistroO.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MtxtFalecimento.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            BtnSalvar.Enabled = true;
            BtnIncluirO.Enabled = false;
        }

        private void BtnPesquisarO_Click(object sender, EventArgs e)
        {
            Listar();
            dataGridView1.Visible = true;
        }
    }
}
