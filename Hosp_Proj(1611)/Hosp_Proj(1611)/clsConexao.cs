using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS_TORRE_161126
{
    internal class ClsConexao
    {
        // Propriedades e conexões
        MySqlConnection Conn = new MySqlConnection();
        public MySqlCommand Cmd = new MySqlCommand();

        private String _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        private string strConexao = "datasource=localhost;username=root;password=;database=DoctorPigeon;";

        private MySqlConnection AbrirBanco()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }

        private void Fechar(MySqlConnection Conn)
        {
            if (Conn != null && Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDataSet() // SELECT para preencher Grid / DataSet
        {
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;

                DA.SelectCommand = Cmd;
                DA.Fill(DS);

                return (DS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Fechar(Conn);
            }
        }

        public MySqlDataReader RetornarDataReader() // SELECT individual (Pesquisa)
        {
            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;

                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutarCmd() // INSERT, UPDATE, DELETE
        {
            try
            {
                Conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Conn;

                return Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                Fechar(Conn);
            }
        }
    }
}