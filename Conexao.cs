using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DOC_Projeto
{
    internal class Conexao
    {
        //CONEXAO BANCO DE DADOS LOCAL
        string conec = "SERVER=localhost; DATABASE=doc; user=root; password=senha; PORT=3306; Convert zero datetime=True;";
        //string conec = "SERVER=" localhost ";PORT=" 3306 ";user="root";password="senha";database="doc";
        public MySqlConnection con = null;
        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //DECLARAÇÃO DE OUTRAS VARIAVEIS

    }
}
