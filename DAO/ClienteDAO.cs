using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    internal class ClienteDAO
    {
        public DataTable ListarClientes()
        {
            string cmdSql = "SELECT codigo,nome,apelido,cpfcnpj,rg,endereco,endnum,bairro,cep,cidade FROM clientes WHERE desativado = 'N'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                DataTable dt = new DataTable();
                using (var reader = dadosS.CreateDataReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
            return null;
        }
        public DataTable ListarDesativados()
        {
            string cmdSql = "SELECT codigo,nome,apelido,cpfcnpj,rg,endereco,endnum,bairro,cep,cidade FROM clientes WHERE desativado = 'S'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                DataTable dt = new DataTable();
                using (var reader = dadosS.CreateDataReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
            return null;
        }
        public DataTable Pesquisar(string pesq)
        {
            string cmdSql = "SELECT codigo,nome,apelido,cpfcnpj,rg,endereco,endnum,bairro,cep,cidade FROM clientes WHERE desativado = 'S'";
            var dadosS = Program.cx.ExecutaSql(cmdSql);

            if (dadosS != null)
            {
                DataTable dt = new DataTable();
                using (var reader = dadosS.CreateDataReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
            return null;

        }
    }
}
