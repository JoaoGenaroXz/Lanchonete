using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;


namespace Lanchonete
{
    class Conexao
    {
        private NpgsqlConnection objConexao = new NpgsqlConnection();
        private NpgsqlCommand objComandos = new NpgsqlCommand();
        private NpgsqlDataAdapter objDadoEmMemoria;
        private string MsgErro;
        public string strDeConexao;
        private int lastId;

        public Conexao(string server, string porta,  string dataBase, string user, string password)
        {
            strDeConexao = "Server=" + server + ";";
            strDeConexao += "Port=" + porta + ";";
            strDeConexao += "DataBase=" + dataBase + ";";
            strDeConexao += "User Id=" + user + ";";
            strDeConexao += "Password=" + password + ";";
            strDeConexao += "Integrated Security=True" + ";";
        }

        public int getLastId()
        {
            return this.lastId;

        }

        public string getMsgErro()
        {
            return this.MsgErro;
        }
        private bool conectar()
        {
            try
            {
                desconectar();
                objConexao.ConnectionString = strDeConexao;
                objComandos.Connection = objConexao;
                objConexao.Open();
                return true;
            }
            catch (Exception erro)
            {
                MsgErro = erro.Message.ToString();
                return false;
            }
        }
        private bool desconectar()
        {
            try
            {
                if (objConexao.State == ConnectionState.Open)
                {
                    objConexao.Close();

                }
                return true;
            }
            catch (Exception erro)
            {
                this.MsgErro = erro.Message.ToString();
                return false;
            }
        }
        public bool testarConexao()
        {
            return conectar();
        }

        //comando SQL
        
        public bool ComandoSql (string comandoSql)
        {
            try
            {
                if (conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception erro)
            {
                this.MsgErro = erro.Message.ToString();
                return false;
            }
        }

        public DataTable ExecutaSql(string comandoSql)
        {
            try
            {
                if(conectar())
                {
                    objDadoEmMemoria = new NpgsqlDataAdapter(comandoSql, objConexao);
                    DataTable tabelaDeDados = new DataTable();
                    objDadoEmMemoria.Fill(tabelaDeDados);
                    if(tabelaDeDados.Rows.Count >0)
                    {
                        return tabelaDeDados;
                    }
                }
                return null;
            }
            catch (Exception erro)
            {
                this.MsgErro = erro.Message.ToString();
                return null;
            }
        }
    }
}
