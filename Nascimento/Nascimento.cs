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

namespace DOC_Projeto.Nascimento
{
    public partial class Nascimento : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;




        public Nascimento()

        {
            InitializeComponent();
            BtnSalvar.Enabled = false;
            BtnIncluirN.Enabled = true;
            dataGridView1.Visible = false;
            TxtCPFInvalido.Visible = false;


        }

        private void VerificarCPFMae()
        {
            if (MtxtCPFMaeN.Text == "")
            {
                MessageBox.Show("Preencha o CPF");
            }
            else { 
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CPF = MtxtCPFMaeN.Text;
            string auxCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");
            auxCPF = CPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(auxCPF[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            Digito = resto.ToString();
            auxCPF = auxCPF + Digito;

            soma = 0;

            for (int i = 10; i < 10; i++)
            {
                soma += int.Parse(auxCPF[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            auxCPF = auxCPF + resto;

            if (CPF == auxCPF)
            {

                MtxtCPFMaeN.BackColor = Color.Green;
                BtnIncluirN.Enabled = true;
                TxtCPFInvalido.Visible = false;

                }
            else
            {
                MtxtCPFMaeN.BackColor = Color.Red;
                TxtCPFInvalido.Visible = true;
                BtnIncluirN.Enabled = false;
            }
            }
        }
        private void VerificarCPFPai()
        {
            if (MtxtCPFMaeN.Text == "")
            {               
                MessageBox.Show("Preencha o CPF");
            }
            else
            {

                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string CPF = MtxtCPFPaiN.Text;
                string auxCPF;
                string Digito;
                int soma;
                int resto;

                CPF = CPF.Trim();
                CPF = CPF.Replace(".", "");
                CPF = CPF.Replace("-", "");
                auxCPF = CPF.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(auxCPF[i].ToString()) * multiplicador1[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                Digito = resto.ToString();
                auxCPF = auxCPF + Digito;

                soma = 0;

                for (int i = 10; i < 10; i++)
                {
                    soma += int.Parse(auxCPF[i].ToString()) * multiplicador2[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                auxCPF = auxCPF + resto;

                if (CPF == auxCPF)
                {

                    MtxtCPFPaiN.BackColor = Color.Green;
                    BtnIncluirN.Enabled = true;
                    TxtCPFInvalido.Visible = false;
                }
                else
                {
                    MtxtCPFPaiN.BackColor = Color.Red;
                    TxtCPFInvalido.Visible = true;
                    BtnIncluirN.Enabled = false;
                }
            }
        }
        private void FormatarDG()
        {

            string nome = TxtNomeN.Text;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Data de Nascimento";
            dataGridView1.Columns[3].HeaderText = "Nome da Mãe";
            dataGridView1.Columns[4].HeaderText = "Data de Nascimento da Mae";
            dataGridView1.Columns[5].HeaderText = "CPF da Mae";
            dataGridView1.Columns[6].HeaderText = "Nome do Pai";
            dataGridView1.Columns[7].HeaderText = "Data de Nascimento do Pai";
            dataGridView1.Columns[8].HeaderText = "CPF do pai";
            dataGridView1.Columns[9].HeaderText = "Data  Registro";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 450;

        }
        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM nascimento WHERE nome_registrado LIKE @nome";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", TxtNomeN.Text + "%");
            /*cmd.Parameters.AddWithValue("@dataNascimento", MtxtDataN.Text);
            cmd.Parameters.AddWithValue("@nomeMae", TxtNomeMaeN.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoM", MtxtDataMaeN.Text);
            cmd.Parameters.AddWithValue("@cpfMae", MtxtCPFMaeN.Text);
            cmd.Parameters.AddWithValue("@nomePai", TxtNomePaiN.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoPai", MtxtDataPaiN.Text);
            cmd.Parameters.AddWithValue("@cpfPai", MtxtCPFPaiN.Text);
            DateTime Bdata = Convert.ToDateTime(MtxtDataRegistroN.Text);
            cmd.Parameters.Add("@data_registro", MySqlDbType.Date).Value = Bdata;*/
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.FecharCon();

            FormatarDG();
        }

        private void BtnIncluirN_Click(object sender, EventArgs e)
        {
            if(TxtNomeN.Text.ToString().Trim() == "" || TxtNomeN.Text.ToString().Trim() == "" || TxtNomeMaeN.Text.ToString().Trim() == "" ||   TxtNomePaiN.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Há algum campo que não foi preenchido.\n Por favor preencha-o.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomeN.Focus();
                return;
            }
            else if(MtxtDataN.Text.Trim() == "" || MtxtDataMaeN.Text.ToString().Trim() == "" || MtxtCPFMaeN.Text.ToString().Trim() == "" || MtxtDataPaiN.Text.ToString().Trim() == "" || MtxtCPFPaiN.Text.ToString().Trim() == "" || MtxtDataRegistroN.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Há algum campo que não foi preenchido.\n Por favor preencha-o.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNomeN.Focus();
                return;
            }           
            try
            {
                con.AbrirCon();
                sql = "INSERT INTO nascimento (nome_registrado, data_nascimento_registrado, nome_mae, data_nascimento_mae, cpf_mae, nome_pai, data_nascimento_pai, cpf_pai, data_registro) VALUES (@nome_registrado, @data_nascimento_registrado, @nome_mae, @data_nascimento_mae, @cpf_mae, @nome_pai, @data_nascimento_pai, @cpf_pai, @data_registro)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome_registrado", TxtNomeN.Text);
                DateTime Ndata = Convert.ToDateTime(MtxtDataN.Text);
                cmd.Parameters.Add("@data_nascimento_registrado", MySqlDbType.Date).Value = Ndata;
                cmd.Parameters.AddWithValue("@nome_mae", TxtNomeMaeN.Text);
                DateTime Mdata = Convert.ToDateTime(MtxtDataMaeN.Text);
                cmd.Parameters.Add("@data_nascimento_mae", MySqlDbType.Date).Value = Mdata; 
                cmd.Parameters.AddWithValue("@cpf_mae", MtxtCPFMaeN.Text);
                cmd.Parameters.AddWithValue("@nome_pai", TxtNomePaiN.Text);
                DateTime Pdata = Convert.ToDateTime(MtxtDataPaiN.Text);
                cmd.Parameters.Add("@data_nascimento_pai", MySqlDbType.Date).Value = Pdata;
                cmd.Parameters.AddWithValue("@cpf_pai", MtxtCPFPaiN.Text);
                DateTime Rdata = Convert.ToDateTime(MtxtDataRegistroN.Text);
                cmd.Parameters.Add("@data_registro", MySqlDbType.Date).Value = Rdata;
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
                TxtNomeN.Text = "";
                TxtNomeMaeN.Text = "";
                TxtNomePaiN.Text = "";
                MtxtDataMaeN.Text = "";
                MtxtDataPaiN.Text = "";
                MtxtCPFMaeN.Text = "";
                MtxtCPFPaiN.Text = "";
                MtxtDataN.Text = "";
                MtxtDataRegistroN.Text = "";
                MtxtCPFMaeN.BackColor = Color.White;
                MtxtCPFPaiN.BackColor = Color.White;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }

        }

        private void BtnAjudaN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para pesquisar preencha somente o nome do Registrado e clica no botão ao lado", "Ajuda!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnPesquisarN_Click(object sender, EventArgs e)
        {
            Listar();
            dataGridView1.Visible = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtNomeN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MtxtDataN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtNomeMaeN.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MtxtDataMaeN.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MtxtCPFMaeN.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtNomePaiN.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            MtxtDataPaiN.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MtxtCPFPaiN.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MtxtDataRegistroN.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            BtnSalvar.Enabled = true;
            BtnIncluirN.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirCon();
                sql = "UPDATE nascimento SET nome_registrado = @nome, data_nascimento_registrado = @dataNascimento, nome_mae = @nomeMae, data_nascimento_mae = @dataNascimentoM, cpf_mae = @cpfMae, nome_pai = @nomePai, data_nascimento_pai = @dataNascimentoPai, cpf_pai = @cpfPai, data_registro = @dataRegistro WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id); 
                cmd.Parameters.AddWithValue("@nome", TxtNomeN.Text);
                DateTime Ndata = Convert.ToDateTime(MtxtDataN.Text);
                cmd.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = Ndata;
                cmd.Parameters.AddWithValue("@nomeMae", TxtNomeMaeN.Text);
                DateTime Mdata = Convert.ToDateTime(MtxtDataMaeN.Text);
                cmd.Parameters.Add("@dataNascimentoM", MySqlDbType.Date).Value = Mdata;
                cmd.Parameters.AddWithValue("@cpfMae", MtxtCPFMaeN.Text);
                cmd.Parameters.AddWithValue("@nomePai", TxtNomePaiN.Text);
                DateTime Pdata = Convert.ToDateTime(MtxtDataPaiN.Text);
                cmd.Parameters.Add("@dataNascimentoPai", MySqlDbType.Date).Value = Pdata;
                cmd.Parameters.AddWithValue("@cpfPai", MtxtCPFPaiN.Text);
                DateTime Bdata = Convert.ToDateTime(MtxtDataRegistroN.Text);
                cmd.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = Bdata;
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

        private void MtxtCPFMaeN_Leave(object sender, EventArgs e)
        {
            VerificarCPFMae();
            if (MtxtCPFMaeN.Text == MtxtCPFPaiN.Text)
            {
                MessageBox.Show("Os CPF's não podem ser iguais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnIncluirN.Enabled = false;
                
            }
        }

        private void MtxtCPFPaiN_Leave(object sender, EventArgs e)
        {
            VerificarCPFPai();

            if(MtxtCPFMaeN.Text == MtxtCPFPaiN.Text)
            {
                MessageBox.Show("Os CPF's não podem ser iguais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnIncluirN.Enabled = false;
                
            }
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
           
        }
    }
}
