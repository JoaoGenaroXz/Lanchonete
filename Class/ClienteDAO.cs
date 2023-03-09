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
            string cmdSql = "SELECT * FROM clientes";
            var dadosS = Program.cx.ExecutaSql(cmdSql);
            DataTable dt = new DataTable();
            using (var reader = dadosS.CreateDataReader())
            {
                dt.Load(reader);
            }
            return dt;
        }
    }
}
