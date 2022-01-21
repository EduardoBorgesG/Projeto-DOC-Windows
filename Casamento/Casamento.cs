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

namespace DOC_Projeto.Casamento
{
    public partial class Casamento : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;

        public Casamento()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            BtnSalvar.Enabled = false;
            TxtCPFInvalido.Visible = false;
        }

        private void VerificarCPFC2()
        {
            if (MtxtCPFC2.Text == "")
            {
                MessageBox.Show("Preencha o CPF");
            }
            else
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string CPF = MtxtCPFC2.Text;
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

                    MtxtCPFC2.BackColor = Color.Green;
                    BtnIncluir.Enabled = true;
                    TxtCPFInvalido.Visible = false;

                }
                else
                {
                    MtxtCPFC2.BackColor = Color.Red;
                    TxtCPFInvalido.Visible = true;
                    BtnIncluir.Enabled = false;
                }
            }
        }

        private void VerificarCPFC1()
        {
            if (MtxtCPFC1.Text == "")
            {
                MessageBox.Show("Preencha o CPF");
            }
            else
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string CPF = MtxtCPFC1.Text;
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

                    MtxtCPFC1.BackColor = Color.Green;
                    BtnIncluir.Enabled = true;
                    TxtCPFInvalido.Visible = false;
                }
                else
                {
                    MtxtCPFC1.BackColor = Color.Red;
                    TxtCPFInvalido.Visible = true;
                    BtnIncluir.Enabled = false;
                }
            }
        }
        private void FormatarDG()
        {
            dataGridView1.Columns[1].HeaderText = "Nome Conjuge 1";
            dataGridView1.Columns[10].HeaderText = "Nome Conjuge 2";
            dataGridView1.Columns[20].HeaderText = "Data do Casamento";
            dataGridView1.Columns[19].HeaderText = "Data do registro";
            


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            


            dataGridView1.Columns[1].Width = 450;
            dataGridView1.Columns[10].Width = 450;
            dataGridView1.Columns[20].Width = 70;
            dataGridView1.Columns[19].Width = 70;
        }


        private void Listar()
        {
            con.AbrirCon();
            sql = "SELECT * FROM casamento WHERE nome_c1 LIKE @nomeC1 OR nome_c2 LIKE @nomeC2";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nomeC1", TxtNomeC1.Text + "%");
            cmd.Parameters.AddWithValue("@nomeC2", TxtNomeC2.Text + "%");
            /*cmd.Parameters.AddWithValue("@dataNascimentoC1", MtxtDataC1.Text);
            cmd.Parameters.AddWithValue("@cpfC1", MtxtCPFC1.Text);
            cmd.Parameters.AddWithValue("@nomeMaeC1", TxtNomeMaeC1.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoMC1", MtxtDataMaeC1.Text);
            cmd.Parameters.AddWithValue("@cpfMaeC1", MtxtCPFMaeC1.Text);
            cmd.Parameters.AddWithValue("@nomePaiC1", TxtNomePaiC1.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoPaiC1", MtxtDataPaiC1.Text);
            cmd.Parameters.AddWithValue("@cpfPaiC1", MtxtCPFPaiC1.Text);     
            cmd.Parameters.AddWithValue("@dataNascimentoC2", MtxtDataC2.Text);
            cmd.Parameters.AddWithValue("@cpfC2", MtxtCPFC2.Text);
            cmd.Parameters.AddWithValue("@nomeMaeC2", TxtNomeMaeC2.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoMC2", MtxtDataMaeC2.Text);
            cmd.Parameters.AddWithValue("@cpfMaeC2", MtxtCPFMaeC2.Text);
            cmd.Parameters.AddWithValue("@nomePaiC2", TxtNomePaiC2.Text);
            cmd.Parameters.AddWithValue("@dataNascimentoPaiC2", MtxtDataPaiC2.Text);
            cmd.Parameters.AddWithValue("@cpfPaiC2", MtxtCPFPaiC2.Text);
            cmd.Parameters.AddWithValue("@dataRegistro", MtxtDataRegistroC.Text);
            cmd.Parameters.AddWithValue("@dataCasamento", MtxtDataCasamento.Text);*/
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

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtNomeC1.Text.ToString().Trim() == "" || MtxtDataC1.Text.ToString().Trim() == "" || MtxtCPFC1.Text.ToString().Trim()=="" || TxtNomeMaeC1.Text.ToString().Trim() == "" || MtxtDataMaeC1.Text.ToString().Trim() == "" || MtxtCPFMaeC1.Text.ToString().Trim() == "" || TxtNomePaiC1.Text.ToString().Trim() == "" || MtxtDataPaiC1.Text.ToString().Trim() == "" || MtxtCPFPaiC1.Text.ToString().Trim() == "" || TxtNomeC2.Text.ToString().Trim() == "" || MtxtDataC2.Text.ToString().Trim() == "" || MtxtCPFC2.Text.ToString().Trim() == "" || TxtNomeMaeC2.Text.ToString().Trim() == "" || MtxtDataMaeC2.Text.ToString().Trim() == "" || MtxtCPFMaeC2.Text.ToString().Trim() == "" || TxtNomePaiC2.Text.ToString().Trim() == "" || MtxtDataPaiC2.Text.ToString().Trim() == "" || MtxtCPFPaiC2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Há algum campo que não foi preenchido. Por favor preencha-o.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                con.AbrirCon();
                sql = "INSERT INTO casamento (nome_c1, data_nascimento_c1, cpf_c1, nome_c1_mae, data_nascimento_c1_mae, cpf_c1_mae, nome_c1_pai, data_nascimento_c1_pai, cpf_c1_pai, nome_c2, data_nascimento_c2, cpf_c2, nome_c2_mae, data_nascimento_c2_mae, cpf_c2_mae, nome_c2_pai, data_nascimento_c2_pai, cpf_c2_pai, data_registro, data_casamento)  VALUES (@nomeC1, @dataNascimentoC1, @cpfC1, @nomeMaeC1, @dataNascimentoMC1, @cpfMaeC1, @nomePaiC1, @dataNascimentoPaiC1, @cpfPaiC1, @nomeC2, @dataNascimentoC2, @cpfC2, @nomeMaeC2, @dataNascimentoMC2, @cpfMaeC2, @nomePaiC2, @dataNascimentoPaiC2, @cpfPaiC2, @dataRegistro, @dataCasamento)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nomeC1", TxtNomeC1.Text);
                DateTime C1data = Convert.ToDateTime(MtxtDataC1.Text);
                cmd.Parameters.Add("@dataNascimentoC1", MySqlDbType.Date).Value = C1data;
                cmd.Parameters.AddWithValue("@cpfC1", MtxtCPFC1.Text);
                cmd.Parameters.AddWithValue("@nomeMaeC1", TxtNomeMaeC1.Text);
                DateTime C1Mdata = Convert.ToDateTime(MtxtDataMaeC1.Text);
                cmd.Parameters.Add("@dataNascimentoMC1", MySqlDbType.Date).Value = C1Mdata;
                cmd.Parameters.AddWithValue("@cpfMaeC1", MtxtCPFMaeC1.Text);
                cmd.Parameters.AddWithValue("@nomePaiC1", TxtNomePaiC1.Text);
                DateTime C1Pdata = Convert.ToDateTime(MtxtDataPaiC1.Text);
                cmd.Parameters.Add("@dataNascimentoPaiC1", MySqlDbType.Date).Value = C1Pdata;
                cmd.Parameters.AddWithValue("@cpfPaiC1", MtxtCPFPaiC1.Text);
                cmd.Parameters.AddWithValue("@nomeC2", TxtNomeC2.Text);
                DateTime C2data = Convert.ToDateTime(MtxtDataC1.Text);
                cmd.Parameters.Add("@dataNascimentoC2", MySqlDbType.Date).Value = C2data;
                cmd.Parameters.AddWithValue("@cpfC2", MtxtCPFC2.Text);
                cmd.Parameters.AddWithValue("@nomeMaeC2", TxtNomeMaeC2.Text);
                DateTime C2Mdata = Convert.ToDateTime(MtxtDataMaeC2.Text);
                cmd.Parameters.Add("@dataNascimentoMC2", MySqlDbType.Date).Value = C2Mdata;
                cmd.Parameters.AddWithValue("@cpfMaeC2", MtxtCPFMaeC2.Text);
                cmd.Parameters.AddWithValue("@nomePaiC2", TxtNomePaiC2.Text);
                DateTime C2Pdata = Convert.ToDateTime(MtxtDataPaiC2.Text);
                cmd.Parameters.Add("@dataNascimentoPaiC2", MySqlDbType.Date).Value = C2Pdata;
                cmd.Parameters.AddWithValue("@cpfPaiC2", MtxtCPFPaiC2.Text);
                DateTime Rdata = Convert.ToDateTime(MtxtDataRegistroC.Text);
                cmd.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = Rdata;
                DateTime Cdata = Convert.ToDateTime(MtxtDataCasamento.Text);
                cmd.Parameters.Add("@dataCasamento", MySqlDbType.Date).Value = Cdata;
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
                TxtNomeC1.Text = "";
                MtxtDataC1.Text = "";
                MtxtCPFC1.Text = "";
                TxtNomeMaeC1.Text = "";
                MtxtDataMaeC1.Text = "";
                MtxtCPFMaeC1.Text = "";
                TxtNomePaiC1.Text = "";
                MtxtDataPaiC1.Text = "";
                MtxtCPFPaiC2.Text = "";
                TxtNomeC2.Text = "";
                MtxtDataC2.Text = "";
                MtxtCPFC2.Text = "";
                TxtNomeMaeC2.Text = "";
                MtxtDataMaeC2.Text = "";
                MtxtCPFMaeC2.Text = "";
                TxtNomePaiC2.Text = "";
                MtxtDataPaiC2.Text = "";
                MtxtCPFPaiC2.Text = "";
                MtxtDataRegistroC.Text = "";
                MtxtDataCasamento.Text = "";
                MtxtCPFC1.BackColor = Color.White;
                MtxtCPFC2.BackColor = Color.White;

            }
        }


        private void BtnPesquisarC_Click(object sender, EventArgs e)
        {
            Listar();
            dataGridView1.Visible = true;
            BtnSalvar.Enabled = true;
            BtnIncluir.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtNomeC1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MtxtDataC1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MtxtCPFC1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtNomeMaeC1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            MtxtDataMaeC1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MtxtCPFMaeC1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtNomePaiC1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MtxtDataPaiC1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            MtxtCPFPaiC1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            TxtNomeC2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            MtxtDataC2.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            MtxtCPFC2.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            TxtNomeMaeC2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            MtxtDataMaeC2.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            MtxtCPFMaeC2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            TxtNomePaiC2.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            MtxtDataPaiC2.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            MtxtCPFPaiC2.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            MtxtDataRegistroC.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            MtxtDataCasamento.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            BtnSalvar.Enabled = true;
            BtnIncluir.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirCon();
                sql = "UPDATE casamento SET nome_c1 = @nomeC1, data_nascimento_c1 = @dataNascimentoC1, cpf_c1 = @cpfC1, nome_c1_mae = @nomeMaeC1, data_nascimento_c1_mae = @dataNascimentoMC1, cpf_c1_mae = @cpfMaeC1, nome_c1_pai = @nomePaiC1, data_nascimento_c1_pai = @dataNascimentoPaiC1, cpf_c1_pai = @cpfPaiC1, nome_c2 = @nomeC2, data_nascimento_c2 = @dataNascimentoC2, cpf_c2 = @cpfC2, nome_c2_mae = @nomeMaeC2, data_nascimento_c2_mae = @dataNascimentoMC2, cpf_c2_mae = @cpfMaeC2, nome_c2_pai = @nomePaiC2, data_nascimento_c2_pai = @dataNascimentoPaiC2, cpf_c2_pai = @cpfPaiC2, data_registro = @dataRegistro, data_casamento = @dataCasamento WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nomeC1", TxtNomeC1.Text);
                DateTime C1data = Convert.ToDateTime(MtxtDataC1.Text);
                cmd.Parameters.Add("@dataNascimentoC1", MySqlDbType.Date).Value = C1data;
                cmd.Parameters.AddWithValue("@cpfC1", MtxtCPFC1.Text);
                cmd.Parameters.AddWithValue("@nomeMaeC1", TxtNomeMaeC1.Text);
                DateTime C1Mdata = Convert.ToDateTime(MtxtDataMaeC1.Text);
                cmd.Parameters.Add("@dataNascimentoMC1", MySqlDbType.Date).Value = C1Mdata;
                cmd.Parameters.AddWithValue("@cpfMaeC1", MtxtCPFMaeC1.Text);
                cmd.Parameters.AddWithValue("@nomePaiC1", TxtNomePaiC1.Text);
                DateTime C1Pdata = Convert.ToDateTime(MtxtDataPaiC1.Text);
                cmd.Parameters.Add("@dataNascimentoPaiC1", MySqlDbType.Date).Value = C1Pdata;
                cmd.Parameters.AddWithValue("@cpfPaiC1", MtxtCPFPaiC1.Text);
                cmd.Parameters.AddWithValue("@nomeC2", TxtNomeC2.Text);
                DateTime C2data = Convert.ToDateTime(MtxtDataC2.Text);
                cmd.Parameters.Add("@dataNascimentoC2", MySqlDbType.Date).Value = C2data;
                cmd.Parameters.AddWithValue("@cpfC2", MtxtCPFC2.Text);
                cmd.Parameters.AddWithValue("@nomeMaeC2", TxtNomeMaeC2.Text);
                DateTime C2Mdata = Convert.ToDateTime(MtxtDataMaeC2.Text);
                cmd.Parameters.Add("@dataNascimentoMC2", MySqlDbType.Date).Value = C2Mdata;
                cmd.Parameters.AddWithValue("@cpfMaeC2", MtxtCPFMaeC2.Text);
                cmd.Parameters.AddWithValue("@nomePaiC2", TxtNomePaiC2.Text);
                DateTime C2Pdata = Convert.ToDateTime(MtxtDataPaiC2.Text);
                cmd.Parameters.Add("@dataNascimentoPaiC2", MySqlDbType.Date).Value = C2Pdata;
                cmd.Parameters.AddWithValue("@cpfPaiC2", MtxtCPFPaiC2.Text);
                DateTime Rdata = Convert.ToDateTime(MtxtDataRegistroC.Text);
                cmd.Parameters.Add("@dataRegistro", MySqlDbType.Date).Value = Rdata;
                DateTime Cdata = Convert.ToDateTime(MtxtDataCasamento.Text);
                cmd.Parameters.Add("@dataCasamento", MySqlDbType.Date).Value = Cdata;
                cmd.ExecuteNonQuery();
                con.FecharCon();
            }
            catch (Exception)
            {

                throw;
            }
            var resultado = MessageBox.Show("Registro alterado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Close();
            }

        }

        private void MtxtCPFC1_Leave(object sender, EventArgs e)
        {
            VerificarCPFC1();
            if (MtxtCPFC1.Text == MtxtCPFC2.Text)
            {
                MessageBox.Show("Os CPF's não podem ser iguais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnIncluir.Enabled = false;

            }
        }

        private void MtxtCPFC2_Leave(object sender, EventArgs e)
        {
            VerificarCPFC2();
            if (MtxtCPFC2.Text == MtxtCPFC1.Text)
            {
                MessageBox.Show("Os CPF's não podem ser iguais!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnIncluir.Enabled = false;

            }
        }
    }
}
